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
        private Boolean checkedIndexChanged = true;
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
            checkedIndexChanged = true;
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

            checkedIndexChanged = true;
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
            //We don't want the user to delete the very last city - 
            if(clboxCities.Items.Count == 1)
            {
                MessageBox.Show("Cannot have a city count of 0! Create a nother city before deleting this one!", "User Error");
                return;
            }
            Boolean indexAt0 = ClboxPrevSelectedC == 0;
            checkedIndexChanged = false;
            //Select the previous item - or the next item if 0
            if (indexAt0)
            {
                clboxCities.SelectedIndex = ClboxPrevSelectedC + 1;
            }
            else
            {
                clboxCities.SelectedIndex = ClboxPrevSelectedC - 1;   
            }
            //Wait a little bit so that the clboxCities_selectedIndex can fire and complete
            //But automatically breakout after a small time limit if it doesn't happen
            for (int i = 0; i < 10 && !checkedIndexChanged; i++)
            {
                UIHelper.Delay(50);
            }
            clboxCities.SetItemChecked(ClboxPrevSelectedC, true);
            if (indexAt0)
            {
                clboxCities.Items.RemoveAt(ClboxPrevSelectedC - 1);
            }
            else 
            {
                clboxCities.Items.RemoveAt(ClboxPrevSelectedC + 1);
            }
        }

        private void btnAddGood_Click(object sender, EventArgs e)
        {
            try
            {
                CityData[clboxCities.SelectedItem.ToString()].goods.Add(new Good(txtGoodName.Text, Int32.Parse(txtGoodWeight.Text), Int32.Parse(txtGoodSlots.Text)));
            }
            catch(FormatException fex)
            {
                //If  throws a format exception - don't bothe radding it
                MessageBox.Show("Error while formatting new good : \n" + fex.Message, "Format Error");
            }
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            //First create the new object
            String newCityName = txtCityName.Text;
            //TODO-Add a check before saving that all cities have at least one good
            CityData[newCityName] = new City(newCityName);

            clboxCities.Items.Add(newCityName);
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
            //TODO-Add a check before saving that all cities have at least one good
            CommerceDataHandler.saveCommerceDataCSVOrdered("Resources/Cities.csv", CityData, clboxCities);
            this.Close();
        }
    }
}
