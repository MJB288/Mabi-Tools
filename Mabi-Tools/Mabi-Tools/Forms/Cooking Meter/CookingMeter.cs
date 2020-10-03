using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabi_Tools.Forms.Cooking_Meter
{
    public partial class frmCooking : Form
    {
        private static readonly int METER_LENGTH = 200;
        private static readonly int METER_START_X = 49;
        private static readonly int METER_START_Y = 169;
        private static readonly int METER_HEIGHT = 5;
        private static readonly Color[] RECTANGLE_COLORS = { Color.Green, Color.Yellow, Color.Red };
        public frmCooking()
        {
            InitializeComponent();
        }

        private void frmCooking_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            draw3Rectangles();
        }

        /// <summary>
        /// Draws the the 3 rectangles that represent the percentages of the meter
        /// </summary>
        private void draw3Rectangles()
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
                    return;
                }
                try
                {
                    percentages[1] = int.Parse(txtIng2.Text);
                }
                catch (FormatException fex)
                {
                    MessageBox.Show("Error: Could not parse integer from Ingredient 2!\n" + fex.Message, "Format Error");
                    return;
                }
            }
            catch (OverflowException oex) //I trust my users to be responsible for this one instance - but I'll catch this anyway.
            {
                MessageBox.Show("Error : Integer too large!\n" + oex.Message, "Overflow Error");
                return;
            }
            //Sanitize User input

            //First - cannot have negative numbers
            if (percentages[0] < 0 || percentages[1] < 0)
            {
                MessageBox.Show("Error : Percentages must be a positve number!", "Incorrect Input");
                return;
            }
            //Next - check that we don't go over 100%
            if (percentages[0] + percentages[1] > 100)
            {
                MessageBox.Show("Error : The two percentages cannot be greater than 100!");
                return;
            }

            //Calculate third portion
            percentages[2] = 100 - (percentages[0] + percentages[1]);

            int cur_x = METER_START_X, cur_y = METER_START_Y;
            
            //Now draw each rectangle
            for (int i = 0; i < percentages.Length; i++)
            {
                drawRectangleCooking((int)Math.Round(.01 * percentages[i] * METER_LENGTH), cur_x, cur_y, RECTANGLE_COLORS[i]);
                //Update Current X
                cur_x += (int)Math.Round(0.01 * percentages[i] * METER_LENGTH);
            }
            lblTest.Text = "";
            for(int i = 0; i < percentages.Length; i++)
            {
                lblTest.Text += " - " + percentages[i];
            }

        }


        private void drawRectangleCooking(int length, int x, int y, Color colorType)
        {
            SolidBrush mainBrush = new SolidBrush(colorType);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(mainBrush, new Rectangle(x, y, length, METER_HEIGHT));
            formGraphics.Dispose();
            mainBrush.Dispose();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            draw3Rectangles();
        }
    }
}