using Mabi_Tools.Forms.Commerce_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Mabi_Tools.Classes
{
    /// <summary>
    /// A static helper class that contains some reusable methods for altering/changing the UI
    /// </summary>
    public static class UIHelper
    {
        /// <summary>
        /// On a checkListbox - ensure that only one value is check at a time. 
        /// </summary>
        /// <param name="clistbox">The checklist box</param>
        /// <param name="prevSelected">The index previous value on the list that was selected</param>
        /// <returns></returns>
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
        //Perhaps a redundant method - it used to be more complex

        
        /// <summary>
        /// Adds contents of a string array to a supplied checklist box
        /// </summary>
        /// <param name="checkbox">A checklistbox to populate with values</param>
        /// <param name="dataArray">A list of strings to add as selectable values</param>
        public static void populateCheckListBox(CheckedListBox checkbox, String[] dataArray)
        {
            checkbox.Items.Clear();
            checkbox.Items.AddRange(dataArray);
        }


        /// <summary>
        /// Adds contents of a City Object's goods to a supplied checklist box
        /// </summary>
        /// <param name="checkbox">A checklist box to populate with values</param>
        /// <param name="city">A city with a list of goods to display</param>
        /// <param name="prevSelected"></param>
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
            //However - check for an outof bound index in event of custom/new city that has uneven amount of goods
            if(prevSelected > checkbox.Items.Count)
            {
                prevSelected = checkbox.Items.Count - 1;
            }
            checkbox.SetItemChecked(prevSelected, true);
            checkbox.SelectedItem = checkbox.Items[prevSelected];
        }
        
        /// <summary>
        /// Generate Radio Buttons for a flow layout panel. Allows event handler to be supplied for checkedChanged
        /// </summary>
        /// <param name="flow"></param>
        /// <param name="data">A list of strings to be used as the text of each radio button</param>
        /// <param name="rbtnFunction">Event handler function for CheckedChanged of each radio button</param>
        public static void generateRadioButtons(FlowLayoutPanel flow, List<String> data, System.EventHandler rbtnFunction)
        {
            int i = 1, rbtnHeight = 0;
            //Dynamically create radio buttons for each type of transport
            foreach (String s in data)
            {
                //RadioButton temp = new RadioButton { Text = t.getName() + "\nSlots - " + t.getSlots() + "     Weight Capacity - " + t.getWeight(), Name = "rbtnTransport" + i };
                RadioButton temp = new RadioButton { Text = s, Name = "rbtnTransport" + i };
                temp.AutoSize = false;
                temp.Width = flow.Width - 5;
                //temp.Height = (int) (temp.Height  * 1.5);
                temp.CheckedChanged += (rbtnFunction);
                flow.Controls.Add(temp);
                i++;
                rbtnHeight = temp.Height;
            }
            //Trim the Height of the Flow Panel to remove whitespace from border
            flow.Height = (int)(flow.Controls.OfType<RadioButton>().Count() * rbtnHeight * 1.3);
        }

        /*public static void labelTextBoxInvisible(Label label, TextBox txtbox)
        {
            label.Visible = false;
            txtbox.Visible = false;
        }*/

        //Two functions for moving items up and down a checklist
        /// <summary>
        /// Moves a selected item in a CheckListBox up. Assumes singular selection.
        /// </summary>
        /// <param name="clbox">CheckListBox to be changed visually</param>
        /// <returns>Returns index of currently selected item</returns>
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

        /// <summary>
        /// Moves a selected item in a CheckListBox . Assumes singular selection.
        /// </summary>
        /// <param name="clbox">CheckListBox to be changed visually</param>
        /// <returns>Returns index of currently selected item</returns>
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

        /// <summary>
        /// Checks that a string does not already exist in a given CheckListBox
        /// </summary>
        /// <param name="newItem">String to check for uniqueness</param>
        /// <param name="clbox">CheckListBox to be checked</param>
        /// <returns>Returns if String is unique or not</returns>
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

        /// <summary>
        /// Handles deleting currently selected item from a CheckListBox and ensuring one item still remains selected to prevent possible user errors
        /// </summary>
        /// <param name="clbox">The ChecklistBox to delete currently selected Item</param>
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

        /// <summary>
        /// A method for displaying the results of Commerce Computation in a list view
        /// </summary>
        /// <param name="lview">The List View in which to display results</param>
        /// <param name="results">A Dictionary of values to be supplied in data rows</param>
        public static void displayCommerceResults(ListView lview, Dictionary<String,int> netProfit, Dictionary<String,int> ducatsMins)
        {
            //Check if a null dictionary was sent - simply declare it new as a future check will handle this
            if(ducatsMins == null)
            {
                ducatsMins = new Dictionary<string, int>();
            }
            lview.Items.Clear();
           
            //Display in descending order of net profit first
            foreach (KeyValuePair<String, int> townPrice in netProfit.OrderByDescending(key => key.Value))
            {
                String[] arr = { townPrice.Key, "" + townPrice.Value, "0" };
                //Check if there is an entry for town in DucatsMin
                if (ducatsMins.ContainsKey(townPrice.Key))
                {
                    arr[2] = ducatsMins[townPrice.Key].ToString();
                }
                ListViewItem newItem = new ListViewItem(arr);
                lview.Items.Add(newItem);
            }
        }


        /// <summary>
        /// Dynamically generates textboxes for a flow layoutpanel. Retruns an array of references to make some operations easier.
        /// </summary>
        /// <param name="flpTextBoxes">A flow layout panel that the textboxes will be put into</param>
        /// <param name="numTowns">The number of textboxes to generate. Assumes full total, including the smuggler</param>
        /// <returns>An array of references to the generated textboxes</returns>
        public static TextBox[] generateCommerceTextBoxes(FlowLayoutPanel flpTextBoxes, int numTowns, System.EventHandler textboxFocusFunc)
        {
            flpTextBoxes.Controls.Clear();
            TextBox[] referenceArray = new TextBox[numTowns];
            for (int i = 0; i < numTowns; i++)
            {
                TextBox addToPanel = new TextBox();
                addToPanel.Name = "txtTown" + i;
                addToPanel.Text = "0";
                addToPanel.GotFocus += textboxFocusFunc;
                //For whatever reason setting them exactly as the width chops off the rightmost line of the textbox.
                addToPanel.Width = flpTextBoxes.Width - 5;
                addToPanel.Margin = new Padding(3, 3, 3, 10);
                flpTextBoxes.Controls.Add(addToPanel);
                referenceArray[i] = addToPanel;

            }
            return referenceArray;
        }

        /// <summary>
        /// Dynamically generates labels for a flow layoutpanel. Retruns an array of references to make some operations easier.
        /// </summary>
        /// <param name="flpLabels">A flow layout panel that the labels will be put into</param>
        /// <param name="cityNames">The number of labels to generate. Assumes all cities, including if the smuggler is used or not</param>
        /// <returns>An array of references to the generated labels</returns>
        public static Label[] generateCommerceLabels(FlowLayoutPanel flpLabels, List<String> cityNames)
        {
            flpLabels.Controls.Clear();
            Label[] referenceArray = new Label[cityNames.Count];
            for (int i = 0; i < cityNames.Count; i++)
            {
                Label addToPanel = new Label();
                addToPanel.Name = "txtTown" + i;
                addToPanel.Text = cityNames[i];
                addToPanel.AutoSize = false;
                addToPanel.Width = flpLabels.Width;
                addToPanel.Height = 20;
                //Should Match the same margin as in textboxes unless a change in ratios is necessary
                addToPanel.Margin = new Padding(3, 3, 3, 10);
                addToPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                flpLabels.Controls.Add(addToPanel);
                referenceArray[i] = addToPanel;
            }
            return referenceArray;
        }
    }
}
