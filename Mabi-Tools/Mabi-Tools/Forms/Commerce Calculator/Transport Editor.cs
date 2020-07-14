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
    public partial class frmTransport : Form
    {
        private Dictionary<String, Transport> TransportData;
        private frmCommerce Commerce;
        private int ClboxPrevSelectedT = 0;
        public frmTransport(Dictionary<String, Transport> transportData, frmCommerce commerce)
        {
            InitializeComponent();
            TransportData = transportData;
            Commerce = commerce;
        }

        private void frmTransport_Load(object sender, EventArgs e)
        {
            //First populate the transport List
            /*clboxTransport.Items.Clear();
            clboxTransport.Items.AddRange(TransportData.Keys.ToArray());*/
            UIHelper.populateCheckListBox(clboxTransport, TransportData.Keys.ToArray());
            clboxTransport.SelectedIndex = ClboxPrevSelectedT;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            UIHelper.moveSelectedItemUpChecklist(clboxTransport);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            UIHelper.moveSelectedItemDownChecklist(clboxTransport);
        }

        private void clboxTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClboxPrevSelectedT = UIHelper.makeListBoxExclusitivity(clboxTransport, ClboxPrevSelectedT);

            if (clboxTransport.SelectedIndex >= 0)
            {
                //Display the transport data to the user in the text boxes
                txtName.Text = TransportData[clboxTransport.SelectedItem.ToString()].name;
                txtWeight.Text = TransportData[clboxTransport.SelectedItem.ToString()].weight.ToString();
                txtSlots.Text = TransportData[clboxTransport.SelectedItem.ToString()].slots.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //First check for a unique string in the list
            if(!UIHelper.checkForUniqueItem(txtName.Text, clboxTransport))
            {
                MessageBox.Show("Transport '" + txtName.Text + "' already exists!", "Unique Error");
                return;
            }

            //Now to add a transport to the list
            try
            {
                TransportData[txtName.Text] = new Transport(txtName.Text, Int32.Parse(txtSlots.Text), Int32.Parse(txtWeight.Text));
                //Only add after we have confirmed that the transport object could be created
                clboxTransport.Items.Add(txtName.Text);
            }
            catch(FormatException fex)
            {
                MessageBox.Show("Formatting Error while adding transport (did you insert a letter instead of a number for weight or slots?) : \n" + fex.Message, "Format Error");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!UIHelper.checkForUniqueItem(txtName.Text, clboxTransport))
            {
                MessageBox.Show("Transport '" + txtName.Text + "' already exists!", "Unique Error");
                return;
            }

            try
            {
                //Override the current good with the new one
                TransportData[txtName.Text] = new Transport(txtName.Text, Int32.Parse(txtSlots.Text), Int32.Parse(txtWeight.Text));
                TransportData[clboxTransport.SelectedItem.ToString()] = null;
                clboxTransport.Items.Insert(ClboxPrevSelectedT + 1, txtName.Text);
                clboxTransport.SetItemChecked(ClboxPrevSelectedT + 1, true);

                clboxTransport.Items.RemoveAt(ClboxPrevSelectedT);
                clboxTransport.SelectedIndex = ClboxPrevSelectedT + 1;

            }
            catch (FormatException fex)
            {
                //If the transport add method throws a format exception - don't bother adding it
                MessageBox.Show("Formatting Error while adding transport(did you insert a letter instead of a number for weight or slots ?) : \n" + fex.Message", "Format Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
