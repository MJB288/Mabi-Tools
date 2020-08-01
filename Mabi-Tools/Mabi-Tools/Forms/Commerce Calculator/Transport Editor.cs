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
    public partial class frmTransport : Form
    {
        private Dictionary<String, Transport> TransportData;
        private frmCommerce Commerce;
        private int ClboxPrevSelectedT = 0;
        public frmTransport(Dictionary<String, Transport> transportData, frmCommerce commerce)
        {
            InitializeComponent();
            TransportData = new Dictionary<String, Transport>(transportData);
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
                MessageBox.Show("Formatting Error while adding transport(did you insert a letter instead of a number for weight or slots ?) : \n" + fex.Message, "Format Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(clboxTransport.Items.Count == 1)
            {
                MessageBox.Show("Transport Count is exactly at 1! Create another Transport first!");
            }
            TransportData.Remove(clboxTransport.SelectedItem.ToString());
            UIHelper.deleteItemFromList(clboxTransport);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Dictionary<String, Transport> newData = new Dictionary<string, Transport>();
            //This will be very similar to the Commerce City Editor save method - only this time we don't need to check for goods being equal to 0
            for (int i = 0; i < clboxTransport.Items.Count; i++)
            {
                //Check if item is null or has a good count of 0
                if (TransportData[clboxTransport.Items[i].ToString()] == null)
                {
                    //Set it to null (nothing is changed if already null) so that save function doesn't write it
                    TransportData[clboxTransport.Items[i].ToString()] = null;
                    continue;
                }
                //Since the only order to dictionary keys are the order they are inserted and can't be rearranged - we have to construct a new dictionary with the user intended order
                //for the order change to show up in frmCommerce
                newData[clboxTransport.Items[i].ToString()] = TransportData[clboxTransport.Items[i].ToString()];
            }
            Commerce.TransportData = newData;
            CommerceDataHandler.saveTransportDataCSVOrdered("Resources/Transport.csv", TransportData, clboxTransport);
            this.Close();
        }
    }
}
