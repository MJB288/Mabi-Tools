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
        private List<String> TransportNames, CityNames;
        private frmCommerce commerceCaller;
        private Dictionary<String, Dictionary<String, List<TimeSpan>>> TimeData;
        private int ClboxPrevSelectedS = 0, ClboxPrevSelectedD = 0;
        private String SelectedTransport = "";

        public frmTimeTracker(List<String> transportNames, Dictionary<String, Dictionary<String, List<TimeSpan>>> timeData, frmCommerce commerce)
        {
            InitializeComponent();
            TransportNames = transportNames;
            commerceCaller = commerce;
            TimeData = timeData;
            CityNames = commerce.CityData.Keys.ToList();
        }

        private void frmTimeTracker_Load(object sender, EventArgs e)
        {
            populateLists();
            clboxSource.SelectedIndex = ClboxPrevSelectedS;
        }

        //A method for populating the lists at startup
        private void populateLists()
        {
            UIHelper.populateCheckListBox(clboxSource, CityNames.ToArray());
            UIHelper.generateRadioButtons(flpTransport, TransportNames, rbtnTransport_CheckedChanged);
            flpTransport.Controls.OfType<RadioButton>().First().Checked = true;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close without making changes
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            commerceCaller.TimeData = TimeData;
        }

        private void clboxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClboxPrevSelectedD = UIHelper.makeListBoxExclusitivity(clboxDestination, ClboxPrevSelectedD);
            
            //Now that a combo of source and destination has been selected - the program now needs to lookup any time data under the transport-source-destination combo
            populateTimeList();
        }


        private void populateTimeList()
        {
            lviewTime.Items.Clear();
            if (TimeData.ContainsKey(SelectedTransport))
            {
                String partialKey = "", source = clboxSource.SelectedItem.ToString(), destination = clboxDestination.SelectedItem.ToString();
                //Remember the alphabetical rules during the TimeData construction - recreate them here during lookup
                if (source.CompareTo(destination) < 0)
                {
                    partialKey = destination + CommerceDataHandler.MAIN_TEXT_SEPARATOR + source + CommerceDataHandler.MAIN_TEXT_SEPARATOR;
                }
                else
                {
                    partialKey = source + CommerceDataHandler.MAIN_TEXT_SEPARATOR + destination + CommerceDataHandler.MAIN_TEXT_SEPARATOR;
                }

                //Now the key also contains the path name - thus need to locate all possible keys containing the partial key
                var relevantkeys = TimeData[SelectedTransport].Where(dictKeyPair => dictKeyPair.Key.Contains(partialKey)).Select(dictKeyPair => dictKeyPair.Key);

                foreach (String key in relevantkeys)
                {
                    String[] arr = { key.Split(CommerceDataHandler.MAIN_TEXT_SEPARATOR)[2], "" };
                    foreach (TimeSpan ts in TimeData[SelectedTransport][key])
                    {
                        arr[1] = ts.ToString();
                        ListViewItem lviewItem = new ListViewItem(arr);
                        lviewTime.Items.Add(lviewItem);
                    }
                }
                //lblTest.Text = relevantkeys.ToString();
            }
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
    }
}
