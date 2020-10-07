namespace Mabi_Tools.Forms.Cooking_Meter
{
    partial class frmCooking
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtIng1 = new System.Windows.Forms.TextBox();
            this.txtIng2 = new System.Windows.Forms.TextBox();
            this.lblIng1 = new System.Windows.Forms.Label();
            this.lblIng2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(86, 52);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Adjust";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtIng1
            // 
            this.txtIng1.Location = new System.Drawing.Point(40, 26);
            this.txtIng1.Name = "txtIng1";
            this.txtIng1.Size = new System.Drawing.Size(48, 20);
            this.txtIng1.TabIndex = 1;
            this.txtIng1.Text = "30";
            // 
            // txtIng2
            // 
            this.txtIng2.Location = new System.Drawing.Point(168, 26);
            this.txtIng2.Name = "txtIng2";
            this.txtIng2.Size = new System.Drawing.Size(48, 20);
            this.txtIng2.TabIndex = 2;
            this.txtIng2.Text = "40";
            // 
            // lblIng1
            // 
            this.lblIng1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblIng1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIng1.Location = new System.Drawing.Point(10, 10);
            this.lblIng1.Name = "lblIng1";
            this.lblIng1.Size = new System.Drawing.Size(118, 16);
            this.lblIng1.TabIndex = 3;
            this.lblIng1.Text = "% Ingredient 1 :";
            this.lblIng1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIng2
            // 
            this.lblIng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblIng2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIng2.Location = new System.Drawing.Point(125, 10);
            this.lblIng2.Name = "lblIng2";
            this.lblIng2.Size = new System.Drawing.Size(123, 16);
            this.lblIng2.TabIndex = 4;
            this.lblIng2.Text = "% Ingredient 2 :";
            this.lblIng2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(263, 301);
            this.Controls.Add(this.lblIng2);
            this.Controls.Add(this.lblIng1);
            this.Controls.Add(this.txtIng2);
            this.Controls.Add(this.txtIng1);
            this.Controls.Add(this.btnDisplay);
            this.Name = "frmCooking";
            this.Text = "CookingMeter";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(152)))));
            this.Load += new System.EventHandler(this.frmCooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtIng1;
        private System.Windows.Forms.TextBox txtIng2;
        private System.Windows.Forms.Label lblIng1;
        private System.Windows.Forms.Label lblIng2;
    }
}