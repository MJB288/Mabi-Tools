namespace Mabi_Tools
{
    partial class MainLauncher
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
            this.btnCommerce = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommerce
            // 
            this.btnCommerce.Location = new System.Drawing.Point(70, 12);
            this.btnCommerce.Name = "btnCommerce";
            this.btnCommerce.Size = new System.Drawing.Size(109, 47);
            this.btnCommerce.TabIndex = 0;
            this.btnCommerce.Text = "Commerce Calculator";
            this.btnCommerce.UseVisualStyleBackColor = true;
            this.btnCommerce.Click += new System.EventHandler(this.btnCommerce_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(70, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 47);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(202, 297);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(37, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "v0.0.3";
            // 
            // MainLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 319);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCommerce);
            this.Name = "MainLauncher";
            this.Text = "Mabi-Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommerce;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblVersion;
    }
}

