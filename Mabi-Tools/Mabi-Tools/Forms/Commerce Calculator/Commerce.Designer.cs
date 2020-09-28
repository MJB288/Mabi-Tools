namespace Mabi_Tools.Forms.Commerce_Calculator
{
    partial class frmCommerce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommerce));
            this.clboxGoods = new System.Windows.Forms.CheckedListBox();
            this.lblGoods = new System.Windows.Forms.Label();
            this.clboxCities = new System.Windows.Forms.CheckedListBox();
            this.lblCities = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblTransport = new System.Windows.Forms.Label();
            this.lblPrices = new System.Windows.Forms.Label();
            this.flpTransport = new System.Windows.Forms.FlowLayoutPanel();
            this.cboxCommerce = new System.Windows.Forms.CheckBox();
            this.cboxAlpaca = new System.Windows.Forms.CheckBox();
            this.lblItemWeight = new System.Windows.Forms.Label();
            this.lblTransportSlots = new System.Windows.Forms.Label();
            this.lblItemSlots = new System.Windows.Forms.Label();
            this.lblTransportWeight = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmmTools = new System.Windows.Forms.ToolStripMenuItem();
            this.editCityDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTransportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeTrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lviewResults1 = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNetProfit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDucatsMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviewResults2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCompute2 = new System.Windows.Forms.Button();
            this.lblVS = new System.Windows.Forms.Label();
            this.lblResultGood1 = new System.Windows.Forms.Label();
            this.lblResultGood2 = new System.Windows.Forms.Label();
            this.lblResultTransport1 = new System.Windows.Forms.Label();
            this.lblResultTransport2 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnExpand = new System.Windows.Forms.Button();
            this.flpTextBoxes = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCityLabels = new System.Windows.Forms.FlowLayoutPanel();
            this.cboxTransport = new System.Windows.Forms.ComboBox();
            this.cboxMastery = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clboxGoods
            // 
            this.clboxGoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(187)))));
            this.clboxGoods.CheckOnClick = true;
            this.clboxGoods.FormattingEnabled = true;
            this.clboxGoods.Items.AddRange(new object[] {
            "Test1",
            "Test2",
            "Test3",
            "Test4",
            "Test5"});
            this.clboxGoods.Location = new System.Drawing.Point(15, 265);
            this.clboxGoods.Name = "clboxGoods";
            this.clboxGoods.Size = new System.Drawing.Size(145, 124);
            this.clboxGoods.TabIndex = 0;
            this.clboxGoods.SelectedIndexChanged += new System.EventHandler(this.clboxGoods_SelectedIndexChanged);
            // 
            // lblGoods
            // 
            this.lblGoods.AutoSize = true;
            this.lblGoods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGoods.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoods.Location = new System.Drawing.Point(56, 240);
            this.lblGoods.Name = "lblGoods";
            this.lblGoods.Size = new System.Drawing.Size(62, 21);
            this.lblGoods.TabIndex = 2;
            this.lblGoods.Text = "Goods";
            // 
            // clboxCities
            // 
            this.clboxCities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(187)))));
            this.clboxCities.CheckOnClick = true;
            this.clboxCities.FormattingEnabled = true;
            this.clboxCities.Items.AddRange(new object[] {
            "Town1",
            "Town2",
            "Town3",
            "Town4",
            "Town5",
            "Town6",
            "Town7",
            "Town8"});
            this.clboxCities.Location = new System.Drawing.Point(28, 70);
            this.clboxCities.Name = "clboxCities";
            this.clboxCities.Size = new System.Drawing.Size(118, 139);
            this.clboxCities.TabIndex = 3;
            this.clboxCities.SelectedIndexChanged += new System.EventHandler(this.clboxCities_SelectedIndexChanged);
            // 
            // lblCities
            // 
            this.lblCities.AutoSize = true;
            this.lblCities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCities.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCities.Location = new System.Drawing.Point(60, 24);
            this.lblCities.Name = "lblCities";
            this.lblCities.Size = new System.Drawing.Size(54, 21);
            this.lblCities.TabIndex = 4;
            this.lblCities.Text = "Cities";
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCompute.Location = new System.Drawing.Point(660, 76);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(129, 61);
            this.btnCompute.TabIndex = 27;
            this.btnCompute.Text = "Calculate";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTransport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransport.Location = new System.Drawing.Point(452, 24);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(85, 21);
            this.lblTransport.TabIndex = 29;
            this.lblTransport.Text = "Transport";
            // 
            // lblPrices
            // 
            this.lblPrices.AutoSize = true;
            this.lblPrices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrices.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrices.Location = new System.Drawing.Point(239, 24);
            this.lblPrices.Name = "lblPrices";
            this.lblPrices.Size = new System.Drawing.Size(59, 21);
            this.lblPrices.TabIndex = 30;
            this.lblPrices.Text = "Prices";
            // 
            // flpTransport
            // 
            this.flpTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTransport.Enabled = false;
            this.flpTransport.Location = new System.Drawing.Point(1151, 27);
            this.flpTransport.Name = "flpTransport";
            this.flpTransport.Size = new System.Drawing.Size(28, 32);
            this.flpTransport.TabIndex = 34;
            this.flpTransport.Visible = false;
            // 
            // cboxCommerce
            // 
            this.cboxCommerce.Location = new System.Drawing.Point(434, 94);
            this.cboxCommerce.Name = "cboxCommerce";
            this.cboxCommerce.Size = new System.Drawing.Size(121, 26);
            this.cboxCommerce.TabIndex = 35;
            this.cboxCommerce.Text = "Commerce Partner";
            this.cboxCommerce.UseVisualStyleBackColor = true;
            this.cboxCommerce.CheckedChanged += new System.EventHandler(this.cboxCommerce_CheckedChanged);
            // 
            // cboxAlpaca
            // 
            this.cboxAlpaca.Location = new System.Drawing.Point(427, 114);
            this.cboxAlpaca.Name = "cboxAlpaca";
            this.cboxAlpaca.Size = new System.Drawing.Size(134, 28);
            this.cboxAlpaca.TabIndex = 36;
            this.cboxAlpaca.Text = "Alpaca (Wagon Only)";
            this.cboxAlpaca.UseVisualStyleBackColor = true;
            this.cboxAlpaca.CheckedChanged += new System.EventHandler(this.cboxAlpaca_CheckedChanged);
            // 
            // lblItemWeight
            // 
            this.lblItemWeight.AutoSize = true;
            this.lblItemWeight.Location = new System.Drawing.Point(64, 392);
            this.lblItemWeight.Name = "lblItemWeight";
            this.lblItemWeight.Size = new System.Drawing.Size(47, 13);
            this.lblItemWeight.TabIndex = 37;
            this.lblItemWeight.Text = "Weight :";
            this.lblItemWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransportSlots
            // 
            this.lblTransportSlots.AutoSize = true;
            this.lblTransportSlots.Location = new System.Drawing.Point(476, 57);
            this.lblTransportSlots.Name = "lblTransportSlots";
            this.lblTransportSlots.Size = new System.Drawing.Size(36, 13);
            this.lblTransportSlots.TabIndex = 39;
            this.lblTransportSlots.Text = "Slots :";
            // 
            // lblItemSlots
            // 
            this.lblItemSlots.AutoSize = true;
            this.lblItemSlots.Location = new System.Drawing.Point(48, 405);
            this.lblItemSlots.Name = "lblItemSlots";
            this.lblItemSlots.Size = new System.Drawing.Size(78, 13);
            this.lblItemSlots.TabIndex = 40;
            this.lblItemSlots.Text = "Slot Capacity : ";
            this.lblItemSlots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransportWeight
            // 
            this.lblTransportWeight.AutoSize = true;
            this.lblTransportWeight.Location = new System.Drawing.Point(447, 78);
            this.lblTransportWeight.Name = "lblTransportWeight";
            this.lblTransportWeight.Size = new System.Drawing.Size(94, 13);
            this.lblTransportWeight.TabIndex = 41;
            this.lblTransportWeight.Text = "Weight Capacity : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(198)))), ((int)(((byte)(189)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmmFile,
            this.tsmmTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmmFile
            // 
            this.tsmmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmmFile.Name = "tsmmFile";
            this.tsmmFile.Size = new System.Drawing.Size(37, 20);
            this.tsmmFile.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(92, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmmTools
            // 
            this.tsmmTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCityDataToolStripMenuItem,
            this.editTransportDataToolStripMenuItem,
            this.timeTrackerToolStripMenuItem});
            this.tsmmTools.Name = "tsmmTools";
            this.tsmmTools.Size = new System.Drawing.Size(47, 20);
            this.tsmmTools.Text = "Tools";
            // 
            // editCityDataToolStripMenuItem
            // 
            this.editCityDataToolStripMenuItem.Name = "editCityDataToolStripMenuItem";
            this.editCityDataToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.editCityDataToolStripMenuItem.Text = "Edit City Data";
            this.editCityDataToolStripMenuItem.Click += new System.EventHandler(this.editCityDataToolStripMenuItem_Click);
            // 
            // editTransportDataToolStripMenuItem
            // 
            this.editTransportDataToolStripMenuItem.Name = "editTransportDataToolStripMenuItem";
            this.editTransportDataToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.editTransportDataToolStripMenuItem.Text = "Edit Transport Data";
            this.editTransportDataToolStripMenuItem.Click += new System.EventHandler(this.editTransportDataToolStripMenuItem_Click);
            // 
            // timeTrackerToolStripMenuItem
            // 
            this.timeTrackerToolStripMenuItem.Name = "timeTrackerToolStripMenuItem";
            this.timeTrackerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.timeTrackerToolStripMenuItem.Text = "Time Tracker";
            this.timeTrackerToolStripMenuItem.Click += new System.EventHandler(this.timeTrackerToolStripMenuItem_Click);
            // 
            // lviewResults1
            // 
            this.lviewResults1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lviewResults1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmNetProfit,
            this.clmDucatsMin});
            this.lviewResults1.HideSelection = false;
            this.lviewResults1.Location = new System.Drawing.Point(600, 213);
            this.lviewResults1.Name = "lviewResults1";
            this.lviewResults1.Size = new System.Drawing.Size(249, 170);
            this.lviewResults1.TabIndex = 46;
            this.lviewResults1.UseCompatibleStateImageBehavior = false;
            this.lviewResults1.View = System.Windows.Forms.View.Details;
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 100;
            // 
            // clmNetProfit
            // 
            this.clmNetProfit.Text = "Net Profit";
            // 
            // clmDucatsMin
            // 
            this.clmDucatsMin.Text = "Ducats/Min";
            this.clmDucatsMin.Width = 69;
            // 
            // lviewResults2
            // 
            this.lviewResults2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lviewResults2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lviewResults2.HideSelection = false;
            this.lviewResults2.Location = new System.Drawing.Point(896, 213);
            this.lviewResults2.Name = "lviewResults2";
            this.lviewResults2.Size = new System.Drawing.Size(249, 170);
            this.lviewResults2.TabIndex = 47;
            this.lviewResults2.UseCompatibleStateImageBehavior = false;
            this.lviewResults2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Net Profit";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ducats/Min";
            this.columnHeader3.Width = 69;
            // 
            // btnCompute2
            // 
            this.btnCompute2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCompute2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute2.Location = new System.Drawing.Point(956, 76);
            this.btnCompute2.Name = "btnCompute2";
            this.btnCompute2.Size = new System.Drawing.Size(129, 61);
            this.btnCompute2.TabIndex = 48;
            this.btnCompute2.Text = "Calculate";
            this.btnCompute2.UseVisualStyleBackColor = false;
            this.btnCompute2.Click += new System.EventHandler(this.btnCompute2_Click);
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.Location = new System.Drawing.Point(845, 149);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(59, 32);
            this.lblVS.TabIndex = 50;
            this.lblVS.Text = "VS.";
            // 
            // lblResultGood1
            // 
            this.lblResultGood1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultGood1.Location = new System.Drawing.Point(600, 180);
            this.lblResultGood1.Name = "lblResultGood1";
            this.lblResultGood1.Size = new System.Drawing.Size(249, 29);
            this.lblResultGood1.TabIndex = 51;
            this.lblResultGood1.Text = "Good 1";
            this.lblResultGood1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultGood2
            // 
            this.lblResultGood2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultGood2.Location = new System.Drawing.Point(896, 181);
            this.lblResultGood2.Name = "lblResultGood2";
            this.lblResultGood2.Size = new System.Drawing.Size(249, 29);
            this.lblResultGood2.TabIndex = 52;
            this.lblResultGood2.Text = "Good 2";
            this.lblResultGood2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultTransport1
            // 
            this.lblResultTransport1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultTransport1.Location = new System.Drawing.Point(600, 154);
            this.lblResultTransport1.Name = "lblResultTransport1";
            this.lblResultTransport1.Size = new System.Drawing.Size(249, 29);
            this.lblResultTransport1.TabIndex = 53;
            this.lblResultTransport1.Text = "Transport";
            this.lblResultTransport1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultTransport2
            // 
            this.lblResultTransport2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultTransport2.Location = new System.Drawing.Point(896, 154);
            this.lblResultTransport2.Name = "lblResultTransport2";
            this.lblResultTransport2.Size = new System.Drawing.Size(249, 29);
            this.lblResultTransport2.TabIndex = 54;
            this.lblResultTransport2.Text = "Transport";
            this.lblResultTransport2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResults.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(840, 27);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(69, 21);
            this.lblResults.TabIndex = 55;
            this.lblResults.Text = "Results";
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExpand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpand.Location = new System.Drawing.Point(1102, 24);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(43, 41);
            this.btnExpand.TabIndex = 56;
            this.btnExpand.Text = "+";
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // flpTextBoxes
            // 
            this.flpTextBoxes.Location = new System.Drawing.Point(272, 60);
            this.flpTextBoxes.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.flpTextBoxes.Name = "flpTextBoxes";
            this.flpTextBoxes.Size = new System.Drawing.Size(100, 329);
            this.flpTextBoxes.TabIndex = 57;
            // 
            // flpCityLabels
            // 
            this.flpCityLabels.Location = new System.Drawing.Point(182, 60);
            this.flpCityLabels.Name = "flpCityLabels";
            this.flpCityLabels.Size = new System.Drawing.Size(84, 329);
            this.flpCityLabels.TabIndex = 58;
            // 
            // cboxTransport
            // 
            this.cboxTransport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.cboxTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTransport.FormattingEnabled = true;
            this.cboxTransport.Location = new System.Drawing.Point(434, 153);
            this.cboxTransport.Name = "cboxTransport";
            this.cboxTransport.Size = new System.Drawing.Size(121, 28);
            this.cboxTransport.TabIndex = 59;
            this.cboxTransport.SelectedIndexChanged += new System.EventHandler(this.cboxTransport_SelectedIndexChanged);
            // 
            // cboxMastery
            // 
            this.cboxMastery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))));
            this.cboxMastery.FormattingEnabled = true;
            this.cboxMastery.Location = new System.Drawing.Point(434, 242);
            this.cboxMastery.Name = "cboxMastery";
            this.cboxMastery.Size = new System.Drawing.Size(121, 21);
            this.cboxMastery.TabIndex = 60;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(415, 213);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(158, 21);
            this.lbl.TabIndex = 61;
            this.lbl.Text = "Commerce Mastery";
            // 
            // frmCommerce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(190)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1184, 425);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.cboxTransport);
            this.Controls.Add(this.cboxMastery);
            this.Controls.Add(this.flpCityLabels);
            this.Controls.Add(this.flpTextBoxes);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblResultTransport2);
            this.Controls.Add(this.lblResultTransport1);
            this.Controls.Add(this.lblResultGood2);
            this.Controls.Add(this.lblResultGood1);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.btnCompute2);
            this.Controls.Add(this.lviewResults2);
            this.Controls.Add(this.lviewResults1);
            this.Controls.Add(this.lblTransportWeight);
            this.Controls.Add(this.lblItemSlots);
            this.Controls.Add(this.lblTransportSlots);
            this.Controls.Add(this.lblItemWeight);
            this.Controls.Add(this.cboxAlpaca);
            this.Controls.Add(this.cboxCommerce);
            this.Controls.Add(this.flpTransport);
            this.Controls.Add(this.lblPrices);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblCities);
            this.Controls.Add(this.clboxCities);
            this.Controls.Add(this.lblGoods);
            this.Controls.Add(this.clboxGoods);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCommerce";
            this.Text = "Commerce Calculator";
            this.Load += new System.EventHandler(this.frmCommerce_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clboxGoods;
        private System.Windows.Forms.Label lblGoods;
        private System.Windows.Forms.CheckedListBox clboxCities;
        private System.Windows.Forms.Label lblCities;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.Label lblPrices;
        private System.Windows.Forms.FlowLayoutPanel flpTransport;
        private System.Windows.Forms.CheckBox cboxCommerce;
        private System.Windows.Forms.CheckBox cboxAlpaca;
        private System.Windows.Forms.Label lblItemWeight;
        private System.Windows.Forms.Label lblTransportSlots;
        private System.Windows.Forms.Label lblItemSlots;
        private System.Windows.Forms.Label lblTransportWeight;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmmTools;
        private System.Windows.Forms.ToolStripMenuItem editCityDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeTrackerToolStripMenuItem;
        private System.Windows.Forms.ListView lviewResults1;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmNetProfit;
        private System.Windows.Forms.ToolStripMenuItem editTransportDataToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader clmDucatsMin;
        private System.Windows.Forms.ListView lviewResults2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnCompute2;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Label lblResultGood1;
        private System.Windows.Forms.Label lblResultGood2;
        private System.Windows.Forms.Label lblResultTransport1;
        private System.Windows.Forms.Label lblResultTransport2;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.FlowLayoutPanel flpTextBoxes;
        private System.Windows.Forms.FlowLayoutPanel flpCityLabels;
        private System.Windows.Forms.ComboBox cboxTransport;
        private System.Windows.Forms.ComboBox cboxMastery;
        private System.Windows.Forms.Label lbl;
    }
}