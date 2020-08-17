using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabi_Tools
{
    public partial class MainLauncher : Form
    {
        public MainLauncher()
        {
            InitializeComponent();
        }

        private void btnCommerce_Click(object sender, EventArgs e)
        {
            Forms.Commerce_Calculator.frmCommerce nextForm = new Forms.Commerce_Calculator.frmCommerce();
            //We want the user to display as many windows as they choose, therefore using Show instead of ShowDialog
            nextForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Entire Application if Clicking Exit. 
            System.Windows.Forms.Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Forms.frmSettings settingsForm = new Forms.frmSettings();
            settingsForm.ShowDialog();
        }
    }
}
