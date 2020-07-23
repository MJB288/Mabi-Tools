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
        private List<String> TransportNames;
        public frmTimeTracker(List<String> transportNames)
        {
            InitializeComponent();
            TransportNames = transportNames;

        }

        private void frmTimeTracker_Load(object sender, EventArgs e)
        {

        }
    }
}
