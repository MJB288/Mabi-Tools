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
        //Rememberes the actively selected index.
        //Adjust this value to change the default selected value. If I make a configure file, I could add an option to change the default
        private int clboxprevSelectedG = 0;
        private int clboxprevSelectedT = 0;
        private List<String> CityNames, TransportNames;
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
            this.populateCheckListBox(clboxCities, CityNames);

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
            clboxGoods.SetItemChecked(this.clboxprevSelectedG, true);
            clboxCities.SetItemChecked(this.clboxprevSelectedT, true);
            //Check off the first one for now.
            flpTransport.Controls.OfType<RadioButton>().First().Checked = true;
            
        }

        private void clboxGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            clboxprevSelectedG = makeListBoxExclusitivity(clboxGoods, clboxprevSelectedG);
            lblTest.Text = clboxGoods.SelectedItem.ToString();
        }

        private void clboxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Adjust as necessary 
            adjustLabelsCities(clboxprevSelectedT, clboxCities.SelectedIndex);
            clboxprevSelectedT = makeListBoxExclusitivity(clboxCities, clboxprevSelectedT);
            lblTest.Text = clboxCities.SelectedItem.ToString();
            

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

        private void populateCheckListBox(CheckedListBox checkbox, List<String> data)
        {
            //Clear all the items since they are placeholders
            checkbox.Items.Clear();
            foreach(String s in data)
            {
                checkbox.Items.Add(s);
            }
        }

        private void generateRadioButtons(FlowLayoutPanel flow, Dictionary<String, Transport> data)
        {
            int i = 1;
            //Dynamically create radio buttons for each type of transport
            foreach(Transport t in data.Values)
            {
                RadioButton temp = new RadioButton { Text = t.getName() + "\nSlots - " + t.getSlots() + "     Weight Capacity - " + t.getWeight(), Name = "rbtnTransport" + i };
                temp.AutoSize = false;
                temp.Width = flow.Width-5;
                temp.Height = (int) (temp.Height  * 1.5);
                flow.Controls.Add(temp);
            }
        }

        //Since this will be implementation specific - just use the form variables
        private void adjustTextBoxesVisibilityCommerce()
        {
            //Since I left room for a couple Extra cities - adjust visibility based on the amount of detected cities
            //Needs to be adjusted for more flexibility and more reusability friendly
            if(10 - CityNames.Count > 0)
            {
                labelTextBoxInvisible(lblTown9, txtTown9);
                if (10 - CityNames.Count > 1)
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
            for(int i = oldindex; i < CityNames.Count; i++)
            {
                //
                if (i == CityNames.Count - 1)
                {
                    CityLabels[i].Text = "Smuggler";
                }
                else if (i >= newIndex)
                {
                    CityLabels[i].Text = CityNames[i + 1];
                }
                else
                {
                    CityLabels[i].Text = CityNames[i];
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
                TransportNames = new List<string>();
                //TransportNames = File.ReadAllLines(transportFile).ToList();
                string[] rawdata = File.ReadAllLines(transportFile);
                foreach (String s in rawdata)
                {
                    //This could be condensed into one line of code, saving a bit of memory, but for Readability purposes I decided against that
                    int graveI = s.IndexOf("`");
                    int semiI = s.IndexOf(";");
                    name = s.Substring(0, graveI);
                    String slots = s.Substring(graveI + 1, semiI - graveI - 1);
                    String weight = s.Substring(semiI + 1, s.Length - semiI - 1);
                    TransportNames.Add(name);
                    Transport temp = new Transport(name, Int32.Parse(slots), Int32.Parse(weight));
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
            //Will be expanded upon later - for now only need cities
            try
            {
                CityNames = File.ReadAllLines(citiesFile).ToList();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error while loading City data : \n" + ex.Message, "Error");
                this.Close();
            }
        }

       

      
        


    }
}
