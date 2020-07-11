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
            if (ClboxPrevSelectedG >= 0 && ClboxPrevSelectedG < clboxGoods.Items.Count)
            {

                Good selectedGood = CityData[clboxCities.SelectedItem.ToString()].goods[ClboxPrevSelectedG];
                //Display the data in the text boxes for editing
                txtGoodName.Text = selectedGood.name;
                txtGoodSlots.Text = selectedGood.slotCapacity.ToString();
                txtGoodWeight.Text = selectedGood.weight.ToString();

                checkedIndexChanged = true;
            }
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            if (!checkForUniqueItem(txtCityName.Text, clboxCities))
            {
                MessageBox.Show("City '" + txtCityName.Text + "' already exists!", "Existence Error");
                return;
            }

            //First create the new object
            String newCityName = txtCityName.Text;
            //TODO-Add a check before saving that all cities have at least one good
            CityData[newCityName] = new City(newCityName);

            clboxCities.Items.Add(newCityName);
        }

        private void btnEditCity_Click(object sender, EventArgs e)
        {
            //First - check that the new name doesn't exist in the current momemnt. We can afford to loop through all of them since the number of cities will stay a really small number
            if (!checkForUniqueItem(txtCityName.Text, clboxCities))
            {
                MessageBox.Show("City '" + txtCityName.Text + "' already exists!", "Existence Error");
                return;
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

            CityData.Remove(clboxCities.SelectedItem.ToString());

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
            waitUntilIndexChanged();

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
            if (!checkForUniqueItem(txtGoodName.Text, clboxGoods))
            {
                MessageBox.Show("Good '" + txtGoodName.Text + "' already exists!", "Existence Error");
                return;
            }
            try
            {
                CityData[clboxCities.SelectedItem.ToString()].goods.Add(new Good(txtGoodName.Text, Int32.Parse(txtGoodWeight.Text), Int32.Parse(txtGoodSlots.Text)));
                clboxGoods.Items.Add(txtGoodName.Text);
            }
            catch(FormatException fex)
            {
                //If  throws a format exception - don't bothe radding it
                MessageBox.Show("Error while formatting new good : \n" + fex.Message, "Format Error");
            }
        }

        private void btnEditGood_Click(object sender, EventArgs e)
        {
            if (!checkForUniqueItem(txtGoodName.Text, clboxGoods))
            {
                MessageBox.Show("Good '" + txtGoodName.Text + "' already exists!", "Existence Error");
                return;
            }
            try
            {
                //Override the current good with the new one
                CityData[clboxCities.SelectedItem.ToString()].goods[clboxGoods.SelectedIndex] = new Good(txtGoodName.Text, Int32.Parse(txtGoodWeight.Text), Int32.Parse(txtGoodSlots.Text));
                clboxGoods.Items.Insert(ClboxPrevSelectedG + 1, txtGoodName.Text);
                clboxGoods.SetItemChecked(ClboxPrevSelectedG + 1, true);

                clboxGoods.Items.RemoveAt(ClboxPrevSelectedG);
                clboxGoods.SelectedIndex = ClboxPrevSelectedG + 1;

            }
            catch(FormatException fex)
            {
                //If  throws a format exception - don't bothe radding it
                MessageBox.Show("Error while formatting new good : \n" + fex.Message, "Format Error");
            }
}

        private void btnMoveUpCity_Click(object sender, EventArgs e)
        {
            ClboxPrevSelectedC = UIHelper.moveSelectedItemUpChecklist(clboxCities);
        }

        private void btnMoveDownCity_Click(object sender, EventArgs e)
        {
            ClboxPrevSelectedC = UIHelper.moveSelectedItemDownChecklist(clboxCities);
        }

        private void btnMoveUpGood_Click(object sender, EventArgs e)
        {
            ClboxPrevSelectedG = UIHelper.moveSelectedItemUpChecklist(clboxGoods);
        }

        private void btnMoveDownGood_Click(object sender, EventArgs e)
        {
            ClboxPrevSelectedG = UIHelper.moveSelectedItemDownChecklist(clboxGoods);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save the data and apply it to the form sent to us
            //oldData = CityData;
            //commerce.CityData = this.CityData;
            Dictionary<String, City> newData = new Dictionary<string, City>();


            //TODO-Add a check before saving that all cities have at least one good
            /*foreach (KeyValuePair<String, City> kvp in CityData)
            {
                if (kvp.Value == null) 
                {
                    continue;
                }
                if(kvp.Value.goods.Count == 0)
                { 
                    CityData[kvp.Key] = null;
                    continue;
                }
                n
            }*/
            for(int i = 0; i < clboxCities.Items.Count; i++)
            {
                //Check if item is null or has a good count of 0
                if(CityData[clboxCities.Items[i].ToString()] == null || CityData[clboxCities.Items[i].ToString()].goods.Count == 0)
                {
                    //Set it to null (nothing is changed if already null) so that save function doesn't write it
                    CityData[clboxCities.Items[i].ToString()] = null;
                    continue;
                }
                //Since the only order to dictionary keys are the order they are inserted and can't be rearranged - we have to construct a new dictionary with the user intended order
                //for the order change to show up in frmCommerce
                newData[clboxCities.Items[i].ToString()] = CityData[clboxCities.Items[i].ToString()];
            }
            commerce.CityData = newData;
            CommerceDataHandler.saveCommerceDataCSVOrdered("Resources/Cities.csv", CityData, clboxCities);
            this.Close();
        }

        private void waitUntilIndexChanged()
        {
            for (int i = 0; i < 10 && !checkedIndexChanged; i++)
            {
                UIHelper.Delay(50);
            }
        }

        private Boolean checkForUniqueItem(String newItem, CheckedListBox clbox)
        {
            //First - check that the new name doesn't exist in the current momemnt. We can afford to loop through all of them since the number of cities will stay a really small number
            foreach (var item in clbox.Items)
            {
                if (item.ToString().Equals(newItem))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
