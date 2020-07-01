using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mabi_Tools
{
    public partial class frmCommerce : Form
    {
        //Rememberes the actively selected index.
        //Adjust this value to change the default selected value. If I make a configure file, I could add an option to change the default
        private int clboxprevSelectedG = 0;
        private int clboxprevSelectedT = 0;
        private List<String> CityNames;
        public frmCommerce()
        {
            InitializeComponent();
        }

        private void frmCommerce_Load(object sender, EventArgs e)
        {
            //First Load the Cities
            //While it is extremely unlikely that they'll add another city or trade post to the game
            //I decided to add dynamic loading into the mix to allow for more flexiility in the event it happens anyway
            this.loadCommerceData("Cities.txt");
            this.populateCheckListBox(clboxCities, CityNames);
            //Check off the default value in the lists when loading
            clboxGoods.SetItemChecked(this.clboxprevSelectedG, true);
            clboxCities.SetItemChecked(this.clboxprevSelectedT, true);
            
        }

        private void clboxGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            clboxprevSelectedG = makeListBoxExclusitivity(clboxGoods, clboxprevSelectedG);
            lblTest.Text = clboxGoods.SelectedItem.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clboxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            clboxprevSelectedT = makeListBoxExclusitivity(clboxCities, clboxprevSelectedT);
            lblTest.Text = clboxCities.SelectedItem.ToString();
        }

        //Let's turn this into a method for reusability
        private static int makeListBoxExclusitivity(CheckedListBox clistbox, int prevSelected)
        {
            //One item must always be selected. Re-check the box if it was the one selected.
            //Programmer Notes - if you click fast enough - the user can bypass this protection. The threshold of clicks per second is real low so easy to do accidentally.
            //Current Idea is auto-reselect using clboxprevSelect when the user hits "Compute"
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
        private void loadCommerceData(String citiesFile)
        {
            //Will be expanded upon later - for now only need cities
            try
            {
                CityNames = File.ReadAllLines(citiesFile).ToList();
            }catch(FileNotFoundException ex)
            {
                MessageBox.Show("Fatal Error while loading City data : \n" + ex.Message, "Error");
                this.Close();
            }
        }


        private void populateCheckListBox(CheckedListBox checkbox, List<String> data)
        {
            //Clear all the items since they are placeholders
            checkbox.Items.Clear();
            foreach(String s in data)
            {
                checkbox.Items.Add(s);
            }
        }
    }
}
