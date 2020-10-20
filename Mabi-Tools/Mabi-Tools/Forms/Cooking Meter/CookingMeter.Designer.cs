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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCooking));
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtIng1 = new System.Windows.Forms.TextBox();
            this.txtIng2 = new System.Windows.Forms.TextBox();
            this.lblIng1 = new System.Windows.Forms.Label();
            this.lblIng2 = new System.Windows.Forms.Label();
            this.btnGuideMode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Khaki;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(29, 133);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Adjust";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtIng1
            // 
            this.txtIng1.BackColor = System.Drawing.Color.White;
            this.txtIng1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIng1.ForeColor = System.Drawing.Color.Black;
            this.txtIng1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtIng1.Location = new System.Drawing.Point(36, 28);
            this.txtIng1.Multiline = true;
            this.txtIng1.Name = "txtIng1";
            this.txtIng1.Size = new System.Drawing.Size(60, 20);
            this.txtIng1.TabIndex = 1;
            this.txtIng1.Text = "30";
            this.txtIng1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIng2
            // 
            this.txtIng2.BackColor = System.Drawing.Color.White;
            this.txtIng2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIng2.ForeColor = System.Drawing.Color.Black;
            this.txtIng2.Location = new System.Drawing.Point(38, 70);
            this.txtIng2.Multiline = true;
            this.txtIng2.Name = "txtIng2";
            this.txtIng2.Size = new System.Drawing.Size(57, 20);
            this.txtIng2.TabIndex = 2;
            this.txtIng2.Text = "40";
            this.txtIng2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIng1
            // 
            this.lblIng1.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblIng1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIng1.Location = new System.Drawing.Point(7, 9);
            this.lblIng1.Name = "lblIng1";
            this.lblIng1.Size = new System.Drawing.Size(118, 16);
            this.lblIng1.TabIndex = 3;
            this.lblIng1.Text = "% Ingredient 1 :";
            this.lblIng1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIng2
            // 
            this.lblIng2.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblIng2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIng2.Location = new System.Drawing.Point(5, 51);
            this.lblIng2.Name = "lblIng2";
            this.lblIng2.Size = new System.Drawing.Size(123, 16);
            this.lblIng2.TabIndex = 4;
            this.lblIng2.Text = "% Ingredient 2 :";
            this.lblIng2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGuideMode
            // 
            this.btnGuideMode.BackColor = System.Drawing.Color.Khaki;
            this.btnGuideMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuideMode.Location = new System.Drawing.Point(16, 104);
            this.btnGuideMode.Name = "btnGuideMode";
            this.btnGuideMode.Size = new System.Drawing.Size(101, 23);
            this.btnGuideMode.TabIndex = 5;
            this.btnGuideMode.Text = "Guide : Edge";
            this.btnGuideMode.UseVisualStyleBackColor = false;
            this.btnGuideMode.Click += new System.EventHandler(this.btnGuideMode_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 174);
            this.label1.TabIndex = 6;
            this.label1.Text = " ";
            // 
            // frmCooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(285, 387);
            this.Controls.Add(this.btnGuideMode);
            this.Controls.Add(this.lblIng2);
            this.Controls.Add(this.lblIng1);
            this.Controls.Add(this.txtIng2);
            this.Controls.Add(this.txtIng1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCooking";
            this.Text = "Cooking Meter";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.Load += new System.EventHandler(this.frmCooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtIng1;
        private System.Windows.Forms.Label lblIng1;
        private System.Windows.Forms.Label lblIng2;
        private System.Windows.Forms.Button btnGuideMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIng2;
    }
}