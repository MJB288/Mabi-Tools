namespace Mabi_Tools
{
    partial class frmCommerceCityEditor
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
            this.clboxCities = new System.Windows.Forms.CheckedListBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCities = new System.Windows.Forms.Label();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtGoodWeight = new System.Windows.Forms.TextBox();
            this.txtGoodSlots = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.btnEditCity = new System.Windows.Forms.Button();
            this.btnAddGood = new System.Windows.Forms.Button();
            this.btnEditGood = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGoodName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clboxGoods = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // clboxCities
            // 
            this.clboxCities.CheckOnClick = true;
            this.clboxCities.FormattingEnabled = true;
            this.clboxCities.Items.AddRange(new object[] {
            "Town1",
            "Town2"});
            this.clboxCities.Location = new System.Drawing.Point(69, 91);
            this.clboxCities.Name = "clboxCities";
            this.clboxCities.Size = new System.Drawing.Size(137, 124);
            this.clboxCities.TabIndex = 0;
            this.clboxCities.SelectedIndexChanged += new System.EventHandler(this.clboxCities_SelectedIndexChanged);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(371, 279);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(75, 20);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Slot Capacity :";
            // 
            // lblCities
            // 
            this.lblCities.AutoSize = true;
            this.lblCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCities.Location = new System.Drawing.Point(108, 58);
            this.lblCities.Name = "lblCities";
            this.lblCities.Size = new System.Drawing.Size(64, 20);
            this.lblCities.TabIndex = 4;
            this.lblCities.Text = "Cities :";
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(361, 168);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(89, 23);
            this.btnAddCity.TabIndex = 5;
            this.btnAddCity.Text = "Add";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(225, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtGoodWeight
            // 
            this.txtGoodWeight.Location = new System.Drawing.Point(493, 278);
            this.txtGoodWeight.Name = "txtGoodWeight";
            this.txtGoodWeight.Size = new System.Drawing.Size(100, 20);
            this.txtGoodWeight.TabIndex = 9;
            // 
            // txtGoodSlots
            // 
            this.txtGoodSlots.Location = new System.Drawing.Point(493, 313);
            this.txtGoodSlots.Name = "txtGoodSlots";
            this.txtGoodSlots.Size = new System.Drawing.Size(100, 20);
            this.txtGoodSlots.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "City Name :";
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(504, 133);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(100, 20);
            this.txtCityName.TabIndex = 12;
            // 
            // btnEditCity
            // 
            this.btnEditCity.Location = new System.Drawing.Point(504, 168);
            this.btnEditCity.Name = "btnEditCity";
            this.btnEditCity.Size = new System.Drawing.Size(89, 23);
            this.btnEditCity.TabIndex = 13;
            this.btnEditCity.Text = "Edit Selected";
            this.btnEditCity.UseVisualStyleBackColor = true;
            this.btnEditCity.Click += new System.EventHandler(this.btnEditCity_Click);
            // 
            // btnAddGood
            // 
            this.btnAddGood.Location = new System.Drawing.Point(361, 339);
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.Size = new System.Drawing.Size(89, 23);
            this.btnAddGood.TabIndex = 14;
            this.btnAddGood.Text = "Add";
            this.btnAddGood.UseVisualStyleBackColor = true;
            // 
            // btnEditGood
            // 
            this.btnEditGood.Location = new System.Drawing.Point(504, 339);
            this.btnEditGood.Name = "btnEditGood";
            this.btnEditGood.Size = new System.Drawing.Size(89, 23);
            this.btnEditGood.TabIndex = 15;
            this.btnEditGood.Text = "Edit Selected";
            this.btnEditGood.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Good Name :";
            // 
            // txtGoodName
            // 
            this.txtGoodName.Location = new System.Drawing.Point(493, 247);
            this.txtGoodName.Name = "txtGoodName";
            this.txtGoodName.Size = new System.Drawing.Size(100, 20);
            this.txtGoodName.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(284, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 41);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save and Apply";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(389, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 41);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // clboxGoods
            // 
            this.clboxGoods.CheckOnClick = true;
            this.clboxGoods.FormattingEnabled = true;
            this.clboxGoods.Items.AddRange(new object[] {
            "Good1",
            "Good2"});
            this.clboxGoods.Location = new System.Drawing.Point(69, 247);
            this.clboxGoods.Name = "clboxGoods";
            this.clboxGoods.Size = new System.Drawing.Size(137, 124);
            this.clboxGoods.TabIndex = 20;
            this.clboxGoods.SelectedIndexChanged += new System.EventHandler(this.clboxGoods_SelectedIndexChanged);
            // 
            // frmCommerceCityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clboxGoods);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGoodName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditGood);
            this.Controls.Add(this.btnAddGood);
            this.Controls.Add(this.btnEditCity);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGoodSlots);
            this.Controls.Add(this.txtGoodWeight);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.lblCities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.clboxCities);
            this.Name = "frmCommerceCityEditor";
            this.Text = "Commerce City Editor";
            this.Load += new System.EventHandler(this.frmCommerceCityEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clboxCities;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCities;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtGoodWeight;
        private System.Windows.Forms.TextBox txtGoodSlots;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Button btnEditCity;
        private System.Windows.Forms.Button btnAddGood;
        private System.Windows.Forms.Button btnEditGood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGoodName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckedListBox clboxGoods;
    }
}