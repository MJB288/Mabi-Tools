namespace Mabi_Tools.Forms.Commerce_Calculator
{
    partial class frmTimeTracker
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
            this.flpTransport = new System.Windows.Forms.FlowLayoutPanel();
            this.clboxSource = new System.Windows.Forms.CheckedListBox();
            this.clboxDestination = new System.Windows.Forms.CheckedListBox();
            this.lviewTime = new System.Windows.Forms.ListView();
            this.clmPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPathName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpTransport
            // 
            this.flpTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTransport.Location = new System.Drawing.Point(33, 39);
            this.flpTransport.Name = "flpTransport";
            this.flpTransport.Size = new System.Drawing.Size(165, 313);
            this.flpTransport.TabIndex = 0;
            // 
            // clboxSource
            // 
            this.clboxSource.CheckOnClick = true;
            this.clboxSource.FormattingEnabled = true;
            this.clboxSource.Location = new System.Drawing.Point(236, 39);
            this.clboxSource.Name = "clboxSource";
            this.clboxSource.Size = new System.Drawing.Size(126, 139);
            this.clboxSource.TabIndex = 2;
            this.clboxSource.SelectedIndexChanged += new System.EventHandler(this.clboxSource_SelectedIndexChanged);
            // 
            // clboxDestination
            // 
            this.clboxDestination.CheckOnClick = true;
            this.clboxDestination.FormattingEnabled = true;
            this.clboxDestination.Location = new System.Drawing.Point(236, 197);
            this.clboxDestination.Name = "clboxDestination";
            this.clboxDestination.Size = new System.Drawing.Size(126, 139);
            this.clboxDestination.TabIndex = 3;
            this.clboxDestination.SelectedIndexChanged += new System.EventHandler(this.clboxDestination_SelectedIndexChanged);
            // 
            // lviewTime
            // 
            this.lviewTime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmPath,
            this.clmTime});
            this.lviewTime.HideSelection = false;
            this.lviewTime.Location = new System.Drawing.Point(436, 23);
            this.lviewTime.Name = "lviewTime";
            this.lviewTime.Size = new System.Drawing.Size(217, 218);
            this.lviewTime.TabIndex = 4;
            this.lviewTime.UseCompatibleStateImageBehavior = false;
            this.lviewTime.View = System.Windows.Forms.View.Details;
            // 
            // clmPath
            // 
            this.clmPath.Text = "Path Name";
            this.clmPath.Width = 120;
            // 
            // clmTime
            // 
            this.clmTime.Text = "Time";
            this.clmTime.Width = 80;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(236, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save and Apply";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(341, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 46);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(424, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(563, 281);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // lblPathName
            // 
            this.lblPathName.AutoSize = true;
            this.lblPathName.Location = new System.Drawing.Point(444, 265);
            this.lblPathName.Name = "lblPathName";
            this.lblPathName.Size = new System.Drawing.Size(66, 13);
            this.lblPathName.TabIndex = 9;
            this.lblPathName.Text = "Path Name :";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(594, 265);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 13);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(563, 312);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(449, 312);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Source :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Destination :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Method of Transportation : ";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(269, 355);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(66, 13);
            this.lblTest.TabIndex = 17;
            this.lblTest.Text = "Path Name :";
            // 
            // frmTimeTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPathName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lviewTime);
            this.Controls.Add(this.clboxDestination);
            this.Controls.Add(this.clboxSource);
            this.Controls.Add(this.flpTransport);
            this.Name = "frmTimeTracker";
            this.Text = "Time Tracker";
            this.Load += new System.EventHandler(this.frmTimeTracker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTransport;
        private System.Windows.Forms.CheckedListBox clboxSource;
        private System.Windows.Forms.CheckedListBox clboxDestination;
        private System.Windows.Forms.ListView lviewTime;
        private System.Windows.Forms.ColumnHeader clmPath;
        private System.Windows.Forms.ColumnHeader clmTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPathName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTest;
    }
}