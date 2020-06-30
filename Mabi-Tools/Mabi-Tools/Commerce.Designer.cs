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
            this.clboxGoods.Location = new System.Drawing.Point(43, 90);
            this.clboxGoods.Name = "clboxGoods";
            this.clboxGoods.Size = new System.Drawing.Size(118, 124);
            this.clboxGoods.TabIndex = 0;
            this.clboxGoods.SelectedIndexChanged += new System.EventHandler(this.clboxGoods_SelectedIndexChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(519, 184);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(57, 13);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "Something";
            // 
            // frmCommerce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}