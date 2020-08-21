﻿using System;
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

            Properties.Settings.Default.Save();

            this.Close();
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
                //Now if the user selects OK, update the textbox
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    txtBox.Text = ofd.FileName;
                }
            }
            
        }

    }
}
