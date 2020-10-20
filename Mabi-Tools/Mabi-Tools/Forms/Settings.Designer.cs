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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
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
            this.btnFileBrowserCity = new System.Windows.Forms.Button();
            this.btnFileBroswerTransport = new System.Windows.Forms.Button();
            this.btnFileBrowserTime = new System.Windows.Forms.Button();
            this.btnFileBroswerMastery = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMasteryFile = new System.Windows.Forms.TextBox();
            this.txtPixelC = new System.Windows.Forms.TextBox();
            this.lblPixelLengthC = new System.Windows.Forms.Label();
            this.cmboxCMColor1 = new System.Windows.Forms.ComboBox();
            this.lblCMColor1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCMColor3 = new System.Windows.Forms.Label();
            this.cmboxCMColor2 = new System.Windows.Forms.ComboBox();
            this.cmboxCMColor3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmboxCMGuideColor = new System.Windows.Forms.ComboBox();
            this.txtCMLeft = new System.Windows.Forms.TextBox();
            this.lblCMLeftGuide = new System.Windows.Forms.Label();
            this.lblCMRightGuide = new System.Windows.Forms.Label();
            this.txtCMRight = new System.Windows.Forms.TextBox();
            this.txtCMButtonWidth = new System.Windows.Forms.TextBox();
            this.lblButtonWidth = new System.Windows.Forms.Label();
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
            this.lblCityFile.Location = new System.Drawing.Point(41, 15);
            this.lblCityFile.Name = "lblCityFile";
            this.lblCityFile.Size = new System.Drawing.Size(108, 13);
            this.lblCityFile.TabIndex = 3;
            this.lblCityFile.Text = "Filepath of City Data :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(221, 231);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 41);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save and Apply";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(311, 231);
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
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Filepath of Transport Data :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Filepath of Time Data :";
            // 
            // btnDefaults
            // 
            this.btnDefaults.Location = new System.Drawing.Point(131, 231);
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
            this.cboxTimeFormat.Location = new System.Drawing.Point(21, 208);
            this.cboxTimeFormat.Name = "cboxTimeFormat";
            this.cboxTimeFormat.Size = new System.Drawing.Size(180, 17);
            this.cboxTimeFormat.TabIndex = 24;
            this.cboxTimeFormat.Text = "Time Tracker : Assume Hour is 0";
            this.cboxTimeFormat.UseVisualStyleBackColor = true;
            // 
            // btnFileBrowserCity
            // 
            this.btnFileBrowserCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileBrowserCity.Location = new System.Drawing.Point(175, 34);
            this.btnFileBrowserCity.Name = "btnFileBrowserCity";
            this.btnFileBrowserCity.Size = new System.Drawing.Size(30, 20);
            this.btnFileBrowserCity.TabIndex = 25;
            this.btnFileBrowserCity.Text = "...";
            this.btnFileBrowserCity.UseVisualStyleBackColor = true;
            this.btnFileBrowserCity.Click += new System.EventHandler(this.btnFileBrowser_Click);
            // 
            // btnFileBroswerTransport
            // 
            this.btnFileBroswerTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileBroswerTransport.Location = new System.Drawing.Point(175, 76);
            this.btnFileBroswerTransport.Name = "btnFileBroswerTransport";
            this.btnFileBroswerTransport.Size = new System.Drawing.Size(30, 20);
            this.btnFileBroswerTransport.TabIndex = 26;
            this.btnFileBroswerTransport.Text = "...";
            this.btnFileBroswerTransport.UseVisualStyleBackColor = true;
            this.btnFileBroswerTransport.Click += new System.EventHandler(this.btnFileBroswerTransport_Click);
            // 
            // btnFileBrowserTime
            // 
            this.btnFileBrowserTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileBrowserTime.Location = new System.Drawing.Point(175, 118);
            this.btnFileBrowserTime.Name = "btnFileBrowserTime";
            this.btnFileBrowserTime.Size = new System.Drawing.Size(30, 20);
            this.btnFileBrowserTime.TabIndex = 27;
            this.btnFileBrowserTime.Text = "...";
            this.btnFileBrowserTime.UseVisualStyleBackColor = true;
            this.btnFileBrowserTime.Click += new System.EventHandler(this.btnFileBrowserTime_Click);
            // 
            // btnFileBroswerMastery
            // 
            this.btnFileBroswerMastery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileBroswerMastery.Location = new System.Drawing.Point(175, 165);
            this.btnFileBroswerMastery.Name = "btnFileBroswerMastery";
            this.btnFileBroswerMastery.Size = new System.Drawing.Size(30, 20);
            this.btnFileBroswerMastery.TabIndex = 30;
            this.btnFileBroswerMastery.Text = "...";
            this.btnFileBroswerMastery.UseVisualStyleBackColor = true;
            this.btnFileBroswerMastery.Click += new System.EventHandler(this.btnFileBroswerMastery_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Filepath of Mastery Data :";
            // 
            // txtMasteryFile
            // 
            this.txtMasteryFile.Location = new System.Drawing.Point(21, 165);
            this.txtMasteryFile.Name = "txtMasteryFile";
            this.txtMasteryFile.Size = new System.Drawing.Size(148, 20);
            this.txtMasteryFile.TabIndex = 28;
            // 
            // txtPixelC
            // 
            this.txtPixelC.Location = new System.Drawing.Point(424, 12);
            this.txtPixelC.Name = "txtPixelC";
            this.txtPixelC.Size = new System.Drawing.Size(70, 20);
            this.txtPixelC.TabIndex = 31;
            // 
            // lblPixelLengthC
            // 
            this.lblPixelLengthC.AutoSize = true;
            this.lblPixelLengthC.Location = new System.Drawing.Point(260, 15);
            this.lblPixelLengthC.Name = "lblPixelLengthC";
            this.lblPixelLengthC.Size = new System.Drawing.Size(155, 13);
            this.lblPixelLengthC.TabIndex = 32;
            this.lblPixelLengthC.Text = "Pixel Length of Cooking Meter :";
            // 
            // cmboxCMColor1
            // 
            this.cmboxCMColor1.FormattingEnabled = true;
            this.cmboxCMColor1.Items.AddRange(new object[] {
            "Green",
            "Yellow",
            "Red",
            "Blue",
            "Cyan",
            "Orange",
            "Purple",
            "Black",
            "White"});
            this.cmboxCMColor1.Location = new System.Drawing.Point(373, 110);
            this.cmboxCMColor1.Name = "cmboxCMColor1";
            this.cmboxCMColor1.Size = new System.Drawing.Size(121, 21);
            this.cmboxCMColor1.TabIndex = 33;
            // 
            // lblCMColor1
            // 
            this.lblCMColor1.AutoSize = true;
            this.lblCMColor1.Location = new System.Drawing.Point(260, 113);
            this.lblCMColor1.Name = "lblCMColor1";
            this.lblCMColor1.Size = new System.Drawing.Size(46, 13);
            this.lblCMColor1.TabIndex = 36;
            this.lblCMColor1.Text = "Color 1 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Color 2 :";
            // 
            // lblCMColor3
            // 
            this.lblCMColor3.AutoSize = true;
            this.lblCMColor3.Location = new System.Drawing.Point(260, 169);
            this.lblCMColor3.Name = "lblCMColor3";
            this.lblCMColor3.Size = new System.Drawing.Size(46, 13);
            this.lblCMColor3.TabIndex = 38;
            this.lblCMColor3.Text = "Color 3 :";
            // 
            // cmboxCMColor2
            // 
            this.cmboxCMColor2.FormattingEnabled = true;
            this.cmboxCMColor2.Items.AddRange(new object[] {
            "Green",
            "Yellow",
            "Red",
            "Blue",
            "Cyan",
            "Orange",
            "Purple",
            "Black",
            "White"});
            this.cmboxCMColor2.Location = new System.Drawing.Point(373, 138);
            this.cmboxCMColor2.Name = "cmboxCMColor2";
            this.cmboxCMColor2.Size = new System.Drawing.Size(121, 21);
            this.cmboxCMColor2.TabIndex = 39;
            // 
            // cmboxCMColor3
            // 
            this.cmboxCMColor3.FormattingEnabled = true;
            this.cmboxCMColor3.Items.AddRange(new object[] {
            "Green",
            "Yellow",
            "Red",
            "Blue",
            "Cyan",
            "Orange",
            "Purple",
            "Black",
            "White"});
            this.cmboxCMColor3.Location = new System.Drawing.Point(373, 166);
            this.cmboxCMColor3.Name = "cmboxCMColor3";
            this.cmboxCMColor3.Size = new System.Drawing.Size(121, 21);
            this.cmboxCMColor3.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Guideline Color :";
            // 
            // cmboxCMGuideColor
            // 
            this.cmboxCMGuideColor.FormattingEnabled = true;
            this.cmboxCMGuideColor.Items.AddRange(new object[] {
            "Green",
            "Yellow",
            "Red",
            "Blue",
            "Cyan",
            "Orange",
            "Purple",
            "Black",
            "White"});
            this.cmboxCMGuideColor.Location = new System.Drawing.Point(373, 195);
            this.cmboxCMGuideColor.Name = "cmboxCMGuideColor";
            this.cmboxCMGuideColor.Size = new System.Drawing.Size(121, 21);
            this.cmboxCMGuideColor.TabIndex = 42;
            // 
            // txtCMLeft
            // 
            this.txtCMLeft.Location = new System.Drawing.Point(424, 34);
            this.txtCMLeft.Name = "txtCMLeft";
            this.txtCMLeft.Size = new System.Drawing.Size(70, 20);
            this.txtCMLeft.TabIndex = 43;
            // 
            // lblCMLeftGuide
            // 
            this.lblCMLeftGuide.AutoSize = true;
            this.lblCMLeftGuide.Location = new System.Drawing.Point(260, 37);
            this.lblCMLeftGuide.Name = "lblCMLeftGuide";
            this.lblCMLeftGuide.Size = new System.Drawing.Size(153, 13);
            this.lblCMLeftGuide.TabIndex = 44;
            this.lblCMLeftGuide.Text = "Distance to Left Guide Button :";
            // 
            // lblCMRightGuide
            // 
            this.lblCMRightGuide.AutoSize = true;
            this.lblCMRightGuide.Location = new System.Drawing.Point(260, 58);
            this.lblCMRightGuide.Name = "lblCMRightGuide";
            this.lblCMRightGuide.Size = new System.Drawing.Size(160, 13);
            this.lblCMRightGuide.TabIndex = 45;
            this.lblCMRightGuide.Text = "Distance to Right Guide Button :";
            // 
            // txtCMRight
            // 
            this.txtCMRight.Location = new System.Drawing.Point(424, 55);
            this.txtCMRight.Name = "txtCMRight";
            this.txtCMRight.Size = new System.Drawing.Size(70, 20);
            this.txtCMRight.TabIndex = 46;
            // 
            // txtCMButtonWidth
            // 
            this.txtCMButtonWidth.Location = new System.Drawing.Point(424, 76);
            this.txtCMButtonWidth.Name = "txtCMButtonWidth";
            this.txtCMButtonWidth.Size = new System.Drawing.Size(70, 20);
            this.txtCMButtonWidth.TabIndex = 48;
            // 
            // lblButtonWidth
            // 
            this.lblButtonWidth.AutoSize = true;
            this.lblButtonWidth.Location = new System.Drawing.Point(260, 79);
            this.lblButtonWidth.Name = "lblButtonWidth";
            this.lblButtonWidth.Size = new System.Drawing.Size(117, 13);
            this.lblButtonWidth.TabIndex = 47;
            this.lblButtonWidth.Text = "Cooking Button Width :";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 284);
            this.Controls.Add(this.txtCMButtonWidth);
            this.Controls.Add(this.lblButtonWidth);
            this.Controls.Add(this.txtCMRight);
            this.Controls.Add(this.lblCMRightGuide);
            this.Controls.Add(this.lblCMLeftGuide);
            this.Controls.Add(this.txtCMLeft);
            this.Controls.Add(this.cmboxCMGuideColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmboxCMColor3);
            this.Controls.Add(this.cmboxCMColor2);
            this.Controls.Add(this.lblCMColor3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCMColor1);
            this.Controls.Add(this.cmboxCMColor1);
            this.Controls.Add(this.lblPixelLengthC);
            this.Controls.Add(this.txtPixelC);
            this.Controls.Add(this.btnFileBroswerMastery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMasteryFile);
            this.Controls.Add(this.btnFileBrowserTime);
            this.Controls.Add(this.btnFileBroswerTransport);
            this.Controls.Add(this.btnFileBrowserCity);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnFileBrowserCity;
        private System.Windows.Forms.Button btnFileBroswerTransport;
        private System.Windows.Forms.Button btnFileBrowserTime;
        private System.Windows.Forms.Button btnFileBroswerMastery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMasteryFile;
        private System.Windows.Forms.TextBox txtPixelC;
        private System.Windows.Forms.Label lblPixelLengthC;
        private System.Windows.Forms.ComboBox cmboxCMColor1;
        private System.Windows.Forms.Label lblCMColor1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCMColor3;
        private System.Windows.Forms.ComboBox cmboxCMColor2;
        private System.Windows.Forms.ComboBox cmboxCMColor3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmboxCMGuideColor;
        private System.Windows.Forms.TextBox txtCMLeft;
        private System.Windows.Forms.Label lblCMLeftGuide;
        private System.Windows.Forms.Label lblCMRightGuide;
        private System.Windows.Forms.TextBox txtCMRight;
        private System.Windows.Forms.TextBox txtCMButtonWidth;
        private System.Windows.Forms.Label lblButtonWidth;
    }
}