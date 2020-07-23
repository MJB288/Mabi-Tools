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
            UIHelper.generateRadioButtons(flpTransport, TransportNames, rbtnTransport_CheckedChanged);
            UIHelper.populateCheckListBox(clboxSource, CityNames.ToArray());

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
            
        }
    }
}
