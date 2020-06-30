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
    public partial class frmCommerce : Form
    {
        //Rememberes the actively selected index.
        //Adjust this value to change the default selected value. If I make a configure file, I could add an option to change the default
        private int clboxprevSelected = 0;
        public frmCommerce()
        {
            InitializeComponent();
        }

        private void frmCommerce_Load(object sender, EventArgs e)
        {
            //Check off the default value in the list when loading
            clboxGoods.SetItemChecked(this.clboxprevSelected, true);
            
        }

        private void clboxGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblTest.Text = clboxGoods.SelectedIndex.ToString();
            lblTest.Text = clboxGoods.SelectedItem.ToString();
            //One item must always be selected. Re-check the box if it was the one selected.
            //Programmer Notes - if you click fast enough - the user can bypass this protection
            //Current Idea is auto-reselect using clboxprevSelect when the user computes
            if (clboxGoods.SelectedIndex == this.clboxprevSelected)
            {
                clboxGoods.SetItemChecked(this.clboxprevSelected, true);
            }
            else //Otherwise the user selected another checkbox - uncheck the previous
            {
                clboxGoods.SetItemChecked(clboxprevSelected, false);
                //Now remember what the new index is
                this.clboxprevSelected = clboxGoods.SelectedIndex;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
