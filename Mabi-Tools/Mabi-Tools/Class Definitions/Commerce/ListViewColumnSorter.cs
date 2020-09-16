using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabi_Tools.Classes
{
    //A class designed to sort the columns of a listview when clicked on - written based off the guide from Microsoft Documentation -
    class ListViewColumnSorter : IComparer
    {
        public int ColumnToSort { get; set; }
        public SortOrder SortMode { get; set; }

        private CaseInsensitiveComparer ItemComparer;

        public ListViewColumnSorter()
        {
            //Set the Column to 0, Sort Order to none - and initialize the comparer
            ColumnToSort = 0;
            SortMode = SortOrder.None;
            ItemComparer = new CaseInsensitiveComparer();
        }

        public int Compare(object a, object b)
        {
            int compareResult;
            //Convert the objects into listview items
            ListViewItem lviewItemA, lviewItemB;
            lviewItemA = (ListViewItem)a;
            lviewItemB = (ListViewItem)b;

            int numberA = 0, numberB = 0;

            //Check if both items are numbers
            if (int.TryParse(lviewItemA.SubItems[ColumnToSort].Text, out numberA) && int.TryParse(lviewItemB.SubItems[ColumnToSort].Text, out numberB))
            {
                //MessageBox.Show(numberA + " - " + numberB);
                if(numberA < numberB)
                {
                    compareResult = -1;
                }
                else if(numberA > numberB)
                {
                    compareResult = 1;
                }
                else
                {
                    compareResult = 0;
                }
            }
            //Else compare like they are strings
            else
            {
                //Now compare the items and get the integer result
                compareResult = ItemComparer.Compare(lviewItemA.SubItems[ColumnToSort].Text, lviewItemB.SubItems[ColumnToSort].Text);
            }
            //Now determine how the order mode affects the return result
            //Ascending - normal output
            if (SortMode == SortOrder.Ascending)
            {
                return compareResult;
            }
            //Descending - flip output
            else if (SortMode == SortOrder.Descending)
            {
                return (-compareResult);
            }
            //None - return 0  which means equals - maintain order
            else
            {
                return 0;
            }
            

        }


    }
}
