namespace Mabi_Tools.Forms
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCityFile = new System.Windows.Forms.TextBox();
            this.txtTransportFile = new System.Windows.Forms.TextBox();
            this.txtTimeFile = new System.Windows.Forms.TextBox();
            this.lblCityFile = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.cboxTimeFormat = new System.Windows.Forms.CheckBox();
            this.btnFileBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCityFile
            // 
            this.txtCityFile.Location = new System.Drawing.Point(21, 34);
            this.txtCityFile.Name = "txtCityFile";
            this.txtCityFile.Size = new System.Drawing.Size(148, 20);
            this.txtCityFile.TabIndex = 0;
            // 
            // txtTransportFile
            // 
            this.txtTransportFile.Location = new System.Drawing.Point(21, 76);
            this.txtTransportFile.Name = "txtTransportFile";
            this.txtTransportFile.Size = new System.Drawing.Size(148, 20);
            this.txtTransportFile.TabIndex = 1;
            // 
            // txtTimeFile
            // 
            this.txtTimeFile.Location = new System.Drawing.Point(21, 118);
            this.txtTimeFile.Name = "txtTimeFile";
            this.txtTimeFile.Size = new System.Drawing.Size(148, 20);
            this.txtTimeFile.TabIndex = 2;
            // 
            // lblCityFile
            // 
            this.lblCityFile.AutoSize = true;
            this.lblCityFile.Location = new System.Drawing.Point(47, 15);
            this.lblCityFile.Name = "lblCityFile";
            this.lblCityFile.Size = new System.Drawing.Size(108, 13);
            this.lblCityFile.TabIndex = 3;
            this.lblCityFile.Text = "Filepath of City Data :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 41);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save and Apply";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(287, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 41);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Filepath of Transport Data :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Filepath of Time Data :";
            // 
            // btnDefaults
            // 
            this.btnDefaults.Location = new System.Drawing.Point(107, 154);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(84, 41);
            this.btnDefaults.TabIndex = 23;
            this.btnDefaults.Text = "Restore Defaults";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // cboxTimeFormat
            // 
            this.cboxTimeFormat.AutoSize = true;
            this.cboxTimeFormat.Location = new System.Drawing.Point(274, 57);
            this.cboxTimeFormat.Name = "cboxTimeFormat";
            this.cboxTimeFormat.Size = new System.Drawing.Size(180, 17);
            this.cboxTimeFormat.TabIndex = 24;
            this.cboxTimeFormat.Text = "Time Tracker : Assume Hour is 0";
            this.cboxTimeFormat.UseVisualStyleBackColor = true;
            // 
            // btnFileBrowser
            // 
            this.btnFileBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileBrowser.Location = new System.Drawing.Point(175, 34);
            this.btnFileBrowser.Name = "btnFileBrowser";
            this.btnFileBrowser.Size = new System.Drawing.Size(30, 20);
            this.btnFileBrowser.TabIndex = 25;
            this.btnFileBrowser.Text = "...";
            this.btnFileBrowser.UseVisualStyleBackColor = true;
            this.btnFileBrowser.Click += new System.EventHandler(this.btnFileBrowser_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 209);
            this.Controls.Add(this.btnFileBrowser);
            this.Controls.Add(this.cboxTimeFormat);
            this.Controls.Add(this.btnDefaults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCityFile);
            this.Controls.Add(this.txtTimeFile);
            this.Controls.Add(this.txtTransportFile);
            this.Controls.Add(this.txtCityFile);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCityFile;
        private System.Windows.Forms.TextBox txtTransportFile;
        private System.Windows.Forms.TextBox txtTimeFile;
        private System.Windows.Forms.Label lblCityFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.CheckBox cboxTimeFormat;
        private System.Windows.Forms.Button btnFileBrowser;
    }
}