using Mabi_Tools.Classes;
using Mabi_Tools.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabi_Tools.Forms.Commerce_Calculator
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
            UIHelper.populateCheckListBox(clboxCities, CityData.Keys.ToArray());
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
            if (clboxGoods.SelectedIndex >= 0 && clboxGoods.SelectedIndex < CityData[clboxCities.SelectedItem.ToString()].goods.Count)
            {

                Good selectedGood = CityData[clboxCities.SelectedItem.ToString()].goods[clboxGoods.SelectedIndex];
                //Display the data in the text boxes for editing
                txtGoodName.Text = selectedGood.name;
                txtGoodSlots.Text = selectedGood.slotCapacity.ToString();
                txtGoodWeight.Text = selectedGood.weight.ToString();
            }
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            if (!UIHelper.checkForUniqueItem(txtCityName.Text, clboxCities))
            {
                MessageBox.Show("City '" + txtCityName.Text + "' already exists!", "Existence Error");
                return;
            }

            if(txtCityName.Text.Contains(CommerceDataHandler.MAIN_TEXT_SEPARATOR) || txtGoodName.Text.Contains(CommerceDataHandler.SECONDARY_TEXT_SEPARATOR))
            {
                MessageBox.Show("Error - city name may not contain either '" + CommerceDataHandler.MAIN_TEXT_SEPARATOR + "' or '" + CommerceDataHandler.SECONDARY_TEXT_SEPARATOR + "' !");
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
            if (!UIHelper.checkForUniqueItem(txtCityName.Text, clboxCities))
            {
                MessageBox.Show("City '" + txtCityName.Text + "' already exists!", "Existence Error");
                return;
            }

            if (txtCityName.Text.Contains(CommerceDataHandler.MAIN_TEXT_SEPARATOR) || txtGoodName.Text.Contains(CommerceDataHandler.SECONDARY_TEXT_SEPARATOR))
            {
                MessageBox.Show("Error - city name may not contain either '" + CommerceDataHandler.MAIN_TEXT_SEPARATOR + "' or '" + CommerceDataHandler.SECONDARY_TEXT_SEPARATOR + "' !");
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
                MessageBox.Show("Cannot have a city count of 0! Create another city before deleting this one!", "User Error");
                return;
            }


            CityData.Remove(clboxCities.SelectedItem.ToString());

            UIHelper.deleteItemFromList(clboxCities);
        }

        private void btnAddGood_Click(object sender, EventArgs e)
        {
            if (!UIHelper.checkForUniqueItem(txtGoodName.Text, clboxGoods))
            {
                MessageBox.Show("Good '" + txtGoodName.Text + "' already exists!", "Existence Error");
                return;
            }

            if (txtGoodName.Text.Contains(CommerceDataHandler.MAIN_TEXT_SEPARATOR) || txtGoodName.Text.Contains(CommerceDataHandler.SECONDARY_TEXT_SEPARATOR))
            {
                MessageBox.Show("Error - Good name may not contain either '" + CommerceDataHandler.MAIN_TEXT_SEPARATOR + "' or '" + CommerceDataHandler.SECONDARY_TEXT_SEPARATOR + "' !");
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
            if (!UIHelper.checkForUniqueItem(txtGoodName.Text, clboxGoods))
            {
                MessageBox.Show("Good '" + txtGoodName.Text + "' already exists!", "Existence Error");
                return;
            }

            if (txtGoodName.Text.Contains(CommerceDataHandler.MAIN_TEXT_SEPARATOR) || txtGoodName.Text.Contains(CommerceDataHandler.SECONDARY_TEXT_SEPARATOR))
            {
                MessageBox.Show("Error - Good name may not contain either '" + CommerceDataHandler.MAIN_TEXT_SEPARATOR + "' or '" + CommerceDataHandler.SECONDARY_TEXT_SEPARATOR + "' !");
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
            Dictionary<String, City> newData = new Dictionary<string, City>();


            //TODO-Add a check before saving that all cities have at least one good
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
            CommerceDataHandler.saveCommerceDataOrdered(Settings.Default.CityFilePath, CityData, clboxCities);
            this.Close();
        }

        private void btnDeleteGood_Click(object sender, EventArgs e)
        {
            //first check that we are not at 0 or 1 
            if (clboxGoods.Items.Count == 0 || clboxGoods.SelectedItem == null)
            {
                MessageBox.Show("No item selected!", "Delete Error");
                return;
            }
            //I'm mandating a minimum good count of 1 primarily for saving purposes. Also controls 
            if (clboxGoods.Items.Count == 1)
            {
                MessageBox.Show("Only 1 Good remains. Create another good first or delete the city!", "Error");
                return;
            }
            //Now that we've cleared that - delete the good based on the selected index
            CityData[clboxCities.SelectedItem.ToString()].goods.RemoveAt(clboxGoods.SelectedIndex);
            //Now remove the item from the list
            //First move the index
            /*Boolean indexAt0 = false;
            if(clboxGoods.SelectedIndex == 0)
            {
                clboxGoods.SelectedIndex = 1;
                indexAt0 = true;
            }
            else
            {
                clboxGoods.SelectedIndex = clboxGoods.SelectedIndex - 1;
            }
            //Adjust the variables
            ClboxPrevSelectedG = clboxGoods.SelectedIndex;
            //Then delete the item from the window
            if (indexAt0)
            {
                clboxGoods.Items.RemoveAt(0);
            }
            else
            {
                clboxGoods.Items.RemoveAt(clboxGoods.SelectedIndex + 1);
            }
            //Since selection doesn't automatically check off the box - just do this
            clboxGoods.SetItemChecked(clboxGoods.SelectedIndex, true);*/
            UIHelper.deleteItemFromList(clboxGoods);
        }

       /* private void waitUntilIndexChanged()
        {
            for (int i = 0; i < 10 && !checkedIndexChanged; i++)
            {
                UIHelper.Delay(50);
            }
        }*/

       
    }
}
