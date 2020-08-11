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
    public partial class frmTimeTracker : Form
    {
        //TODO - have a setting that allows user to change default time for this - or keep last saved value
        //public static TimeSpan BelvastBoatTime = new TimeSpan(0, 2, 15);
        private readonly TimeSpan MINTIME = new TimeSpan(0, 2, 15);
        private readonly TimeSpan MAXTIME = new TimeSpan(0, 8, 30);
        private readonly TimeSpan MIDTIME = new TimeSpan(0, 5, 22);
        private List<String> TransportNames, CityNames;
        private frmCommerce commerceCaller;
        private Dictionary<String, Dictionary<String, List<TimeSpan>>> TimeData;
        private Dictionary<String, int> LViewGroupIndex;
        private int ClboxPrevSelectedS = 0, ClboxPrevSelectedD = 0;
        private String SelectedTransport = "";

        public frmTimeTracker(List<String> transportNames, Dictionary<String, Dictionary<String, List<TimeSpan>>> timeData, frmCommerce commerce)
        {
            InitializeComponent();
            TransportNames = new List<String>(transportNames);
            commerceCaller = commerce;
            //TimeData = new Dictionary<String, Dictionary<String, List<TimeSpan>>>(timeData);
            TimeData = duplicateTimeDictionary(timeData);
            CityNames = commerce.CityData.Keys.ToList();
        }

        private void frmTimeTracker_Load(object sender, EventArgs e)
        {
            populateLists();
            clboxSource.SelectedIndex = ClboxPrevSelectedS;
            //Populate the custom box with what the startup value was
            SingletonGraphFactory graphFactory = SingletonGraphFactory.getFactory();
            
            txtCustomTime.Text = graphFactory.BelvastBoatTime.ToString();
            selectRadioButtonStartup();
        }

        //A method for populating the lists at startup
        private void populateLists()
        {
            UIHelper.populateCheckListBox(clboxSource, CityNames.ToArray());
            UIHelper.generateRadioButtons(flpTransport, TransportNames, rbtnTransport_CheckedChanged);
            flpTransport.Controls.OfType<RadioButton>().First().Checked = true;
        }

        private void selectRadioButtonStartup()
        {
            SingletonGraphFactory graphFactory = SingletonGraphFactory.getFactory();
            if (graphFactory.BelvastBoatTime == MINTIME)
            {
                rbtnMin.Checked = true;
            }   
            else if (graphFactory.BelvastBoatTime == MAXTIME)
            {
                rbtnMax.Checked = true;
            }
            else if (graphFactory.BelvastBoatTime == MIDTIME)
            {
                rbtnMiddle.Checked = true;
            }
            else
            {
                rbtnCustom.Checked = true;
            }
        }

        private Dictionary<String, Dictionary<String, List<TimeSpan>>> duplicateTimeDictionary(Dictionary<String, Dictionary<String, List<TimeSpan>>> duplicateMe)
        {
            Dictionary<String, Dictionary<String, List<TimeSpan>>> returnDict = new Dictionary<String, Dictionary<String, List<TimeSpan>>>(duplicateMe);
            //Now we need to iterate througgh each level of the dictionary to retun a new one
            foreach(String key in duplicateMe.Keys)
            {
                returnDict[key] = new Dictionary<string, List<TimeSpan>>(duplicateMe[key]);
                foreach(String key2ndLevel in duplicateMe[key].Keys)
                {
                    returnDict[key][key2ndLevel] = new List<TimeSpan>(duplicateMe[key][key2ndLevel]);
                }
            }

            return returnDict;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close without making changes
            this.Close();           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            commerceCaller.TimeData = TimeData;
            CommerceDataHandler.saveTimeData("Resources/Time.csv", TimeData);
            updateBelvastTime();
            this.Close();
        }

        private void updateBelvastTime()
        {
            SingletonGraphFactory graphFactory = SingletonGraphFactory.getFactory();
            RadioButton selectedRBTN = flpBoat.Controls.OfType<RadioButton>().FirstOrDefault(rbtn => rbtn.Checked);
            switch (selectedRBTN.Name)
            {
                case "rbtnMin":
                    graphFactory.BelvastBoatTime = MINTIME;
                    break;
                case "rbtnMax":
                    graphFactory.BelvastBoatTime = MAXTIME;
                    break;
                case "rbtnMiddle":
                    graphFactory.BelvastBoatTime = MIDTIME;
                    break;
                case "rbtnCustom":
                    try
                    {
                        graphFactory.BelvastBoatTime = TimeSpan.Parse(txtCustomTime.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Could not parse time from Custom Time! Needs to be (HH-MM-SS)!\nBoast time will not be updated!");
                    }
                    break;
                //In case it somehow reaches here - do nothing, but notify
                default:
                    MessageBox.Show("Error, currently selected radiobutton for the Belvast - Cobh boat unrecognized!", "Error");
                    break;

            }
        }

        private void clboxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClboxPrevSelectedD = UIHelper.makeListBoxExclusitivity(clboxDestination, ClboxPrevSelectedD);
            
            //Now that a combo of source and destination has been selected - the program now needs to lookup any time data under the transport-source-destination combo
            populateTimeList();
        }


        private void populateTimeList()
        {
            LViewGroupIndex = new Dictionary<string, int>();
            //Clear Items and Groups
            lviewTime.Items.Clear();
            lviewTime.Groups.Clear();
            if (TimeData.ContainsKey(SelectedTransport))
            {
                String partialKey = "", source = clboxSource.SelectedItem.ToString(), destination = clboxDestination.SelectedItem.ToString();
                //Remember the alphabetical rules during the TimeData construction - recreate them here during lookup
                partialKey = determinePartialTimeDataKeyOrder(source, destination);

                //Now the key also contains the path name - thus need to locate all possible keys containing the partial key
                var relevantkeys = TimeData[SelectedTransport].Where(dictKeyPair => dictKeyPair.Key.Contains(partialKey)).Select(dictKeyPair => dictKeyPair.Key);

                foreach (String key in relevantkeys)
                {
                    String pathName = key.Split(CommerceDataHandler.MAIN_TEXT_SEPARATOR)[2];
                    String[] arr = { pathName, "" };
                    
                    ListViewGroup lviewGroup = new ListViewGroup(pathName);
                    //Add this path to the list of groups
                    if (!LViewGroupIndex.ContainsKey(pathName))
                    {
                        lviewTime.Groups.Add(lviewGroup);
                        LViewGroupIndex[pathName] = lviewTime.Groups.IndexOf(lviewGroup);
                    }
                    foreach (TimeSpan ts in TimeData[SelectedTransport][key])
                    {
                        arr[1] = ts.ToString();
                        ListViewItem lviewItem = new ListViewItem(arr);
                        lviewItem.Group = lviewTime.Groups[LViewGroupIndex[pathName]] ;
                        lviewTime.Items.Add(lviewItem);
                    }
                }
                //lblTest.Text = relevantkeys.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Check if either textbox is empty
            if(txtPath.Text == null || txtPath.Text.Equals(""))
            {
                MessageBox.Show("Path name cannot be empty!", "Input Error");
                return;
            }
            if(txtTime.Text == null || txtTime.Text.Equals(""))
            {
                MessageBox.Show("Time value cannot be empty!", "Input Error");
                return;
            }

            if (txtPath.Text.Contains(CommerceDataHandler.MAIN_TEXT_SEPARATOR))
            {
                MessageBox.Show("Path name may not contain the character '" + CommerceDataHandler.MAIN_TEXT_SEPARATOR + "'!", "Input Error");
                return;
            }

            //Now try to parse the timespan from the string
            TimeSpan newTime = new TimeSpan();
            try
            {
                newTime = TimeSpan.Parse(txtTime.Text);
            }
            catch(FormatException fex)
            {
                MessageBox.Show("Time format must be HOUR-MINUTE-SECOND!\n"+fex.Message, "Format Error");
                return;
            }
            catch(OverflowException oex)
            {
                MessageBox.Show("Numerical overflow on the input time :\n" + oex.Message, "Format Error");
            }

            //No user input errors so far - now check for and create levels of the internal dictionary if necessary

            //First check that we have data entries for the currently selected transport
            if (!TimeData.ContainsKey(SelectedTransport))
            {
                TimeData[SelectedTransport] = new Dictionary<string, List<TimeSpan>>();
            }
            //Now check that the second level exists

            
            String key = determinePartialTimeDataKeyOrder(clboxSource.SelectedItem.ToString(), clboxDestination.SelectedItem.ToString()) + txtPath.Text;
            //MessageBox.Show(key, "A key!");

            //Determine if the list exists for a given key
            if (!TimeData[SelectedTransport].ContainsKey(key))
            {
                TimeData[SelectedTransport][key] = new List<TimeSpan>();
            }

            TimeData[SelectedTransport][key].Add(newTime);
            //Now add the item to the UI
            String[] listItemValues = { txtPath.Text, newTime.ToString() };
            ListViewItem lviewItem = new ListViewItem(listItemValues);
            ListViewGroup lviewGroup = new ListViewGroup(txtPath.Text);
            //Check using the dictionary
            if(!LViewGroupIndex.ContainsKey(txtPath.Text))
            {
                lviewTime.Groups.Add(lviewGroup);
                LViewGroupIndex[txtPath.Text] = lviewTime.Groups.IndexOf(lviewGroup);
            }
            //Assign the item to a group at a specified index
            lviewItem.Group = lviewTime.Groups[LViewGroupIndex[txtPath.Text]];
            lviewTime.Items.Add(lviewItem);
           
        }

        private void clboxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClboxPrevSelectedS = UIHelper.makeListBoxExclusitivity(clboxSource, ClboxPrevSelectedS);
            //Since we are not adding nor deleting cities here - checks can be less strict
            //We need to now project the same list onto the destination checklistbox, but without the source
            List<String> cityNames2 = new List<String>(CityNames);
            cityNames2.Remove(clboxSource.SelectedItem.ToString());
            UIHelper.populateCheckListBox(clboxDestination, cityNames2.ToArray());
            clboxDestination.SelectedIndex = ClboxPrevSelectedD;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //First check that a time has been selected
            if(lviewTime.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Must have an item selected to be able to delete", "Delete Error");
                return;
            }
           
            //The listview was built with multi select in mind - therefore I will take advantage of that to allow the user to delete multiple items
            //To do this I will delete the bottom most index and work upwards
            for(int i = lviewTime.SelectedIndices.Count - 1; i >= 0; i--) 
            {
                //Get the current index
                int index = lviewTime.SelectedIndices[i];
                //Get the Listview Item in Question
                ListViewItem itemToRemove = lviewTime.Items[index];
                //We need to get a relative index within the group to get the index of item in the TimeData
                int relativeIndex = itemToRemove.Group.Items.IndexOf(itemToRemove);
                String key = determinePartialTimeDataKeyOrder(clboxSource.SelectedItem.ToString(), clboxDestination.SelectedItem.ToString()) + itemToRemove.Group.Header;
                TimeData[SelectedTransport][key].RemoveAt(relativeIndex);
                //Now determine how many levels we must remove in the dictionary to trim memory usage
                if(TimeData[SelectedTransport][key].Count <= 0)
                {
                    TimeData[SelectedTransport].Remove(key);
                }
                if(TimeData[SelectedTransport].Count <= 0)
                {
                    TimeData.Remove(SelectedTransport);
                }
                //Finally remove from the UI
                lviewTime.Items.RemoveAt(index);
            };
            
        }

        private void rbtnTransport_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRBTN = flpTransport.Controls.OfType<RadioButton>().FirstOrDefault(rbtn => rbtn.Checked);
            SelectedTransport = selectedRBTN.Text;
            
            //This is to prevent any errors when it first starts up
            if(clboxSource.SelectedItem != null && clboxDestination.SelectedItem != null)
            {
                populateTimeList();
            }
        }

        //Determines the order of the keys used in the dictionary
        private string determinePartialTimeDataKeyOrder(String source, String destination)
        {
            String partialKey = "";
            if (source.CompareTo(destination) < 0)
            {
                partialKey = destination + CommerceDataHandler.MAIN_TEXT_SEPARATOR + source + CommerceDataHandler.MAIN_TEXT_SEPARATOR;
            }
            else
            {
                partialKey = source + CommerceDataHandler.MAIN_TEXT_SEPARATOR + destination + CommerceDataHandler.MAIN_TEXT_SEPARATOR;
            }
            return partialKey;
        }
    }
}
