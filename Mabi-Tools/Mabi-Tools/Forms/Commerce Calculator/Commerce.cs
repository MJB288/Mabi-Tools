using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mabi_Tools
{
    public partial class frmCommerce : Form
    {
        //Remembers the actively selected index for each checklist box.
        //Adjust these values to change the default selected value. If I make a configure file, I could add an option to change the default
        private int ClboxprevSelectedG = 0, ClboxprevSelectedT = 0;
        //These are for tracking the weight and slot capacity of the currently selected good
        private int SelectedGoodWeight = 0, SelectedGoodSlots = 0;
        //These are for tracking the current Weight Capacity and Slots of the transport
        private int SelectedTransportWeight = 0, SelectedTransportSlots = 0;
        private Dictionary<String, City> CityData;
        private Dictionary<String, Transport> TransportData;
        //Keeping this in global memory for filter purposes
        private Dictionary<String, int> EndResults;
        private Label[] CityLabels;
        private TextBox[] CityTextboxes;
        
        public frmCommerce()
        {
            InitializeComponent();
        }

        //Event Handler Methods
        //-------------------------------------------------------------------------------------
        private void frmCommerce_Load(object sender, EventArgs e)
        {
            //First Load the Cities
            //While it is extremely unlikely that they'll add another city or trade post to the game
            //I decided to add dynamic loading into the mix to allow for more flexiility in the event it happens anyway
            //TODO- Move from loading from a text file to other forms of storage
            //this.loadCommerceData("Cities.txt");
            try
            {
                CityData = CommerceDataHandler.loadCommerceDataText("Resources/Cities.csv");
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show("Error while loading City data : \n" + ex.Message, "Error");
                //We can't proceed without city data - close
                this.Close();
            }
            
            UIHelper.populateCityCheckListBox(clboxCities, CityData);

            Label[] testLabels = { lblTown0, lblTown1, lblTown2, lblTown3, lblTown4, lblTown5, lblTown6, lblTown7, lblTown8, lblTown9 };
            TextBox[] textBoxes = { txtTown0, txtTown1, txtTown2, txtTown3, txtTown4, txtTown5, txtTown6, txtTown7, txtTown8, txtTown9 };
            CityLabels = testLabels;
            CityTextboxes = textBoxes;
            testLabels = null;
            textBoxes = null;

            //Similarly, with the transport Mounts
            try
            {
                TransportData = CommerceDataHandler.loadTransportDataText("Resources/Transport.csv");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error while loading Transport Data : \n" + ex.Message, "Error");
                this.Close();
            }

            UIHelper.generateRadioButtons(flpTransport, TransportData, this);

            //Adjust Visibility based on the amount of towns detected.
            this.adjustTextBoxesVisibilityCommerce();
            this.adjustLabelsCities(0, 0);

            //Check off the default value in the lists when loading
            
            clboxCities.SetItemChecked(this.ClboxprevSelectedT, true);
            clboxCities.SelectedItem = clboxCities.Items[ClboxprevSelectedG];
            UIHelper.populateGoodCheckListBox(clboxGoods, CityData[CityData.Keys.ToList()[this.ClboxprevSelectedT]], ClboxprevSelectedG);
            
            //Check off the first one for now.
            flpTransport.Controls.OfType<RadioButton>().First().Checked = true;
            String[] arr = { "1", "2" };
            ListViewItem lItem = new ListViewItem(arr);
            lviewResults.Items.Add(lItem);
            
        }

        private void clboxGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClboxprevSelectedG = UIHelper.makeListBoxExclusitivity(clboxGoods, ClboxprevSelectedG);
            lblTest.Text = clboxGoods.SelectedItem.ToString();
            //Now pull up the Weight And Slot statistics
            SelectedGoodSlots = CityData[clboxCities.SelectedItem.ToString()].goods[ClboxprevSelectedG].slotCapacity;
            SelectedGoodWeight = CityData[clboxCities.SelectedItem.ToString()].goods[ClboxprevSelectedG].weight;
            lblItemWeight.Text = "Weight : " + SelectedGoodWeight;
            lblItemSlots.Text = "Slot Capacity : " + SelectedGoodSlots;
        }

        private void clboxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Adjust as necessary 
            adjustLabelsCities(ClboxprevSelectedT, clboxCities.SelectedIndex);
            ClboxprevSelectedT = UIHelper.makeListBoxExclusitivity(clboxCities, ClboxprevSelectedT);
            lblTest.Text = clboxCities.SelectedItem.ToString();
            //Now adjust the Goods Box based off of the currently selected city
            UIHelper.populateGoodCheckListBox(clboxGoods, CityData[clboxCities.SelectedItem.ToString()], ClboxprevSelectedG);

        }

        //Form Adjustment Methods
        //----------------------------------------------------------------------------------------------------------

        //Since this will be implementation specific - just use the form variables
        private void adjustTextBoxesVisibilityCommerce()
        {
            //Since I left room for a couple Extra cities - adjust visibility based on the amount of detected cities
            //Needs to be adjusted for more flexibility and more reusability friendly
            for(int i = 9; i >= CityData.Count; i--)
            {
                CityLabels[i].Visible = false;
                CityTextboxes[i].Visible = false;
            }
        }

        private void adjustLabelsCities(int oldindex, int newIndex)
        {
            if(oldindex > newIndex)
            {
                oldindex = newIndex;
            }
               
            //Let's Loop Through all of them. Could Adjust that only start at the one that was previously changed
            for(int i = oldindex; i < CityData.Count; i++)
            {
                //
                if (i == CityData.Count - 1)
                {
                    CityLabels[i].Text = "Smuggler";
                }
                else if (i >= newIndex)
                {
                    CityLabels[i].Text = CityData.Keys.ToList()[i + 1];
                }
                else
                {
                    CityLabels[i].Text = CityData.Keys.ToList()[i];
                }
            }
        }

       

        //Methods for loading data from files
        //-------------------------------------------------------------------------------------------------

        private void cboxCommerce_CheckedChanged(object sender, EventArgs e)
        {
            //Increment if checked - Decrement if not Checked
            if (cboxCommerce.Checked) 
            { 
                //The alpaca bonus cannot stack with the commerce partner bonus.
                cboxAlpaca.Checked = false;
                SelectedTransportSlots += 1;
                SelectedTransportWeight += 100;
            }
            else
            {
                SelectedTransportSlots -= 1;
                SelectedTransportWeight -= 100;
            }


            lblTransportSlots.Text = "Slots : " + SelectedTransportSlots;
            lblTransportWeight.Text = "Weight Capacity : " + SelectedTransportWeight;
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editCityDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCommerceCityEditor cityEditor = new frmCommerceCityEditor(CityData, this);
            //This time we want the player to make a definitive choice on editing the data before they return to frmCommerce
            cityEditor.ShowDialog();
        }

        private void btnDucats_Click(object sender, EventArgs e)
        {
            //Switch colors
            btnDucats.BackColor = Color.PaleGreen;
            btnNetProfit.BackColor = Color.LightGray;
        }

        private void btnNetProfit_Click(object sender, EventArgs e)
        {
            btnNetProfit.BackColor = Color.PaleGreen;
            btnDucats.BackColor = Color.LightGray;
            
        }

        private void cboxAlpaca_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxAlpaca.Checked)
            {
                cboxCommerce.Checked = false;
                SelectedTransportSlots += 2;
                SelectedTransportWeight += 200;

            }
            else
            {
                SelectedTransportSlots -= 2;
                SelectedTransportWeight -= 200;
            }
            lblTransportSlots.Text = "Slots : " + SelectedTransportSlots;
            lblTransportWeight.Text = "Weight Capacity : " + SelectedTransportWeight;
        }

        public void rbtnTransport_CheckedChanged(object sender, EventArgs e)
        {
            //The RadioButton Text should be exactly the same as the indexes used in the Dictionary. An alternative would be using the number found at the end of each radiobutton name
            RadioButton selectedRBTN = flpTransport.Controls.OfType<RadioButton>().FirstOrDefault(rbtn => rbtn.Checked);
            SelectedTransportSlots = TransportData[selectedRBTN.Text].slots;
            SelectedTransportWeight = TransportData[selectedRBTN.Text].weight;
           
            //If the player has a commerce partner - they get a small boost to weight capacity and slots
            if (cboxCommerce.Checked)
            {
                SelectedTransportSlots += 1;
                SelectedTransportWeight += 100;
            }
            //Enable the player to check the Alpaca bonus
            if(selectedRBTN.Text.Equals("Wagon"))
            {
                cboxAlpaca.Enabled = true;
            }
            else
            {
                //Trigger the CheckedChanged for the alpaca to cause it to auto decrement instead of decrementing here
                cboxAlpaca.Checked = false;
                cboxAlpaca.Enabled = false;
            }
            lblTransportSlots.Text = "Slots : " + SelectedTransportSlots;
            lblTransportWeight.Text = "Weight Capacity : " + SelectedTransportWeight;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            EndResults = new Dictionary<string, int>();
            lviewResults.Items.Clear();
            //For now - we will assume the player is transporting one good at a time. Later, I will add functioanlity for mixing and matching if necessary
            int numGoods = 0;
            //Calculate the total number of goods
            //First - assume we can fill the toal number of slots
            int ongoingWeight = SelectedGoodWeight * SelectedGoodSlots * SelectedTransportSlots;
            //Now check if we're over the weight limit - if yes then reduce the number of goods
            if(ongoingWeight > SelectedTransportWeight)
            {
                numGoods = SelectedTransportWeight / SelectedGoodWeight;
            }
            else
            {
                numGoods = SelectedGoodSlots * SelectedTransportSlots;
            }

            //Loop Through all of the text boxes
            for(int i = 0; i < CityData.Count; i++)
            {
                try
                {
                    EndResults[CityLabels[i].Text] = (Int32.Parse(CityTextboxes[i].Text) * numGoods);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Format Error - Could not parse Integer from price in '" + CityLabels[i].Text + "'", "Error");
                    EndResults[CityLabels[i].Text] = 0;
                }
            }
            foreach (KeyValuePair<String, int> townPrice in EndResults.OrderByDescending(key => key.Value))
            {
                String[] arr = { townPrice.Key, "" + townPrice.Value};
                ListViewItem newItem = new ListViewItem(arr);
                lviewResults.Items.Add(newItem);
            }
        }
    }
}
