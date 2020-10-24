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
        private int METER_LENGTH = 229;
        private readonly int METER_START_X = 16;
        private readonly int METER_START_Y = 309;
        private readonly int METER_HEIGHT = 5;
        //Relatiive to the start of the guide
        private int GUIDE_BUTTON_X_OFFSET_LEFT = 28;
        private int GUIDE_BUTTON_X_OFFSET_RIGHT = 28;
        private int BUTTON_WIDTH = 69;

        private int[] Percentages = {30, 40, 30};
        private short GuideMode = Properties.Settings.Default.GuideMode; //0 = None ----- 1 = Edge ----- 2 = Button ----- 
        public frmCooking()
        {
            InitializeComponent();
            adjustbtnGuideText();
            //Import the user settings for the guide buttons
            adjustMeterMeasurements();
        }

        /// <summary>
        /// Imports the user settings for the cooking meter pixel measurements and adjusts the window length based off of meter length
        /// </summary>
        private void adjustMeterMeasurements()
        {
            GUIDE_BUTTON_X_OFFSET_LEFT = Properties.Settings.Default.CMGuideLeft;
            GUIDE_BUTTON_X_OFFSET_RIGHT = Properties.Settings.Default.CMGuideRight;
            BUTTON_WIDTH = Properties.Settings.Default.CMBtnWidth;
            METER_LENGTH = Properties.Settings.Default.CMeterLength;
            //Now add a check for form size
            if (METER_LENGTH >= 138)
            {
                this.Width = METER_LENGTH + 56;
            }
            else
            {
                this.Width = 194; //138 + 56
            }
            
        }

        /// <summary>
        /// Sets the window to double buffered, topmost and adds a paint event handler (frmCooking_Paint) to the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCooking_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.TopMost = true;
            this.Paint += frmCooking_Paint;
        }

        private void frmCooking_Paint(object sender, PaintEventArgs pe)
        {
            adjustMeterMeasurements();
            draw3Rectangles(pe.Graphics);
            //Determine which kind of lines to draw
            switch (GuideMode) 
            {
                //Don't draw lines for case 0
                case 1:
                    drawSupportingLinesEdge(pe.Graphics);
                    break;
                case 2:
                    drawSupportingLinesButton(pe.Graphics);
                    break;

            }
        }

        /// <summary>
        /// Processes user input in the two textboxes - checks those inputs for any errors and then calculates the third percentage. Returns null if input invalid
        /// </summary>
        /// <returns>Integer array with 3 percentages. Null if invalid input</returns>
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

            //Create a matching array from the user preferences
            Color[] userColors = { Properties.Settings.Default.CMColor1, Properties.Settings.Default.CMColor2, Properties.Settings.Default.CMColor3 };

            //Now draw each rectangle
            for (int i = 0; i < Percentages.Length; i++)
            {
                drawRectangleCooking((float)(.01 * Percentages[i] * METER_LENGTH), cur_x, cur_y, userColors[i], graphics);
                //Update Current X
                cur_x += (float)(0.01 * Percentages[i] * METER_LENGTH);
            }
        }

        /// <summary>
        /// Draws the lines for helping to align the meter with the Cooking UI. For the Edge guide mode.
        /// </summary>
        /// <param name="graphics">Graphics object to draw on</param>
        private void drawSupportingLinesEdge(Graphics graphics)
        {
            SolidBrush lineBrush = new SolidBrush(Properties.Settings.Default.CMGuideColor);
            Rectangle line1 = new Rectangle(METER_START_X - 1, METER_START_Y - 15, 1, 35);
            Rectangle line2 = new Rectangle(METER_LENGTH + METER_START_X, METER_START_Y - 15, 1, 35);
            graphics.FillRectangle(lineBrush, line1);
            graphics.FillRectangle(lineBrush, line2);
            lineBrush.Dispose();
        }
        /// <summary>
        /// Draws the lines for helping to align the meter with the Cooking UI. For the Button guide mode.
        /// </summary>
        /// <param name="graphics"></param>
        private void drawSupportingLinesButton(Graphics graphics)
        {
            SolidBrush lineBrush = new SolidBrush(Properties.Settings.Default.CMGuideColor);
            Rectangle LeftButton1 = new Rectangle(METER_START_X + GUIDE_BUTTON_X_OFFSET_LEFT, METER_START_Y + METER_HEIGHT, 1, 50);
            Rectangle LeftButton2 = new Rectangle(METER_START_X + GUIDE_BUTTON_X_OFFSET_LEFT + BUTTON_WIDTH + 1, METER_START_Y + METER_HEIGHT, 1, 50);
            Rectangle RightButton1 = new Rectangle(METER_LENGTH + METER_START_X - GUIDE_BUTTON_X_OFFSET_RIGHT - BUTTON_WIDTH - 1, METER_START_Y + METER_HEIGHT, 1, 50);
            Rectangle RightButton2 = new Rectangle(METER_LENGTH + METER_START_X - GUIDE_BUTTON_X_OFFSET_RIGHT - 1, METER_START_Y + METER_HEIGHT, 1, 50);
            graphics.FillRectangle(lineBrush, LeftButton1);
            graphics.FillRectangle(lineBrush, LeftButton2);
            graphics.FillRectangle(lineBrush, RightButton1);
            graphics.FillRectangle(lineBrush, RightButton2);
            lineBrush.Dispose();
        }

        /// <summary>
        /// Draws a portion of the cooking meter with the specified color using a RectangleF.
        /// </summary>
        /// <param name="length">Length of the Rectangle</param>
        /// <param name="x">Starting x coordinate</param>
        /// <param name="y">Starting y coordinate</param>
        /// <param name="colorType">Desired color of rectangle</param>
        /// <param name="graphics">Graphics object to paint it on</param>
        private void drawRectangleCooking(float length, float x, float y, Color colorType, Graphics graphics)
        {
            SolidBrush mainBrush = new SolidBrush(colorType);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.FillRectangle(mainBrush, new RectangleF(x, y, length, METER_HEIGHT));
            mainBrush.Dispose();
        }

        /// <summary>
        /// Adjusts the percentages based off of user input and if successful calls the paint events through Invalidate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int[] tempPercent = getTextBoxInput();
            //Check that return was not null
            if (tempPercent != null) {
                //Update the global values so that it now redraws the desired portion
                Percentages = tempPercent;
                Invalidate();
            }
        }

        /// <summary>
        /// Changes the Guide Mode being displayed to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuideMode_Click(object sender, EventArgs e)
        {
            //Increment
            GuideMode++;
            //Detect if it goes over the boundary of 2
            if(GuideMode >= 3)
            {
                GuideMode = 0;
            }
            //Adjust Button Text - Build with String Builder
            adjustbtnGuideText();
            //Save the setting so that it will show up exactly the same when the user rebbots
            Properties.Settings.Default.GuideMode = GuideMode;
            Properties.Settings.Default.Save();
            //Now draw the lines
            Invalidate();
        }

        /// <summary>
        /// Adjusts the text of the guide mode button to indicate which mode is selected
        /// </summary>
        private void adjustbtnGuideText()
        {
            StringBuilder newButtonText = new StringBuilder("Guide : ");
            switch (GuideMode)
            {
                case 0:
                    newButtonText.Append("None");
                    break;
                case 1:
                    newButtonText.Append("Edge");
                    break;
                case 2:
                    newButtonText.Append("Button");
                    break;
            }
            //Set the text
            btnGuideMode.Text = newButtonText.ToString();
        }
    }
}