using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save the file paths
            Properties.Settings.Default.TransportFilePath = txtTransportFile.Text;
            Properties.Settings.Default.TimeFilePath = txtTimeFile.Text;
            Properties.Settings.Default.CityFilePath = txtCityFile.Text;
            Properties.Settings.Default.AssumeHour0 = cboxTimeFormat.Checked;

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtTransportFile.Text = Properties.Settings.Default.TransportFilePath;
            txtTimeFile.Text = Properties.Settings.Default.TimeFilePath;
            txtCityFile.Text = Properties.Settings.Default.CityFilePath;
            cboxTimeFormat.Checked = Properties.Settings.Default.AssumeHour0;

        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            txtTransportFile.Text = "Resources/Transport.csv";
            txtTimeFile.Text = "Resources/Time.csv";
            txtCityFile.Text = "Resources/Cities.csv";
            cboxTimeFormat.Checked = true;
        }
    }
}
