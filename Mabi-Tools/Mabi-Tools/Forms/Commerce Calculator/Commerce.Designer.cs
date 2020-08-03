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
            this.clboxGoods = new System.Windows.Forms.CheckedListBox();
            this.lblGoods = new System.Windows.Forms.Label();
            this.clboxCities = new System.Windows.Forms.CheckedListBox();
            this.lblCities = new System.Windows.Forms.Label();
            this.txtTown0 = new System.Windows.Forms.TextBox();
            this.lblTown0 = new System.Windows.Forms.Label();
            this.lblTown1 = new System.Windows.Forms.Label();
            this.txtTown1 = new System.Windows.Forms.TextBox();
            this.lblTown2 = new System.Windows.Forms.Label();
            this.txtTown2 = new System.Windows.Forms.TextBox();
            this.lblTown3 = new System.Windows.Forms.Label();
            this.txtTown3 = new System.Windows.Forms.TextBox();
            this.lblTown4 = new System.Windows.Forms.Label();
            this.txtTown4 = new System.Windows.Forms.TextBox();
            this.lblTown5 = new System.Windows.Forms.Label();
            this.txtTown5 = new System.Windows.Forms.TextBox();
            this.lblTown6 = new System.Windows.Forms.Label();
            this.txtTown6 = new System.Windows.Forms.TextBox();
            this.txtTown7 = new System.Windows.Forms.TextBox();
            this.lblTown7 = new System.Windows.Forms.Label();
            this.lblTown8 = new System.Windows.Forms.Label();
            this.txtTown8 = new System.Windows.Forms.TextBox();
            this.lblTown9 = new System.Windows.Forms.Label();
            this.txtTown9 = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clboxGoods
            // 
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
            this.lblGoods.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoods.Location = new System.Drawing.Point(61, 240);
            this.lblGoods.Name = "lblGoods";
            this.lblGoods.Size = new System.Drawing.Size(52, 22);
            this.lblGoods.TabIndex = 2;
            this.lblGoods.Text = "Goods";
            // 
            // clboxCities
            // 
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
            this.lblCities.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCities.Location = new System.Drawing.Point(65, 24);
            this.lblCities.Name = "lblCities";
            this.lblCities.Size = new System.Drawing.Size(44, 22);
            this.lblCities.TabIndex = 4;
            this.lblCities.Text = "Cities";
            // 
            // txtTown0
            // 
            this.txtTown0.Location = new System.Drawing.Point(262, 78);
            this.txtTown0.Name = "txtTown0";
            this.txtTown0.Size = new System.Drawing.Size(100, 20);
            this.txtTown0.TabIndex = 7;
            this.txtTown0.Text = "0";
            // 
            // lblTown0
            // 
            this.lblTown0.AutoSize = true;
            this.lblTown0.Location = new System.Drawing.Point(182, 81);
            this.lblTown0.Name = "lblTown0";
            this.lblTown0.Size = new System.Drawing.Size(43, 13);
            this.lblTown0.TabIndex = 8;
            this.lblTown0.Text = "Town 1";
            // 
            // lblTown1
            // 
            this.lblTown1.AutoSize = true;
            this.lblTown1.Location = new System.Drawing.Point(182, 114);
            this.lblTown1.Name = "lblTown1";
            this.lblTown1.Size = new System.Drawing.Size(43, 13);
            this.lblTown1.TabIndex = 9;
            this.lblTown1.Text = "Town 2";
            // 
            // txtTown1
            // 
            this.txtTown1.Location = new System.Drawing.Point(262, 111);
            this.txtTown1.Name = "txtTown1";
            this.txtTown1.Size = new System.Drawing.Size(100, 20);
            this.txtTown1.TabIndex = 10;
            this.txtTown1.Text = "0";
            // 
            // lblTown2
            // 
            this.lblTown2.AutoSize = true;
            this.lblTown2.Location = new System.Drawing.Point(182, 147);
            this.lblTown2.Name = "lblTown2";
            this.lblTown2.Size = new System.Drawing.Size(43, 13);
            this.lblTown2.TabIndex = 11;
            this.lblTown2.Text = "Town 3";
            // 
            // txtTown2
            // 
            this.txtTown2.Location = new System.Drawing.Point(262, 144);
            this.txtTown2.Name = "txtTown2";
            this.txtTown2.Size = new System.Drawing.Size(100, 20);
            this.txtTown2.TabIndex = 12;
            this.txtTown2.Text = "0";
            // 
            // lblTown3
            // 
            this.lblTown3.AutoSize = true;
            this.lblTown3.Location = new System.Drawing.Point(182, 180);
            this.lblTown3.Name = "lblTown3";
            this.lblTown3.Size = new System.Drawing.Size(43, 13);
            this.lblTown3.TabIndex = 13;
            this.lblTown3.Text = "Town 4";
            // 
            // txtTown3
            // 
            this.txtTown3.Location = new System.Drawing.Point(262, 177);
            this.txtTown3.Name = "txtTown3";
            this.txtTown3.Size = new System.Drawing.Size(100, 20);
            this.txtTown3.TabIndex = 14;
            this.txtTown3.Text = "0";
            // 
            // lblTown4
            // 
            this.lblTown4.AutoSize = true;
            this.lblTown4.Location = new System.Drawing.Point(182, 213);
            this.lblTown4.Name = "lblTown4";
            this.lblTown4.Size = new System.Drawing.Size(43, 13);
            this.lblTown4.TabIndex = 15;
            this.lblTown4.Text = "Town 5";
            // 
            // txtTown4
            // 
            this.txtTown4.Location = new System.Drawing.Point(262, 210);
            this.txtTown4.Name = "txtTown4";
            this.txtTown4.Size = new System.Drawing.Size(100, 20);
            this.txtTown4.TabIndex = 16;
            this.txtTown4.Text = "0";
            // 
            // lblTown5
            // 
            this.lblTown5.AutoSize = true;
            this.lblTown5.Location = new System.Drawing.Point(182, 246);
            this.lblTown5.Name = "lblTown5";
            this.lblTown5.Size = new System.Drawing.Size(43, 13);
            this.lblTown5.TabIndex = 17;
            this.lblTown5.Text = "Town 6";
            // 
            // txtTown5
            // 
            this.txtTown5.Location = new System.Drawing.Point(262, 243);
            this.txtTown5.Name = "txtTown5";
            this.txtTown5.Size = new System.Drawing.Size(100, 20);
            this.txtTown5.TabIndex = 18;
            this.txtTown5.Text = "0";
            // 
            // lblTown6
            // 
            this.lblTown6.AutoSize = true;
            this.lblTown6.Location = new System.Drawing.Point(182, 279);
            this.lblTown6.Name = "lblTown6";
            this.lblTown6.Size = new System.Drawing.Size(43, 13);
            this.lblTown6.TabIndex = 19;
            this.lblTown6.Text = "Town 7";
            // 
            // txtTown6
            // 
            this.txtTown6.Location = new System.Drawing.Point(262, 276);
            this.txtTown6.Name = "txtTown6";
            this.txtTown6.Size = new System.Drawing.Size(100, 20);
            this.txtTown6.TabIndex = 20;
            this.txtTown6.Text = "0";
            // 
            // txtTown7
            // 
            this.txtTown7.Location = new System.Drawing.Point(262, 309);
            this.txtTown7.Name = "txtTown7";
            this.txtTown7.Size = new System.Drawing.Size(100, 20);
            this.txtTown7.TabIndex = 21;
            this.txtTown7.Text = "0";
            // 
            // lblTown7
            // 
            this.lblTown7.AutoSize = true;
            this.lblTown7.Location = new System.Drawing.Point(182, 312);
            this.lblTown7.Name = "lblTown7";
            this.lblTown7.Size = new System.Drawing.Size(43, 13);
            this.lblTown7.TabIndex = 22;
            this.lblTown7.Text = "Town 8";
            // 
            // lblTown8
            // 
            this.lblTown8.AutoSize = true;
            this.lblTown8.Location = new System.Drawing.Point(182, 345);
            this.lblTown8.Name = "lblTown8";
            this.lblTown8.Size = new System.Drawing.Size(43, 13);
            this.lblTown8.TabIndex = 23;
            this.lblTown8.Text = "Town 9";
            // 
            // txtTown8
            // 
            this.txtTown8.Location = new System.Drawing.Point(262, 342);
            this.txtTown8.Name = "txtTown8";
            this.txtTown8.Size = new System.Drawing.Size(100, 20);
            this.txtTown8.TabIndex = 24;
            this.txtTown8.Text = "0";
            // 
            // lblTown9
            // 
            this.lblTown9.AutoSize = true;
            this.lblTown9.Location = new System.Drawing.Point(182, 378);
            this.lblTown9.Name = "lblTown9";
            this.lblTown9.Size = new System.Drawing.Size(49, 13);
            this.lblTown9.TabIndex = 25;
            this.lblTown9.Text = "Town 10";
            // 
            // txtTown9
            // 
            this.txtTown9.Location = new System.Drawing.Point(262, 375);
            this.txtTown9.Name = "txtTown9";
            this.txtTown9.Size = new System.Drawing.Size(100, 20);
            this.txtTown9.TabIndex = 26;
            this.txtTown9.Text = "0";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(660, 76);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(129, 61);
            this.btnCompute.TabIndex = 27;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTransport.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransport.Location = new System.Drawing.Point(461, 24);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(66, 22);
            this.lblTransport.TabIndex = 29;
            this.lblTransport.Text = "Transport";
            // 
            // lblPrices
            // 
            this.lblPrices.AutoSize = true;
            this.lblPrices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrices.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrices.Location = new System.Drawing.Point(233, 24);
            this.lblPrices.Name = "lblPrices";
            this.lblPrices.Size = new System.Drawing.Size(49, 22);
            this.lblPrices.TabIndex = 30;
            this.lblPrices.Text = "Prices";
            // 
            // flpTransport
            // 
            this.flpTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTransport.Location = new System.Drawing.Point(405, 149);
            this.flpTransport.Name = "flpTransport";
            this.flpTransport.Size = new System.Drawing.Size(179, 233);
            this.flpTransport.TabIndex = 34;
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
            this.lblItemWeight.Location = new System.Drawing.Point(65, 392);
            this.lblItemWeight.Name = "lblItemWeight";
            this.lblItemWeight.Size = new System.Drawing.Size(47, 13);
            this.lblItemWeight.TabIndex = 37;
            this.lblItemWeight.Text = "Weight :";
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
            this.lblItemSlots.Location = new System.Drawing.Point(49, 405);
            this.lblItemSlots.Name = "lblItemSlots";
            this.lblItemSlots.Size = new System.Drawing.Size(78, 13);
            this.lblItemSlots.TabIndex = 40;
            this.lblItemSlots.Text = "Slot Capacity : ";
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmmFile,
            this.tsmmTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1241, 24);
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
            this.lviewResults1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmNetProfit,
            this.clmDucatsMin});
            this.lviewResults1.HideSelection = false;
            this.lviewResults1.Location = new System.Drawing.Point(601, 213);
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
            this.clmNetProfit.Text = "Value";
            // 
            // clmDucatsMin
            // 
            this.clmDucatsMin.Text = "Ducats/Min";
            this.clmDucatsMin.Width = 69;
            // 
            // lviewResults2
            // 
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
            this.columnHeader2.Text = "Value";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ducats/Min";
            this.columnHeader3.Width = 69;
            // 
            // btnCompute2
            // 
            this.btnCompute2.Location = new System.Drawing.Point(956, 76);
            this.btnCompute2.Name = "btnCompute2";
            this.btnCompute2.Size = new System.Drawing.Size(129, 61);
            this.btnCompute2.TabIndex = 48;
            this.btnCompute2.Text = "Compute";
            this.btnCompute2.UseVisualStyleBackColor = true;
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
            this.lblResultGood1.Location = new System.Drawing.Point(601, 180);
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
            this.lblResultTransport1.Location = new System.Drawing.Point(601, 154);
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
            // frmCommerce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 437);
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
            this.Controls.Add(this.txtTown9);
            this.Controls.Add(this.lblTown9);
            this.Controls.Add(this.txtTown8);
            this.Controls.Add(this.lblTown8);
            this.Controls.Add(this.lblTown7);
            this.Controls.Add(this.txtTown7);
            this.Controls.Add(this.txtTown6);
            this.Controls.Add(this.lblTown6);
            this.Controls.Add(this.txtTown5);
            this.Controls.Add(this.lblTown5);
            this.Controls.Add(this.txtTown4);
            this.Controls.Add(this.lblTown4);
            this.Controls.Add(this.txtTown3);
            this.Controls.Add(this.lblTown3);
            this.Controls.Add(this.txtTown2);
            this.Controls.Add(this.lblTown2);
            this.Controls.Add(this.txtTown1);
            this.Controls.Add(this.lblTown1);
            this.Controls.Add(this.lblTown0);
            this.Controls.Add(this.txtTown0);
            this.Controls.Add(this.lblCities);
            this.Controls.Add(this.clboxCities);
            this.Controls.Add(this.lblGoods);
            this.Controls.Add(this.clboxGoods);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.TextBox txtTown0;
        private System.Windows.Forms.Label lblTown0;
        private System.Windows.Forms.Label lblTown1;
        private System.Windows.Forms.TextBox txtTown1;
        private System.Windows.Forms.Label lblTown2;
        private System.Windows.Forms.TextBox txtTown2;
        private System.Windows.Forms.Label lblTown3;
        private System.Windows.Forms.TextBox txtTown3;
        private System.Windows.Forms.Label lblTown4;
        private System.Windows.Forms.TextBox txtTown4;
        private System.Windows.Forms.Label lblTown5;
        private System.Windows.Forms.TextBox txtTown5;
        private System.Windows.Forms.Label lblTown6;
        private System.Windows.Forms.TextBox txtTown6;
        private System.Windows.Forms.TextBox txtTown7;
        private System.Windows.Forms.Label lblTown7;
        private System.Windows.Forms.Label lblTown8;
        private System.Windows.Forms.TextBox txtTown8;
        private System.Windows.Forms.Label lblTown9;
        private System.Windows.Forms.TextBox txtTown9;
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
    }
}