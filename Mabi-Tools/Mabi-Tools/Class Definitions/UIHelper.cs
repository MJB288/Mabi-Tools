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
        public static void populateCheckListBox(CheckedListBox checkbox, String[] dataArray)
        {
            checkbox.Items.Clear();
            //checkbox.Items.AddRange(data.Keys.ToArray());
            checkbox.Items.AddRange(dataArray);
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

        //Two functions for moving items up and down a checklist
        public static int moveSelectedItemUpChecklist(CheckedListBox clbox)
        {
            if (clbox.SelectedIndex < 0)
            {
                MessageBox.Show("No City Selected!", "Warning!");
                return 0;
            }
            if (clbox.SelectedIndex == 0)
            {
                MessageBox.Show("Cannot move this up the list any further!", "Warning");
                return 0;
            }
            clbox.Items.Insert(clbox.SelectedIndex + 1, clbox.Items[clbox.SelectedIndex - 1]);
            clbox.Items.RemoveAt(clbox.SelectedIndex - 1);
            return clbox.SelectedIndex;
        }

        public static int moveSelectedItemDownChecklist(CheckedListBox clbox)
        {
            if (clbox.SelectedIndex < 0)
            {
                MessageBox.Show("No City Selected!", "Warning!");
                return 0;
            }
            if (clbox.SelectedIndex == clbox.Items.Count - 1)
            {
                MessageBox.Show("Cannot move this down the list any further!", "Warning");
                return clbox.SelectedIndex;
            }
            clbox.Items.Insert(clbox.SelectedIndex, clbox.Items[clbox.SelectedIndex + 1]);
            clbox.Items.RemoveAt(clbox.SelectedIndex + 1);
            return clbox.SelectedIndex;
        }

        public static Boolean checkForUniqueItem(String newItem, CheckedListBox clbox)
        {
            //First - check that the new name doesn't exist in the current momemnt. We can afford to loop through all of them since the number of cities will stay a really small number
            foreach (var item in clbox.Items)
            {
                if (item.ToString().Equals(newItem))
                {
                    return false;
                }
            }
            return true;
        }

        public static void deleteItemFromList(CheckedListBox clbox)
        {
            Boolean indexAt0 = clbox.SelectedIndex == 0;

            //Select the previous item - or the next item if 0
            if (indexAt0)
            {
                clbox.SelectedIndex = clbox.SelectedIndex + 1;
            }
            else
            {
                clbox.SelectedIndex = clbox.SelectedIndex - 1;
            }

            clbox.SetItemChecked(clbox.SelectedIndex, true);
            if (indexAt0)
            {
                clbox.Items.RemoveAt(clbox.SelectedIndex - 1);
            }
            else
            {
                clbox.Items.RemoveAt(clbox.SelectedIndex + 1);
            }
        }

        public static void displayResultsNetProfit(ListView lview, Dictionary<String,int> results)
        {
            lview.Items.Clear();
            foreach (KeyValuePair<String, int> townPrice in results.OrderByDescending(key => key.Value))
            {
                String[] arr = { townPrice.Key, "" + townPrice.Value };
                ListViewItem newItem = new ListViewItem(arr);
                lview.Items.Add(newItem);
            }
        }

        public static void displayResultsTime(ListView lview, Dictionary<String, int> results, Dictionary<String, TimeSpan> shortestTime)
        {
            lview.Items.Clear();
            foreach (KeyValuePair<String, TimeSpan> townTime in shortestTime.OrderByDescending(key => key.Value))
            {
                //Due to the nature of Dijkstra's algorithm - the source will also be in the dictionary, while in the net profit results it is not there
                //Therefore - we need to add a check to skip (plus if for whatever reason there isn't a net profit - this doesn't work anyway)
                if (!results.ContainsKey(townTime.Key))
                {
                    continue;
                }
                String[] arr = new String[2];
                arr[0] = townTime.Key;
                //Also check for a divide by zero as well
                if (townTime.Value.Ticks == 0)
                {
                    arr[1] = "0";
                }
                else 
                {
                    //arr[1] =(results[townTime.Key] / townTime.Value.Ticks).ToString();
                    arr[1] = townTime.Value.ToString();
                }
                ListViewItem newItem = new ListViewItem(arr);
                lview.Items.Add(newItem);
            }
        }
    }
}
