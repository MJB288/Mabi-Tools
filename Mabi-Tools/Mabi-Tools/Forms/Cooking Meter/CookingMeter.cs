using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabi_Tools.Forms.Cooking_Meter
{
    public partial class frmCooking : Form
    {
        public frmCooking()
        {
            InitializeComponent();
        }

        private void frmCooking_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
