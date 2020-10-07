using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabi_Tools.Forms.Cooking_Meter
{
    public partial class frmCooking : Form
    {
        private static readonly int METER_LENGTH = 229;
        private static readonly int METER_START_X = 16;
        private static readonly int METER_START_Y = 169;
        private static readonly int METER_HEIGHT = 5;
        private static readonly Color[] RECTANGLE_COLORS = { Color.Green, Color.Yellow, Color.Red };
        private Graphics FormGraphics;
        private bool DrawRectangles = false;
        private int[] Percentages = {30, 40, 30};
        public frmCooking()
        {
            InitializeComponent();
            FormGraphics = this.CreateGraphics();
        }

        private void frmCooking_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.TopMost = true;
            //draw3Rectangles();
            this.Paint += frmCooking_Paint;
        }

        private void frmCooking_Paint(object sender, PaintEventArgs pe)
        {
            draw3Rectangles(pe.Graphics);
        }

        private int[] getTextBoxInput()
        {
            int[] percentages = { 0, 0, 0 };
            try
            {
                try
                {
                    percentages[0] = int.Parse(txtIng1.Text);
                }
                catch (FormatException fex)
                {
                    MessageBox.Show("Error: Could not parse integer from Ingredient 1!\n" + fex.Message, "Format Error");
                    return null;
                }
                try
                {
                    percentages[1] = int.Parse(txtIng2.Text);
                }
                catch (FormatException fex)
                {
                    MessageBox.Show("Error: Could not parse integer from Ingredient 2!\n" + fex.Message, "Format Error");
                    return null;
                }
            }
            catch (OverflowException oex) //I trust my users to be responsible for this one instance - but I'll catch this anyway.
            {
                MessageBox.Show("Error : Integer too large!\n" + oex.Message, "Overflow Error");
                return null;
            }
            //Sanitize User input

            //First - cannot have negative numbers
            if (percentages[0] < 0 || percentages[1] < 0)
            {
                MessageBox.Show("Error : Percentages must be a positve number!", "Incorrect Input");
                return null;
            }
            //Next - check that we don't go over 100%
            if (percentages[0] + percentages[1] > 100)
            {
                MessageBox.Show("Error : The two percentages cannot be greater than 100!");
                return null;
            }

            //Calculate third portion
            percentages[2] = 100 - (percentages[0] + percentages[1]);
            return percentages;
        }

        /// <summary>
        /// Draws the the 3 rectangles that represent the percentages of the meter
        /// </summary>
        private void draw3Rectangles(Graphics graphics)
        {
            float cur_x = METER_START_X, cur_y = METER_START_Y;

            //graphics.Clear(Color.FromArgb(71, 69, 152));
            
            //Now draw each rectangle
            for (int i = 0; i < Percentages.Length; i++)
            {
                drawRectangleCooking((float)(.01 * Percentages[i] * METER_LENGTH), cur_x, cur_y, RECTANGLE_COLORS[i], graphics);
                //Update Current X
                cur_x += (float)(0.01 * Percentages[i] * METER_LENGTH);
            }
            lblTest.Text = "";
            for(int i = 0; i < Percentages.Length; i++) 
            {
                lblTest.Text += " - " + 0.01 * Percentages[i] * METER_LENGTH;
            }
            //Invalidate the region upon success
            /*Rectangle MeterRegion = new Rectangle(METER_START_X, METER_START_Y, METER_LENGTH, METER_HEIGHT);
            this.Invalidate(MeterRegion);*/
        }




        private void drawRectangleCooking(float length, float x, float y, Color colorType, Graphics graphics)
        {
            SolidBrush mainBrush = new SolidBrush(colorType);
            //Graphics formGraphics = this.CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.FillRectangle(mainBrush, new RectangleF(x, y, length, METER_HEIGHT));
            //formGraphics.Dispose();
            mainBrush.Dispose();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Percentages = getTextBoxInput();
            //pboxCMeter.Invalidate();
            //DrawRectangles = true;
            Invalidate();
        }
    }
}