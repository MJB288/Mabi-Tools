namespace Mabi_Tools.Forms
{
    partial class frmCredits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCredits));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFriendsThanks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnklblUXWING = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(238, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFriendsThanks
            // 
            this.lblFriendsThanks.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriendsThanks.Location = new System.Drawing.Point(35, 0);
            this.lblFriendsThanks.Name = "lblFriendsThanks";
            this.lblFriendsThanks.Size = new System.Drawing.Size(497, 61);
            this.lblFriendsThanks.TabIndex = 1;
            this.lblFriendsThanks.Text = "A huge thanks to all of my Mabinogi friends for their continued feedback since I " +
    "do not play the game that much anymore";
            this.lblFriendsThanks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Also thanks to UXWing for the free Icons that I used for each window (except for " +
    "the launcher). You can find them here : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnklblUXWING
            // 
            this.lnklblUXWING.AutoSize = true;
            this.lnklblUXWING.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblUXWING.Location = new System.Drawing.Point(199, 155);
            this.lnklblUXWING.Name = "lnklblUXWING";
            this.lnklblUXWING.Size = new System.Drawing.Size(150, 20);
            this.lnklblUXWING.TabIndex = 3;
            this.lnklblUXWING.TabStop = true;
            this.lnklblUXWING.Text = "https://uxwing.com/";
            this.lnklblUXWING.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblUXWING_LinkClicked);
            // 
            // frmCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 290);
            this.Controls.Add(this.lnklblUXWING);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFriendsThanks);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCredits";
            this.Text = "Credits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFriendsThanks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnklblUXWING;
    }
}