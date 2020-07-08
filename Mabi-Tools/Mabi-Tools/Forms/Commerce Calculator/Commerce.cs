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
        private readonly char MAIN_TEXT_SEPARATOR = '`';
        private readonly char SECONDARY_TEXT_SEPARATOR = ';';
        //Remembers the actively selected index for each checklist box.
        //Adjust these values to change the default selected value. If I make a configure file, I could add an option to change the default
        private int clboxprevSelectedG = 0, clboxprevSelectedT = 0;
        //These are for tracking the weight and slot capacity of the currently selected good
        private int selectedGoodWeight = 0, selectedGoodSlots = 0;
        //These are for tracking the current Weight Capacity and Slots of the transport
        private int selectedTransportWeight = 0, selectedTransportSlots = 0;
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
                CityData = CommerceDataLoader.loadCommerceDataText("Cities.txt");
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
                TransportData = CommerceDataLoader.loadTransportDataText("Transport.txt");
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
            
            clboxCities.SetItemChecked(this.clboxprevSelectedT, true);
            clboxCities.SelectedItem = clboxCities.Items[clboxprevSelectedG];
            UIHelper.populateGoodCheckListBox(clboxGoods, CityData[CityData.Keys.ToList()[this.clboxprevSelectedT]], clboxprevSelectedG);
            
            //Check off the first one for now.
            flpTransport.Controls.OfType<RadioButton>().First().Checked = true;
            
        }

        private void clboxGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            clboxprevSelectedG = UIHelper.makeListBoxExclusitivity(clboxGoods, clboxprevSelectedG);
            lblTest.Text = clboxGoods.SelectedItem.ToString();
            //Now pull up the Weight And Slot statistics
            selectedGoodSlots = CityData[clboxCities.SelectedItem.ToString()].goods[clboxprevSelectedG].slotCapacity;
            selectedGoodWeight = CityData[clboxCities.SelectedItem.ToString()].goods[clboxprevSelectedG].weight;
            lblItemWeight.Text = "Weight : " + selectedGoodWeight;
            lblItemSlots.Text = "Slot Capacity : " + selectedGoodSlots;
        }

        private void clboxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Adjust as necessary 
            adjustLabelsCities(clboxprevSelectedT, clboxCities.SelectedIndex);
            clboxprevSelectedT = UIHelper.makeListBoxExclusitivity(clboxCities, clboxprevSelectedT);
            lblTest.Text = clboxCities.SelectedItem.ToString();
            //Now adjust the Goods Box based off of the currently selected city
            UIHelper.populateGoodCheckListBox(clboxGoods, CityData[clboxCities.SelectedItem.ToString()], clboxprevSelectedG);

        }

        //Form Adjustment Methods
        //----------------------------------------------------------------------------------------------------------
        //Let's turn this into a method for reusability
       

        
        //There are some subtle changes in this method which is why I'm not reusing the one above this
        

       

        

        //Since this will be implementation specific - just use the form variables
        private void adjustTextBoxesVisibilityCommerce()
        {
            //Since I left room for a couple Extra cities - adjust visibility based on the amount of detected cities
            //Needs to be adjusted for more flexibility and more reusability friendly
            if(10 - CityData.Count > 0)
            {
                labelTextBoxInvisible(lblTown9, txtTown9);
                if (10 - CityData.Count > 1)
                {
                    labelTextBoxInvisible(lblTown8, txtTown8);
                }
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

        private static void labelTextBoxInvisible(Label label, TextBox txtbox)
        {
            label.Visible = false;
            txtbox.Visible = false;
        }

        //Methods for loading data from files
        //-------------------------------------------------------------------------------------------------
        private void loadTransportData(String transportFile)
        {
            TransportData = new Dictionary<String, Transport>();
            //Moving this variable out for Error Reporting
            String name = "";
            //Will be expanded upon later - for now only need name of transports
            try
            { 
                string[] rawdata = File.ReadAllLines(transportFile);
                foreach (String s in rawdata)
                {
                    //This could be condensed into one line of code, saving a bit of memory, but for Readability purposes I decided against that
                    /*int graveI = s.IndexOf(MAIN_TEXT_SEPARATOR);
                    int semiI = s.IndexOf(";");
                    name = s.Substring(0, graveI);
                    String slots = s.Substring(graveI + 1, semiI - graveI - 1);
                    String weight = s.Substring(semiI + 1, s.Length - semiI - 1);*/
                    String[] split = s.Split('`');
                    name = split[0];
                    //Current ordering assumes number of slots comes first and weight second
                    Transport temp = new Transport(name, Int32.Parse(split[1]), Int32.Parse(split[2]));
                    TransportData[name] = temp;
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error while loading Transport Data : \n" + ex.Message, "Error");
                this.Close();
            }
            catch(FormatException fex)
            {
                MessageBox.Show("Error formatting Transport Data for '" + name  + "' : \n" + fex.Message, "Error");
            }
             
        }

        private void cboxCommerce_CheckedChanged(object sender, EventArgs e)
        {
            //Increment if checked - Decrement if not Checked
            if (cboxCommerce.Checked) 
            { 
                //The alpaca bonus cannot stack with the commerce bonus.
                cboxAlpaca.Checked = false;
                selectedTransportSlots += 1;
                selectedTransportWeight += 100;
            }
            else
            {
                selectedTransportSlots -= 1;
                selectedTransportWeight -= 100;
            }


            lblTransportSlots.Text = "Slots : " + selectedTransportSlots;
            lblTransportWeight.Text = "Weight Capacity : " + selectedTransportWeight;
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

        private void cboxAlpaca_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxAlpaca.Checked)
            {
                cboxCommerce.Checked = false;
                selectedTransportSlots += 2;
                selectedTransportWeight += 200;

            }
            else
            {
                selectedTransportSlots -= 2;
                selectedTransportWeight -= 200;
            }
            lblTransportSlots.Text = "Slots : " + selectedTransportSlots;
            lblTransportWeight.Text = "Weight Capacity : " + selectedTransportWeight;
        }

        public void rbtnTransport_CheckedChanged(object sender, EventArgs e)
        {
            //The RadioButton Text should be exactly the same as the indexes used in the Dictionary. An alternative would be using the number found at the end of each radiobutton name
            RadioButton selectedRBTN = flpTransport.Controls.OfType<RadioButton>().FirstOrDefault(rbtn => rbtn.Checked);
            selectedTransportSlots = TransportData[selectedRBTN.Text].slots;
            selectedTransportWeight = TransportData[selectedRBTN.Text].weight;
           
            //If the player has a commerce partner - they get a small boost to weight capacity and slots
            if (cboxCommerce.Checked)
            {
                selectedTransportSlots += 1;
                selectedTransportWeight += 100;
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
            lblTransportSlots.Text = "Slots : " + selectedTransportSlots;
            lblTransportWeight.Text = "Weight Capacity : " + selectedTransportWeight;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            EndResults = new Dictionary<string, int>();
            lboxResults.Items.Clear();
            //For now - we will assume the player is transporting one good at a time. Later, I will add functioanlity for mixing and matching if necessary
            int numGoods = 0;
            //Calculate the total number of goods
            //First - assume we can fill the toal number of slots
            int ongoingWeight = selectedGoodWeight * selectedGoodSlots * selectedTransportSlots;
            //Now check if we're over the weight limit - if yes then reduce the number of goods
            if(ongoingWeight > selectedTransportWeight)
            {
                numGoods = selectedTransportWeight / selectedGoodWeight;
            }
            else
            {
                numGoods = selectedGoodSlots * selectedTransportSlots;
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
            foreach(KeyValuePair<String, int> townPrice in EndResults.OrderByDescending(key => key.Value))
            {
                lboxResults.Items.Add(townPrice.Key + " " + townPrice.Value);
            }
        }
    }
}
