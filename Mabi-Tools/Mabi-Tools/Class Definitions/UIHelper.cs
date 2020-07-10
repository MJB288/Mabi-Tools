using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Mabi_Tools
{
    public static class UIHelper
    {
        public static int makeListBoxExclusitivity(CheckedListBox clistbox, int prevSelected)
        {
            //One item must always be selected. Re-check the box if it was the one selected.
            //Programmer Notes - if you click fast enough - the user can bypass this protection. The threshold of clicks per second is real low so easy to do accidentally.
            //Current Idea is auto-reselect using clboxprevSelect when the user hits "Compute"
            
            if(prevSelected == -1)
            {
                if(clistbox.Items.Count != 0)
                {
                    prevSelected = 0;
                }
            }
            if (clistbox.SelectedIndex == prevSelected)
            {
                clistbox.SetItemChecked(prevSelected, true);
                return prevSelected;
            }
            else //Otherwise the user selected another checkbox - uncheck the previous
            {
                clistbox.SetItemChecked(prevSelected, false);
                //Now remember what the new index is
                //this.clboxprevSelected = clboxGoods.SelectedIndex;
                return clistbox.SelectedIndex;
            }
        }
        public static void populateCityCheckListBox(CheckedListBox checkbox, Dictionary<String, City> data)
        {
            checkbox.Items.Clear();
            checkbox.Items.AddRange(data.Keys.ToArray());
        }
        public static void populateGoodCheckListBox(CheckedListBox checkbox, City city, int prevSelected)
        {
            checkbox.Items.Clear();
            foreach (Good good in city.goods)
            {
                checkbox.Items.Add(good.name);
            }
            //Since we can create new cities that do not have any goods - we need to add a check - this is for the commerce city editor
            if (checkbox.Items.Count == 0)
            {
                return;
            }
            //Since we just cleared all items, we must recheck the last one the user selected
            checkbox.SetItemChecked(prevSelected, true);
            checkbox.SelectedItem = checkbox.Items[prevSelected];
        }

        public static void generateRadioButtons(FlowLayoutPanel flow, Dictionary<String, Transport> data, frmCommerce commerce)
        {
            int i = 1, rbtnHeight = 0;
            //Dynamically create radio buttons for each type of transport
            foreach (Transport t in data.Values)
            {
                //RadioButton temp = new RadioButton { Text = t.getName() + "\nSlots - " + t.getSlots() + "     Weight Capacity - " + t.getWeight(), Name = "rbtnTransport" + i };
                RadioButton temp = new RadioButton { Text = t.name, Name = "rbtnTransport" + i };
                temp.AutoSize = false;
                temp.Width = flow.Width - 5;
                //temp.Height = (int) (temp.Height  * 1.5);
                temp.CheckedChanged += (commerce.rbtnTransport_CheckedChanged);
                flow.Controls.Add(temp);
                i++;
                rbtnHeight = temp.Height;
            }
            //Trim the Height of the Flow Panel to remove whitespace
            flow.Height = (int)(flow.Controls.OfType<RadioButton>().Count() * rbtnHeight * 1.3);
        }

        public static void labelTextBoxInvisible(Label label, TextBox txtbox)
        {
            label.Visible = false;
            txtbox.Visible = false;
        }

        //A small function to delay without locking the UI with Thread.Sleep()
        public static void Delay(int milliseconds)
        {
            Timer delayTimer = new Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            delayTimer.Interval = milliseconds;
            delayTimer.Enabled = true;
            delayTimer.Start();

            delayTimer.Tick += (s, e) =>
            {
                delayTimer.Enabled = false;
                delayTimer.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (delayTimer.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
