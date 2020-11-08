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
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnCooking = new System.Windows.Forms.Button();
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
            this.btnExit.Location = new System.Drawing.Point(70, 277);
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
            this.lblVersion.Location = new System.Drawing.Point(201, 338);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(37, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "v1.5.0";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(70, 171);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(109, 47);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(70, 224);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(109, 47);
            this.btnCredits.TabIndex = 5;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // btnCooking
            // 
            this.btnCooking.Location = new System.Drawing.Point(70, 65);
            this.btnCooking.Name = "btnCooking";
            this.btnCooking.Size = new System.Drawing.Size(109, 47);
            this.btnCooking.TabIndex = 6;
            this.btnCooking.Text = "Cooking Meter";
            this.btnCooking.UseVisualStyleBackColor = true;
            this.btnCooking.Click += new System.EventHandler(this.btnCooking_Click);
            // 
            // MainLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 360);
            this.Controls.Add(this.btnCooking);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnSettings);
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
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnCooking;
    }
}

