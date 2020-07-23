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

namespace Mabi_Tools.Forms.Commerce_Calculator
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
        private String SelectedTransportName = "";
        public Dictionary<String, City> CityData;
        public Dictionary<String, Transport> TransportData;
        //public Dictionary<String, List<TimeSpan>> TimeData;
        public Dictionary<String, Dictionary<String, List<TimeSpan>>> TimeData;
        public Dictionary<String, TimeSpan> AvgTimeData;
        //Keeping this in global memory for filter purposes
        private Dictionary<String, int> EndResults;
        private Dictionary<String, int> DucatsMin;
        private Dictionary<String, Graph> GraphsbyTransport;
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
            loadDataStartup();
            //Generate the graphs from the time data
            generateGraphs();

            //UIHelper.populateCheckListBox(clboxCities, CityData.Keys.ToArray());

            Label[] testLabels = { lblTown0, lblTown1, lblTown2, lblTown3, lblTown4, lblTown5, lblTown6, lblTown7, lblTown8, lblTown9 };
            TextBox[] textBoxes = { txtTown0, txtTown1, txtTown2, txtTown3, txtTown4, txtTown5, txtTown6, txtTown7, txtTown8, txtTown9 };
            CityLabels = testLabels;
            CityTextboxes = textBoxes;
            testLabels = null;
            textBoxes = null;

            //So this should return an enumerator of labels that contain the name - perhaps use this logic to assign the labels?
            //this.Controls.OfType<Label>().Where(lbl => lbl.Name.Contains("lblTown"));
            refreshDisplayTransport();
            refreshDisplayCities();

            //Adjust Visibility based on the amount of towns detected.
            this.adjustTextBoxesVisibilityCommerce();
            this.adjustLabelsCities(0, 0);

            //Check off the default value in the lists when loading
            
            //clboxCities.SetItemChecked(this.ClboxprevSelectedT, true);
            //clboxCities.SelectedItem = clboxCities.Items[ClboxprevSelectedG];
            //UIHelper.populateGoodCheckListBox(clboxGoods, CityData[CityData.Keys.ToList()[this.ClboxprevSelectedT]], ClboxprevSelectedG);
            
            //Check off the first one for now.
            flpTransport.Controls.OfType<RadioButton>().First().Checked = true;
            String[] arr = { "1", "2" };
            ListViewItem lItem = new ListViewItem(arr);
            lviewResults.Items.Add(lItem);

                  
        }

        private void loadDataStartup()
        {
            //Todo:Have some sort of settings to allow the user to specify which file they use
            try
            {
                CityData = CommerceDataHandler.loadCommerceDataText("Resources/Cities.csv");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error while loading City data : \n" + ex.Message, "Error");
                //We can't proceed without city data - close
                this.Close();
            }

            try
            {
                TransportData = CommerceDataHandler.loadTransportDataText("Resources/Transport.csv");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error while loading Transport Data : \n" + ex.Message, "Error");
                this.Close();
            }

            try
            {
                TimeData = CommerceDataHandler.loadTimeData("Resources/Time.csv");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error while loading Transport Data : \n" + ex.Message, "Error");
                this.Close();
            }
            
        }

        private void generateGraphs()
        {
            SingletonGraphFactory graphFactory = SingletonGraphFactory.getFactory();

            GraphsbyTransport = new Dictionary<String, Graph>();
            foreach (KeyValuePair<String, Dictionary<String, List<TimeSpan>>> transportToTime in TimeData)
            {
                GraphsbyTransport[transportToTime.Key] = graphFactory.constructGraph(CommerceDataHandler.compressTimeData(transportToTime.Value));
            }
        }



        private void clboxGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClboxprevSelectedG = UIHelper.makeListBoxExclusitivity(clboxGoods, ClboxprevSelectedG);
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

        

        private void btnDucats_Click(object sender, EventArgs e)
        {
            //Switch colors
            btnDucats.BackColor = Color.PaleGreen;
            btnNetProfit.BackColor = Color.LightGray;
            UIHelper.displayCommerceResults(lviewResults,DucatsMin);
        }

        private void btnNetProfit_Click(object sender, EventArgs e)
        {
            btnNetProfit.BackColor = Color.PaleGreen;
            btnDucats.BackColor = Color.LightGray;
            //Display the results to the user
            UIHelper.displayCommerceResults(lviewResults, EndResults);
            
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

        private void editTransportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransport transportEditor = new frmTransport(TransportData, this);
            transportEditor.ShowDialog();
            //Now Refresh the display with any new changes
            refreshDisplayTransport();
        }

        private void editCityDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCommerceCityEditor cityEditor = new frmCommerceCityEditor(CityData, this);
            //This time we want the player to make a definitive choice on editing the data before they return to frmCommerce
            cityEditor.ShowDialog();
            //refresh the checklist boxes after the user has made changes if any
            refreshDisplayCities();
        }

        private void rbtnTransport_CheckedChanged(object sender, EventArgs e)
        {
            //The RadioButton Text should be exactly the same as the indexes used in the Dictionary. An alternative would be using the number found at the end of each radiobutton name
            RadioButton selectedRBTN = flpTransport.Controls.OfType<RadioButton>().FirstOrDefault(rbtn => rbtn.Checked);
            SelectedTransportSlots = TransportData[selectedRBTN.Text].slots;
            SelectedTransportWeight = TransportData[selectedRBTN.Text].weight;
            SelectedTransportName = selectedRBTN.Text;
           
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
            //Enforcing starting in net profit mode
            btnNetProfit.BackColor = Color.PaleGreen;
            btnDucats.BackColor = Color.LightGray;

            btnDucats.Enabled = true;
            btnNetProfit.Enabled = true;
            
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
            //Display the end results to the user
            UIHelper.displayCommerceResults(lviewResults, EndResults);

            /*Graph newGraph = Graph.constructGraphCommerce(AvgTimeData);
            Dictionary<String, TimeSpan> endResultsTime = newGraph.startDijkstra(clboxCities.SelectedItem.ToString());*/
            //Check if we have a time graph on the transport - if not - then
            if (!TimeData.ContainsKey(SelectedTransportName))
            {
                btnDucats.Enabled = false;
                return;
            }
            Dictionary<String, TimeSpan> endResultsTime = GraphsbyTransport[SelectedTransportName].startDijkstra(clboxCities.SelectedItem.ToString());
            calculateDucatsPerMin(endResultsTime);
        }

        private void timeTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimeTracker timeTracker = new frmTimeTracker(TransportData.Keys.ToList(), TimeData, this);
            timeTracker.ShowDialog();
        }

        private void calculateDucatsPerMin(Dictionary<String, TimeSpan> shortestTime)
        {
            DucatsMin = new Dictionary<string, int>();
            foreach (KeyValuePair<String, TimeSpan> townTime in shortestTime.OrderByDescending(key => key.Value))
            {
                //Due to the nature of Dijkstra's algorithm - the source will also be in the dictionary, while in the net profit results it is not there
                //Therefore - we need to add a check to skip (plus if for whatever reason there isn't a net profit - this doesn't work anyway)
                if (!EndResults.ContainsKey(townTime.Key))
                {
                    continue;
                }
                TimeSpan maxedValue = new TimeSpan(0, Int32.MaxValue, Int32.MaxValue); ;
                //Also check for a divide by zero and in the case of some shenanigans of the user editing the data - if the timespan is the same maxed out assignment value as assigned in Dijkstra
                if (townTime.Value.Ticks == 0 || townTime.Value == maxedValue)
                {
                    DucatsMin[townTime.Key] = 0;
                }
                else
                {
                    DucatsMin[townTime.Key] = Convert.ToInt32(EndResults[townTime.Key] / townTime.Value.TotalMinutes);
                    //arr[1] = townTime.Value.ToString();
                }
                
            }
        }

        private void refreshDisplayCities()
        {
            UIHelper.populateCheckListBox(clboxCities, CityData.Keys.ToArray());
            clboxCities.SetItemChecked(this.ClboxprevSelectedT, true);
            clboxCities.SelectedItem = clboxCities.Items[ClboxprevSelectedG];
            UIHelper.populateGoodCheckListBox(clboxGoods, CityData[CityData.Keys.ToList()[this.ClboxprevSelectedT]], ClboxprevSelectedG);
            adjustTextBoxesVisibilityCommerce();          
        }
        
        private void refreshDisplayTransport()
        {
            //Since it only contains radio buttons - we can just clear them all
            flpTransport.Controls.Clear();

            List<String> transportList = new List<String>();
            foreach(Transport t in TransportData.Values)
            {
                transportList.Add(t.name);
            }
            //Now regenerate all of the Transport Options
            UIHelper.generateRadioButtons(flpTransport, transportList, this.rbtnTransport_CheckedChanged);

        }


    }
}
