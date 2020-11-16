using Mabi_Tools.Forms;
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

        /// <summary>
        /// Event handler for launching the Commerce Calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommerce_Click(object sender, EventArgs e)
        {
            Forms.Commerce_Calculator.frmCommerce nextForm = new Forms.Commerce_Calculator.frmCommerce();
            //We want the user to display as many windows as they choose, therefore using Show instead of ShowDialog
            nextForm.Show();
        }

        /// <summary>
        /// Event handler for closing down the form application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Entire Application if Clicking Exit. 
            System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        /// Event handler for launching the Settings Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Forms.frmSettings settingsForm = new Forms.frmSettings();
            settingsForm.ShowDialog();
        }

        /// <summary>
        /// Event handler for Launching the Credits form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCredits_Click(object sender, EventArgs e)
        {
            Forms.frmCredits creditsForm = new Forms.frmCredits();
            creditsForm.Show();
        }

        /// <summary>
        /// Event Handler for the launching the Cooking Meter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCooking_Click(object sender, EventArgs e)
        {
            
            Forms.Cooking_Meter.frmCooking cookingMeter = new Forms.Cooking_Meter.frmCooking();

            cookingMeter.Show();
        }
    }
}
