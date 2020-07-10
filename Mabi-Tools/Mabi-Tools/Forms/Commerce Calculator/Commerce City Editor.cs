using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabi_Tools
{
    public partial class frmCommerceCityEditor : Form
    {
        private Dictionary<String, City> CityData, oldData;
        private int ClboxPrevSelectedC = 0, ClboxPrevSelectedG = 0;
        private frmCommerce commerce;
        public frmCommerceCityEditor(Dictionary<String, City> cityData, frmCommerce Commerce)
        {
            commerce = Commerce;
            CityData = new Dictionary<string, City>(cityData);
            oldData = cityData;
            InitializeComponent();
           
        }

        private void frmCommerceCityEditor_Load(object sender, EventArgs e)
        {
            //When we first load - set the data in the checklist boxes
            UIHelper.populateCityCheckListBox(clboxCities, CityData);
            clboxCities.SelectedIndex = ClboxPrevSelectedC;
        }

        private void clboxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClboxPrevSelectedC = UIHelper.makeListBoxExclusitivity(clboxCities, ClboxPrevSelectedC);
            //Since it is now possible for this event to fire with a null selected Item - add checks in for that
            if (clboxCities.SelectedItem != null)
            {
                UIHelper.populateGoodCheckListBox(clboxGoods, CityData[clboxCities.SelectedItem.ToString()], ClboxPrevSelectedG);
                txtCityName.Text = clboxCities.SelectedItem.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Don't save anything - close the window
            this.Close();
        }

        private void clboxGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClboxPrevSelectedG = UIHelper.makeListBoxExclusitivity(clboxGoods, ClboxPrevSelectedG);
            Good selectedGood = CityData[clboxCities.SelectedItem.ToString()].goods[ClboxPrevSelectedG];
            //Display the data in the text boxes for editing
            txtGoodName.Text = selectedGood.name;
            txtGoodSlots.Text = selectedGood.slotCapacity.ToString();
            txtGoodWeight.Text = selectedGood.weight.ToString();
        }

        private void btnEditCity_Click(object sender, EventArgs e)
        {
            //First - check that the new name doesn't exist in the current momemnt. We can afford to loop through all of them since the number of cities will stay a really small number
            foreach(var item in clboxCities.Items)
            {
                if (item.ToString().Equals(txtCityName.Text))
                {
                    MessageBox.Show("City name '" + txtCityName.Text + "' already exists!", "Existence Error");
                    return;
                }
            }

            //First - move the old city data to the new name;
            CityData[txtCityName.Text] = CityData[clboxCities.SelectedItem.ToString()];
            //Now rename the city object
            CityData[txtCityName.Text].name = txtCityName.Text;
            
            
            CityData[clboxCities.SelectedItem.ToString()] = null;

            clboxCities.Items.Insert(ClboxPrevSelectedC, txtCityName.Text);
            clboxCities.Items.RemoveAt(ClboxPrevSelectedC + 1);
            
            clboxCities.SelectedIndex = 0;
            ClboxPrevSelectedC = 0;
            clboxCities.SetItemChecked(0, true);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            String newCityName = txtCityName.Text;
            CityData[newCityName] = new City(newCityName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save the data and apply it to the form sent to us
            oldData = CityData;
            /*foreach(KeyValuePair<String, City> ksp in CityData)
            {
                MessageBox.Show(ksp.Key + " || " + ksp.Value, "Test");
            }
            CommerceDataHandler.saveCommerceDataCSV("Cities.csv", CityData);*/
            CommerceDataHandler.saveCommerceDataCSVOrdered("Resources/Cities.csv", CityData, clboxCities);
            this.Close();
        }
    }
}
