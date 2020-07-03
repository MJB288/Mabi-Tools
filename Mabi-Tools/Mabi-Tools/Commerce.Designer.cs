namespace Mabi_Tools
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
            this.lblTest = new System.Windows.Forms.Label();
            this.lblGoods = new System.Windows.Forms.Label();
            this.clboxCities = new System.Windows.Forms.CheckedListBox();
            this.lblCities = new System.Windows.Forms.Label();
            this.lboxResults = new System.Windows.Forms.ListBox();
            this.lblResults = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblItemSlots = new System.Windows.Forms.Label();
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
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(690, 184);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(57, 13);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "Something";
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
            // lboxResults
            // 
            this.lboxResults.FormattingEnabled = true;
            this.lboxResults.Items.AddRange(new object[] {
            "Nothing"});
            this.lboxResults.Location = new System.Drawing.Point(659, 261);
            this.lboxResults.Name = "lboxResults";
            this.lboxResults.Size = new System.Drawing.Size(120, 121);
            this.lboxResults.TabIndex = 5;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResults.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(692, 236);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(55, 22);
            this.lblResults.TabIndex = 6;
            this.lblResults.Text = "Results";
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
            this.btnCompute.Location = new System.Drawing.Point(650, 70);
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
            this.lblTransport.Location = new System.Drawing.Point(458, 24);
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
            this.flpTransport.Location = new System.Drawing.Point(390, 162);
            this.flpTransport.Name = "flpTransport";
            this.flpTransport.Size = new System.Drawing.Size(211, 233);
            this.flpTransport.TabIndex = 34;
            // 
            // cboxCommerce
            // 
            this.cboxCommerce.Location = new System.Drawing.Point(390, 96);
            this.cboxCommerce.Name = "cboxCommerce";
            this.cboxCommerce.Size = new System.Drawing.Size(221, 26);
            this.cboxCommerce.TabIndex = 35;
            this.cboxCommerce.Text = "Commerce Partner +1 Slot +100 Weight";
            this.cboxCommerce.UseVisualStyleBackColor = true;
            this.cboxCommerce.CheckedChanged += new System.EventHandler(this.cboxCommerce_CheckedChanged);
            // 
            // cboxAlpaca
            // 
            this.cboxAlpaca.Location = new System.Drawing.Point(390, 128);
            this.cboxAlpaca.Name = "cboxAlpaca";
            this.cboxAlpaca.Size = new System.Drawing.Size(238, 28);
            this.cboxAlpaca.TabIndex = 36;
            this.cboxAlpaca.Text = "Alpaca (Wagon Only) +2 Slots +200 Weight";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "label1";
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
            // frmCommerce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 449);
            this.Controls.Add(this.lblItemSlots);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lboxResults);
            this.Controls.Add(this.lblCities);
            this.Controls.Add(this.clboxCities);
            this.Controls.Add(this.lblGoods);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.clboxGoods);
            this.Name = "frmCommerce";
            this.Text = "Commerce Calculator";
            this.Load += new System.EventHandler(this.frmCommerce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clboxGoods;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblGoods;
        private System.Windows.Forms.CheckedListBox clboxCities;
        private System.Windows.Forms.Label lblCities;
        private System.Windows.Forms.ListBox lboxResults;
        private System.Windows.Forms.Label lblResults;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItemSlots;
    }
}