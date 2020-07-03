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
        private Label[] CityLabels;
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
            this.loadCommerceData("Cities.txt");
            this.populateCityCheckListBox(clboxCities, CityData);

            Label[] testLabels = { lblTown0, lblTown1, lblTown2, lblTown3, lblTown4, lblTown5, lblTown6, lblTown7, lblTown8, lblTown9 };
            CityLabels = testLabels;
            testLabels = null;

            //Similarly, with the transport Mounts
            this.loadTransportData("Transport.txt");
            this.generateRadioButtons(flpTransport, TransportData);

            //Adjust Visibility based on the amount of towns detected.
            this.adjustTextBoxesVisibilityCommerce();
            this.adjustLabelsCities(0, 0);

            //Check off the default value in the lists when loading
            
            clboxCities.SetItemChecked(this.clboxprevSelectedT, true);
            clboxCities.SelectedItem = clboxCities.Items[clboxprevSelectedG];
            populateGoodCheckListBox(clboxGoods, CityData[CityData.Keys.ToList()[this.clboxprevSelectedT]]);
            
            //Check off the first one for now.
            flpTransport.Controls.OfType<RadioButton>().First().Checked = true;
            
        }

        private void clboxGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            clboxprevSelectedG = makeListBoxExclusitivity(clboxGoods, clboxprevSelectedG);
            lblTest.Text = clboxGoods.SelectedItem.ToString();
            //Now pull up the Weight And Slot statistics
            selectedGoodSlots = CityData[clboxCities.SelectedItem.ToString()].getGoods()[clboxprevSelectedG].getSlotCapacity();
            selectedGoodWeight = CityData[clboxCities.SelectedItem.ToString()].getGoods()[clboxprevSelectedG].getWeight();
            lblItemWeight.Text = "Weight : " + selectedGoodWeight;
            lblItemSlots.Text = "Slot Capacity : " + selectedGoodSlots;
        }

        private void clboxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Adjust as necessary 
            adjustLabelsCities(clboxprevSelectedT, clboxCities.SelectedIndex);
            clboxprevSelectedT = makeListBoxExclusitivity(clboxCities, clboxprevSelectedT);
            lblTest.Text = clboxCities.SelectedItem.ToString();
            //Now adjust the Goods Box based off of the currently selected city
            populateGoodCheckListBox(clboxGoods, CityData[clboxCities.SelectedItem.ToString()]);

        }

        //Form Adjustment Methods
        //----------------------------------------------------------------------------------------------------------
        //Let's turn this into a method for reusability
        private static int makeListBoxExclusitivity(CheckedListBox clistbox, int prevSelected)
        {
            //One item must always be selected. Re-check the box if it was the one selected.
            //Programmer Notes - if you click fast enough - the user can bypass this protection. The threshold of clicks per second is real low so easy to do accidentally.
            //Current Idea is auto-reselect using clboxprevSelect when the user hits "Compute"
            if (clistbox.SelectedIndex == prevSelected)
            {
                clistbox.SetItemChecked(prevSelected, true);
                return prevSelected;
            }
            else //Otherwise the user selected another checkbox - uncheck the previous
            {
                clistbox.SetItemChecked(prevSelected, false);
                //Now remember what the new index is
                //this.clboxprevSelected = clboxGoods.SelectedIndex;
                return clistbox.SelectedIndex;
            }
        }

        private void populateCityCheckListBox(CheckedListBox checkbox, Dictionary<String, City> data)
        {
            checkbox.Items.Clear();
            checkbox.Items.AddRange(data.Keys.ToArray());
        }
        //There are some subtle changes in this method which is why I'm not reusing the one above this
        private void populateGoodCheckListBox(CheckedListBox checkbox, City city)
        {
            checkbox.Items.Clear();
            foreach(Good good in city.getGoods())
            {
                checkbox.Items.Add(good.getName());
            }
            //Since we just cleared all items, we must recheck the last one the user selected
            checkbox.SetItemChecked(clboxprevSelectedG, true);
            checkbox.SelectedItem = checkbox.Items[clboxprevSelectedG];
        }

       

        private void generateRadioButtons(FlowLayoutPanel flow, Dictionary<String, Transport> data)
        {
            int i = 1, rbtnHeight = 0;
            //Dynamically create radio buttons for each type of transport
            foreach(Transport t in data.Values)
            {
                //RadioButton temp = new RadioButton { Text = t.getName() + "\nSlots - " + t.getSlots() + "     Weight Capacity - " + t.getWeight(), Name = "rbtnTransport" + i };
                RadioButton temp = new RadioButton { Text = t.getName(), Name = "rbtnTransport" + i };
                temp.AutoSize = false;
                temp.Width = flow.Width-5;
                //temp.Height = (int) (temp.Height  * 1.5);
                temp.CheckedChanged += (this.rbtnTransport_CheckedChanged);
                flow.Controls.Add(temp);
                i++;
                rbtnHeight = temp.Height;
            }
            //Trim the Height of the Flow Panel to remove whitespace
            flow.Height = (int) (flow.Controls.OfType<RadioButton>().Count() * rbtnHeight * 1.3);
        }

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
        private void loadCommerceData(String citiesFile)
        {
            CityData = new Dictionary<string, City>();
            try
            {
                //CityNames = File.ReadAllLines(citiesFile).ToList();
                String [] rawData = File.ReadAllLines(citiesFile);
                foreach(String s in rawData)
                {
                    //Separate the individual good strings and process
                    String [] goodStrings = s.Split(MAIN_TEXT_SEPARATOR);
                    Good[] cityGoods = convertStringArrayToGoods(goodStrings);
                    //Now add the data to the Dictionary
                    CityData[goodStrings[0]] = new City(goodStrings[0], cityGoods);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error while loading City data : \n" + ex.Message, "Error");
                this.Close();
            }
        }

        private Good[] convertStringArrayToGoods(String[] input)
        {
            //Currently, I am operating under the assumption the first item in the string array is the city name - therefore I will skip over it
            Good[] returnArray = new Good[input.Length - 1]; 
            for(int i = 1; i < input.Length; i++)
            {
                //Split the strings further
                String[] goodSplit = input[i].Split(SECONDARY_TEXT_SEPARATOR);
                try
                {
                    //Add the new good to the array
                    returnArray[i - 1] = new Good(goodSplit[0], Int32.Parse(goodSplit[1]), Int32.Parse(goodSplit[2]));
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("Error Processing Data For City '" + input[0] + " and Good '" + goodSplit[0] + "' : \n" + ex.Message, "Format Error");
                }
            }
            return returnArray;
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

        private void rbtnTransport_CheckedChanged(object sender, EventArgs e)
        {
            //The RadioButton Text should be exactly the same as the indexes used in the Dictionary. An alternative would be using the number found at the end of each radiobutton name
            RadioButton selectedRBTN = flpTransport.Controls.OfType<RadioButton>().FirstOrDefault(rbtn => rbtn.Checked);
            selectedTransportSlots = TransportData[selectedRBTN.Text].getSlots();
            selectedTransportWeight = TransportData[selectedRBTN.Text].getWeight();
           
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
           
        }
    }
}
