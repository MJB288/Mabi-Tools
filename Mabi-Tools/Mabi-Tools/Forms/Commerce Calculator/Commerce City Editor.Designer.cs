﻿namespace Mabi_Tools.Forms.Commerce_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommerceCityEditor));
            this.clboxCities = new System.Windows.Forms.CheckedListBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCities = new System.Windows.Forms.Label();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteGood = new System.Windows.Forms.Button();
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
            this.btnMoveUpCity = new System.Windows.Forms.Button();
            this.btnMoveDownCity = new System.Windows.Forms.Button();
            this.btnMoveUpGood = new System.Windows.Forms.Button();
            this.btnMoveDownGood = new System.Windows.Forms.Button();
            this.lblGood = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clboxCities
            // 
            this.clboxCities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(254)))), ((int)(((byte)(190)))));
            this.clboxCities.CheckOnClick = true;
            this.clboxCities.FormattingEnabled = true;
            this.clboxCities.Items.AddRange(new object[] {
            "Town1",
            "Town2"});
            this.clboxCities.Location = new System.Drawing.Point(12, 53);
            this.clboxCities.Name = "clboxCities";
            this.clboxCities.Size = new System.Drawing.Size(137, 124);
            this.clboxCities.TabIndex = 0;
            this.clboxCities.SelectedIndexChanged += new System.EventHandler(this.clboxCities_SelectedIndexChanged);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(295, 216);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(75, 20);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Slot Capacity :";
            // 
            // lblCities
            // 
            this.lblCities.AutoSize = true;
            this.lblCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCities.Location = new System.Drawing.Point(48, 20);
            this.lblCities.Name = "lblCities";
            this.lblCities.Size = new System.Drawing.Size(64, 20);
            this.lblCities.TabIndex = 4;
            this.lblCities.Text = "Cities :";
            // 
            // btnAddCity
            // 
            this.btnAddCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddCity.Location = new System.Drawing.Point(285, 105);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(89, 23);
            this.btnAddCity.TabIndex = 5;
            this.btnAddCity.Text = "Add";
            this.btnAddCity.UseVisualStyleBackColor = false;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(161, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteGood
            // 
            this.btnDeleteGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteGood.Location = new System.Drawing.Point(161, 224);
            this.btnDeleteGood.Name = "btnDeleteGood";
            this.btnDeleteGood.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGood.TabIndex = 8;
            this.btnDeleteGood.Text = "Delete";
            this.btnDeleteGood.UseVisualStyleBackColor = false;
            this.btnDeleteGood.Click += new System.EventHandler(this.btnDeleteGood_Click);
            // 
            // txtGoodWeight
            // 
            this.txtGoodWeight.Location = new System.Drawing.Point(417, 215);
            this.txtGoodWeight.Name = "txtGoodWeight";
            this.txtGoodWeight.Size = new System.Drawing.Size(100, 20);
            this.txtGoodWeight.TabIndex = 9;
            // 
            // txtGoodSlots
            // 
            this.txtGoodSlots.Location = new System.Drawing.Point(417, 250);
            this.txtGoodSlots.Name = "txtGoodSlots";
            this.txtGoodSlots.Size = new System.Drawing.Size(100, 20);
            this.txtGoodSlots.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "City Name :";
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(417, 70);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(100, 20);
            this.txtCityName.TabIndex = 12;
            // 
            // btnEditCity
            // 
            this.btnEditCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditCity.Location = new System.Drawing.Point(428, 105);
            this.btnEditCity.Name = "btnEditCity";
            this.btnEditCity.Size = new System.Drawing.Size(89, 23);
            this.btnEditCity.TabIndex = 13;
            this.btnEditCity.Text = "Edit Selected";
            this.btnEditCity.UseVisualStyleBackColor = false;
            this.btnEditCity.Click += new System.EventHandler(this.btnEditCity_Click);
            // 
            // btnAddGood
            // 
            this.btnAddGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddGood.Location = new System.Drawing.Point(285, 276);
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.Size = new System.Drawing.Size(89, 23);
            this.btnAddGood.TabIndex = 14;
            this.btnAddGood.Text = "Add";
            this.btnAddGood.UseVisualStyleBackColor = false;
            this.btnAddGood.Click += new System.EventHandler(this.btnAddGood_Click);
            // 
            // btnEditGood
            // 
            this.btnEditGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditGood.Location = new System.Drawing.Point(428, 276);
            this.btnEditGood.Name = "btnEditGood";
            this.btnEditGood.Size = new System.Drawing.Size(89, 23);
            this.btnEditGood.TabIndex = 15;
            this.btnEditGood.Text = "Edit Selected";
            this.btnEditGood.UseVisualStyleBackColor = false;
            this.btnEditGood.Click += new System.EventHandler(this.btnEditGood_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Good Name :";
            // 
            // txtGoodName
            // 
            this.txtGoodName.Location = new System.Drawing.Point(417, 184);
            this.txtGoodName.Name = "txtGoodName";
            this.txtGoodName.Size = new System.Drawing.Size(100, 20);
            this.txtGoodName.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(176, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 41);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save and Apply";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(281, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 41);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // clboxGoods
            // 
            this.clboxGoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(254)))), ((int)(((byte)(190)))));
            this.clboxGoods.CheckOnClick = true;
            this.clboxGoods.FormattingEnabled = true;
            this.clboxGoods.Items.AddRange(new object[] {
            "Good1",
            "Good2"});
            this.clboxGoods.Location = new System.Drawing.Point(12, 209);
            this.clboxGoods.Name = "clboxGoods";
            this.clboxGoods.Size = new System.Drawing.Size(137, 124);
            this.clboxGoods.TabIndex = 20;
            this.clboxGoods.SelectedIndexChanged += new System.EventHandler(this.clboxGoods_SelectedIndexChanged);
            // 
            // btnMoveUpCity
            // 
            this.btnMoveUpCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.btnMoveUpCity.Location = new System.Drawing.Point(161, 96);
            this.btnMoveUpCity.Name = "btnMoveUpCity";
            this.btnMoveUpCity.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUpCity.TabIndex = 21;
            this.btnMoveUpCity.Text = "Move Up";
            this.btnMoveUpCity.UseVisualStyleBackColor = false;
            this.btnMoveUpCity.Click += new System.EventHandler(this.btnMoveUpCity_Click);
            // 
            // btnMoveDownCity
            // 
            this.btnMoveDownCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.btnMoveDownCity.Location = new System.Drawing.Point(161, 130);
            this.btnMoveDownCity.Name = "btnMoveDownCity";
            this.btnMoveDownCity.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDownCity.TabIndex = 22;
            this.btnMoveDownCity.Text = "Move Down";
            this.btnMoveDownCity.UseVisualStyleBackColor = false;
            this.btnMoveDownCity.Click += new System.EventHandler(this.btnMoveDownCity_Click);
            // 
            // btnMoveUpGood
            // 
            this.btnMoveUpGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.btnMoveUpGood.Location = new System.Drawing.Point(161, 257);
            this.btnMoveUpGood.Name = "btnMoveUpGood";
            this.btnMoveUpGood.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUpGood.TabIndex = 23;
            this.btnMoveUpGood.Text = "Move Up";
            this.btnMoveUpGood.UseVisualStyleBackColor = false;
            this.btnMoveUpGood.Click += new System.EventHandler(this.btnMoveUpGood_Click);
            // 
            // btnMoveDownGood
            // 
            this.btnMoveDownGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.btnMoveDownGood.Location = new System.Drawing.Point(161, 292);
            this.btnMoveDownGood.Name = "btnMoveDownGood";
            this.btnMoveDownGood.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDownGood.TabIndex = 24;
            this.btnMoveDownGood.Text = "Move Down";
            this.btnMoveDownGood.UseVisualStyleBackColor = false;
            this.btnMoveDownGood.Click += new System.EventHandler(this.btnMoveDownGood_Click);
            // 
            // lblGood
            // 
            this.lblGood.AutoSize = true;
            this.lblGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGood.Location = new System.Drawing.Point(44, 186);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(72, 20);
            this.lblGood.TabIndex = 25;
            this.lblGood.Text = "Goods :";
            // 
            // frmCommerceCityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(180)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(540, 408);
            this.Controls.Add(this.lblGood);
            this.Controls.Add(this.btnMoveDownGood);
            this.Controls.Add(this.btnMoveUpGood);
            this.Controls.Add(this.btnMoveDownCity);
            this.Controls.Add(this.btnMoveUpCity);
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
            this.Controls.Add(this.btnDeleteGood);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.lblCities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.clboxCities);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnDeleteGood;
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
        private System.Windows.Forms.Button btnMoveUpCity;
        private System.Windows.Forms.Button btnMoveDownCity;
        private System.Windows.Forms.Button btnMoveUpGood;
        private System.Windows.Forms.Button btnMoveDownGood;
        private System.Windows.Forms.Label lblGood;
    }
}