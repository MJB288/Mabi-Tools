using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabi_Tools.Forms
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }
        private readonly Color[] RECTANGLE_COLORS = { Color.Green, Color.Yellow, Color.Red, Color.Blue, Color.Cyan, Color.Orange, Color.Purple, Color.Black, Color.White };
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save the file paths
            Properties.Settings.Default.TransportFilePath = txtTransportFile.Text;
            Properties.Settings.Default.TimeFilePath = txtTimeFile.Text;
            Properties.Settings.Default.CityFilePath = txtCityFile.Text;
            Properties.Settings.Default.MasteryFilePath = txtMasteryFile.Text;
            Properties.Settings.Default.AssumeHour0 = cboxTimeFormat.Checked;
            try
            {
                Properties.Settings.Default.CMeterLength = int.Parse(txtPixelC.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing input for number of pixels : \n" + ex.Message, "Input Error");
            }
            //Save the color scheme
            try
            {
                Properties.Settings.Default.CMGuideLeft = int.Parse(txtCMLeft.Text);
                Properties.Settings.Default.CMGuideRight = int.Parse(txtCMRight.Text);
                Properties.Settings.Default.CMBtnWidth = int.Parse(txtCMButtonWidth.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing input for Guide Buttons : \n" + ex.Message, "Input Error");
            }
            Properties.Settings.Default.CMColor1 = RECTANGLE_COLORS[cmboxCMColor1.SelectedIndex];
            Properties.Settings.Default.CMColor2 = RECTANGLE_COLORS[cmboxCMColor2.SelectedIndex];
            Properties.Settings.Default.CMColor3 = RECTANGLE_COLORS[cmboxCMColor3.SelectedIndex];
            Properties.Settings.Default.CMGuideColor = RECTANGLE_COLORS[cmboxCMGuideColor.SelectedIndex];



            //Save the settings
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            //Set the input on startup
            txtTransportFile.Text = Properties.Settings.Default.TransportFilePath;
            txtTimeFile.Text = Properties.Settings.Default.TimeFilePath;
            txtCityFile.Text = Properties.Settings.Default.CityFilePath;
            txtMasteryFile.Text = Properties.Settings.Default.MasteryFilePath;
            cboxTimeFormat.Checked = Properties.Settings.Default.AssumeHour0;
            //Pixel Guidance of Buttons
            txtPixelC.Text = "" + Properties.Settings.Default.CMeterLength;
            txtCMLeft.Text = "" + Properties.Settings.Default.CMGuideLeft;
            txtCMRight.Text = "" + Properties.Settings.Default.CMGuideRight;
            txtCMButtonWidth.Text = "" + Properties.Settings.Default.CMBtnWidth;
            //Colors
            cmboxCMColor1.SelectedIndex = Array.IndexOf(RECTANGLE_COLORS, Properties.Settings.Default.CMColor1);
            cmboxCMColor2.SelectedIndex = Array.IndexOf(RECTANGLE_COLORS, Properties.Settings.Default.CMColor2);
            cmboxCMColor3.SelectedIndex = Array.IndexOf(RECTANGLE_COLORS, Properties.Settings.Default.CMColor3);
            cmboxCMGuideColor.SelectedIndex = Array.IndexOf(RECTANGLE_COLORS, Properties.Settings.Default.CMGuideColor);
        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            txtTransportFile.Text = "Resources/Transport.csv";
            txtTimeFile.Text = "Resources/Time.csv";
            txtCityFile.Text = "Resources/Cities.csv";
            txtMasteryFile.Text = "Resources/Mastery.csv";
            cboxTimeFormat.Checked = true;
            txtPixelC.Text = "231";
            txtCMLeft.Text = "29";
            txtCMRight.Text = "29";
            txtCMButtonWidth.Text = "69";
            cmboxCMColor1.SelectedIndex = 0;
            cmboxCMColor2.SelectedIndex = 1;
            cmboxCMColor3.SelectedIndex = 2;
            cmboxCMGuideColor.SelectedIndex = 7;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close the form without making changes
            this.Close();
        }

        private void btnFileBrowser_Click(object sender, EventArgs e)
        {
            getFilePathSettings(txtCityFile);
        }

        private void getFilePathSettings(TextBox txtBox)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                //Get the current directory
                ofd.InitialDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                ofd.RestoreDirectory = true;
                ofd.Filter = "csv files(*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*"; ;
                ofd.FilterIndex = 1;
                //Now if the user selects OK, update the textbox
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    txtBox.Text = ofd.FileName;
                }
            }
            
        }

        private void btnFileBroswerTransport_Click(object sender, EventArgs e)
        {
            getFilePathSettings(txtTransportFile);
        }

        private void btnFileBrowserTime_Click(object sender, EventArgs e)
        {
            getFilePathSettings(txtTimeFile);
        }

        private void btnFileBroswerMastery_Click(object sender, EventArgs e)
        {
            getFilePathSettings(txtMasteryFile);
        }
    }
}
