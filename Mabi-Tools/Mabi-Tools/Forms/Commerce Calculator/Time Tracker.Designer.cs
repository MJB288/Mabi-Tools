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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblPathName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpBoat = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtnMin = new System.Windows.Forms.RadioButton();
            this.rbtnMax = new System.Windows.Forms.RadioButton();
            this.rbtnMiddle = new System.Windows.Forms.RadioButton();
            this.rbtnCustom = new System.Windows.Forms.RadioButton();
            this.txtCustomTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flpBoat.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTransport
            // 
            this.flpTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTransport.Location = new System.Drawing.Point(43, 32);
            this.flpTransport.Name = "flpTransport";
            this.flpTransport.Size = new System.Drawing.Size(165, 239);
            this.flpTransport.TabIndex = 0;
            // 
            // clboxSource
            // 
            this.clboxSource.CheckOnClick = true;
            this.clboxSource.FormattingEnabled = true;
            this.clboxSource.Location = new System.Drawing.Point(252, 29);
            this.clboxSource.Name = "clboxSource";
            this.clboxSource.Size = new System.Drawing.Size(126, 139);
            this.clboxSource.TabIndex = 2;
            this.clboxSource.SelectedIndexChanged += new System.EventHandler(this.clboxSource_SelectedIndexChanged);
            // 
            // clboxDestination
            // 
            this.clboxDestination.CheckOnClick = true;
            this.clboxDestination.FormattingEnabled = true;
            this.clboxDestination.Location = new System.Drawing.Point(252, 196);
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
            this.lviewTime.FullRowSelect = true;
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
            this.btnSave.Location = new System.Drawing.Point(255, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save and Apply";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(360, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 46);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(436, 306);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(100, 20);
            this.txtPath.TabIndex = 7;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(550, 306);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 8;
            // 
            // lblPathName
            // 
            this.lblPathName.AutoSize = true;
            this.lblPathName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathName.Location = new System.Drawing.Point(440, 290);
            this.lblPathName.Name = "lblPathName";
            this.lblPathName.Size = new System.Drawing.Size(92, 16);
            this.lblPathName.TabIndex = 9;
            this.lblPathName.Text = "Path Name :";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(582, 290);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 13);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(563, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(449, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Source :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Destination :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Method of Transportation : ";
            // 
            // flpBoat
            // 
            this.flpBoat.Controls.Add(this.rbtnMin);
            this.flpBoat.Controls.Add(this.rbtnMax);
            this.flpBoat.Controls.Add(this.rbtnMiddle);
            this.flpBoat.Controls.Add(this.rbtnCustom);
            this.flpBoat.Controls.Add(this.txtCustomTime);
            this.flpBoat.Location = new System.Drawing.Point(24, 296);
            this.flpBoat.Name = "flpBoat";
            this.flpBoat.Size = new System.Drawing.Size(203, 112);
            this.flpBoat.TabIndex = 17;
            // 
            // rbtnMin
            // 
            this.rbtnMin.AutoSize = true;
            this.rbtnMin.Location = new System.Drawing.Point(3, 3);
            this.rbtnMin.Name = "rbtnMin";
            this.rbtnMin.Size = new System.Drawing.Size(134, 17);
            this.rbtnMin.TabIndex = 0;
            this.rbtnMin.TabStop = true;
            this.rbtnMin.Text = "Minimum Possible Time";
            this.rbtnMin.UseVisualStyleBackColor = true;
            // 
            // rbtnMax
            // 
            this.rbtnMax.AutoSize = true;
            this.rbtnMax.Location = new System.Drawing.Point(3, 26);
            this.rbtnMax.Name = "rbtnMax";
            this.rbtnMax.Size = new System.Drawing.Size(137, 17);
            this.rbtnMax.TabIndex = 1;
            this.rbtnMax.TabStop = true;
            this.rbtnMax.Text = "Maximum Possible Time";
            this.rbtnMax.UseVisualStyleBackColor = true;
            // 
            // rbtnMiddle
            // 
            this.rbtnMiddle.AutoSize = true;
            this.rbtnMiddle.Location = new System.Drawing.Point(3, 49);
            this.rbtnMiddle.Name = "rbtnMiddle";
            this.rbtnMiddle.Size = new System.Drawing.Size(176, 17);
            this.rbtnMiddle.TabIndex = 4;
            this.rbtnMiddle.TabStop = true;
            this.rbtnMiddle.Text = "Directly inbetween Min and Max";
            this.rbtnMiddle.UseVisualStyleBackColor = true;
            // 
            // rbtnCustom
            // 
            this.rbtnCustom.AutoSize = true;
            this.rbtnCustom.Location = new System.Drawing.Point(3, 72);
            this.rbtnCustom.Name = "rbtnCustom";
            this.rbtnCustom.Size = new System.Drawing.Size(89, 17);
            this.rbtnCustom.TabIndex = 5;
            this.rbtnCustom.TabStop = true;
            this.rbtnCustom.Text = "Custom Time:";
            this.rbtnCustom.UseVisualStyleBackColor = true;
            // 
            // txtCustomTime
            // 
            this.txtCustomTime.Location = new System.Drawing.Point(98, 72);
            this.txtCustomTime.Name = "txtCustomTime";
            this.txtCustomTime.Size = new System.Drawing.Size(100, 20);
            this.txtCustomTime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "For the Belvast Boat Assume:";
            // 
            // frmTimeTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flpBoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPathName);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lviewTime);
            this.Controls.Add(this.clboxDestination);
            this.Controls.Add(this.clboxSource);
            this.Controls.Add(this.flpTransport);
            this.Name = "frmTimeTracker";
            this.Text = "Time Tracker";
            this.Load += new System.EventHandler(this.frmTimeTracker_Load);
            this.flpBoat.ResumeLayout(false);
            this.flpBoat.PerformLayout();
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
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblPathName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpBoat;
        private System.Windows.Forms.RadioButton rbtnMin;
        private System.Windows.Forms.RadioButton rbtnMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnMiddle;
        private System.Windows.Forms.RadioButton rbtnCustom;
        private System.Windows.Forms.TextBox txtCustomTime;
    }
}