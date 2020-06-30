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
            frmCommerce nextForm = new frmCommerce();
            nextForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Entire Application if Clicking Exit. 
            System.Windows.Forms.Application.Exit();
        }
    }
}
