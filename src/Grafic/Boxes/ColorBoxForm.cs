using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grafic.Boxes
{
    public partial class ColorBoxForm : Form
    {
        public static Color g_clrSelectedColor1;
        public static Color g_clrSelectedColor2;
        private Color[] m_clrColor=new Color[49];    //Color[1]~Color[48]

        public ColorBoxForm()
        {
            InitializeComponent();
        }

        private void ColorBoxForm_Load(object sender, EventArgs e)
        {
            //Setting the ComboBox
            this.cboFrontOrBack.SelectedIndex = 0;


            g_clrSelectedColor1 = Color.Black;
            g_clrSelectedColor2 = Color.Transparent;

            //Pareparing the colors using in the ColorBox
            //Black and White
            m_clrColor[1] = Color.Black;
            m_clrColor[13] = Color.DimGray;
            m_clrColor[25] = Color.Silver;
            m_clrColor[37] = Color.White;

            //Red
            m_clrColor[2] = Color.Red;
            m_clrColor[14] = Color.Firebrick;
            m_clrColor[26] = Color.DarkRed;
            m_clrColor[38] = Color.Brown;

            //Orange
            m_clrColor[3] = Color.Orange;
            m_clrColor[15] = Color.DarkOrange;
            m_clrColor[27] = Color.OrangeRed;
            m_clrColor[39] = Color.Chocolate;

            //Yellow
            m_clrColor[4] = Color.Yellow;
            m_clrColor[16] = Color.Gold;
            m_clrColor[28] = Color.DarkGoldenrod;
            m_clrColor[40] = Color.SaddleBrown;

            //Yellow-Green
            m_clrColor[5] = Color.GreenYellow;
            m_clrColor[17] = Color.Chartreuse;
            m_clrColor[29] = Color.YellowGreen;
            m_clrColor[41] = Color.ForestGreen;

            //Green
            m_clrColor[6] = Color.Lime;
            m_clrColor[18] = Color.LimeGreen;
            m_clrColor[30] = Color.Green;
            m_clrColor[42] = Color.DarkGreen;

            //Green-blue
            m_clrColor[7] = Color.MediumSpringGreen;
            m_clrColor[19] = Color.MediumAquamarine;
            m_clrColor[31] = Color.MediumSeaGreen;
            m_clrColor[43] = Color.LightSeaGreen;

            //Blue
            m_clrColor[8] = Color.Aqua;
            m_clrColor[20] = Color.DarkTurquoise;
            m_clrColor[32] = Color.DodgerBlue;
            m_clrColor[44] = Color.RoyalBlue;

            //Dark Blue
            m_clrColor[9] = Color.DeepSkyBlue;
            m_clrColor[21] = Color.Blue;
            m_clrColor[33] = Color.DarkBlue;
            m_clrColor[45] = Color.Navy;

            //Purple
            m_clrColor[10] = Color.Orchid;
            m_clrColor[22] = Color.DarkViolet;
            m_clrColor[34] = Color.Purple;
            m_clrColor[46] = Color.Indigo;

            //Pink
            m_clrColor[11] = Color.Pink;
            m_clrColor[23] = Color.Plum;
            m_clrColor[35] = Color.HotPink;
            m_clrColor[47] = Color.MediumVioletRed;

            //Purple-Red
            m_clrColor[12] = Color.DeepPink;
            m_clrColor[24] = Color.Crimson;
            m_clrColor[36] = Color.MediumVioletRed;
            m_clrColor[48] = Color.Maroon;







            picColor1.BackColor = m_clrColor[1];              //show the parepared colors
            picColor2.BackColor = m_clrColor[2];
            picColor3.BackColor = m_clrColor[3];
            picColor4.BackColor = m_clrColor[4];
            picColor5.BackColor = m_clrColor[5];
            picColor6.BackColor = m_clrColor[6];
            picColor7.BackColor = m_clrColor[7];
            picColor8.BackColor = m_clrColor[8];
            picColor9.BackColor = m_clrColor[9];
            picColor10.BackColor = m_clrColor[10];
            picColor11.BackColor = m_clrColor[11];
            picColor12.BackColor = m_clrColor[12];


            picColor13.BackColor = m_clrColor[13];
            picColor14.BackColor = m_clrColor[14];
            picColor15.BackColor = m_clrColor[15];
            picColor16.BackColor = m_clrColor[16];
            picColor17.BackColor = m_clrColor[17];
            picColor18.BackColor = m_clrColor[18];
            picColor19.BackColor = m_clrColor[19];
            picColor20.BackColor = m_clrColor[20];
            picColor21.BackColor = m_clrColor[21];
            picColor22.BackColor = m_clrColor[22];
            picColor23.BackColor = m_clrColor[23];
            picColor24.BackColor = m_clrColor[24];


            picColor25.BackColor = m_clrColor[25];
            picColor26.BackColor = m_clrColor[26];
            picColor27.BackColor = m_clrColor[27];
            picColor28.BackColor = m_clrColor[28];
            picColor29.BackColor = m_clrColor[29];
            picColor30.BackColor = m_clrColor[30];
            picColor31.BackColor = m_clrColor[31];
            picColor32.BackColor = m_clrColor[32];
            picColor33.BackColor = m_clrColor[33];
            picColor34.BackColor = m_clrColor[34];
            picColor35.BackColor = m_clrColor[35];
            picColor36.BackColor = m_clrColor[36];

            picColor37.BackColor = m_clrColor[37];
            picColor38.BackColor = m_clrColor[38];
            picColor39.BackColor = m_clrColor[39];
            picColor40.BackColor = m_clrColor[40];
            picColor41.BackColor = m_clrColor[41];
            picColor42.BackColor = m_clrColor[42];
            picColor43.BackColor = m_clrColor[43];
            picColor44.BackColor = m_clrColor[44];
            picColor45.BackColor = m_clrColor[45];
            picColor46.BackColor = m_clrColor[46];
            picColor47.BackColor = m_clrColor[47];
            picColor48.BackColor = m_clrColor[48];
        }

        private void ColorForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ColorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();         //hide the form when you close it
            MainForm.g_blColorBoxIsShow = false;    
        }

        private void ColorBoxForm_Paint(object sender, PaintEventArgs e)
        {

            picColorSelected1.BackColor = g_clrSelectedColor1;
            picColorSelected2.BackColor = g_clrSelectedColor2;
        }

        #region OnClick Operations

        private void picColorSelected1_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                g_clrSelectedColor1 = colorDialog1.Color;
                this.Invalidate();
            }
        }

        private void picColorSelected2_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                g_clrSelectedColor2 = colorDialog1.Color;
                this.Invalidate();
            }
        }

        private void picBlackAndTransparent_Click(object sender, EventArgs e)
        {
            g_clrSelectedColor1 = Color.Black;
            g_clrSelectedColor2 = Color.Transparent;
            this.Invalidate();
        }

        private void picColor1_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[1];
            }
            else if (this.cboFrontOrBack.SelectedIndex==1)
            {
                g_clrSelectedColor2 = m_clrColor[1];
            }
            this.Invalidate();
        }

        private void picColor2_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[2];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[2];
            }
            this.Invalidate();
        }

        private void picColor3_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[3];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[3];
            }
            this.Invalidate();
        }

        private void picColor4_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[4];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[4];
            }
            this.Invalidate();
        }

        private void picColor5_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[5];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[5];
            }
            this.Invalidate();
        }

        private void picColor6_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[6];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[6];
            }
            this.Invalidate();
        }

        private void picColor7_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[7];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[7];
            }
            this.Invalidate();
        }

        private void picColor8_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[8];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[8];
            }
            this.Invalidate();
        }

        private void picColor9_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[9];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[9];
            }
            this.Invalidate();
        }

        private void picColor10_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[10];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[10];
            }
            this.Invalidate();
        }

        private void picColor11_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[11];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[11];
            }
            this.Invalidate();
        }

        private void picColor12_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[12];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[12];
            }
            this.Invalidate();
        }

        private void picColor13_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[13];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[13];
            }
            this.Invalidate();
        }

        private void picColor14_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[14];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[14];
            }
            this.Invalidate();
        }

        private void picColor15_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[15];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[15];
            }
            this.Invalidate();
        }

        private void picColor16_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[16];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[16];
            }
            this.Invalidate();
        }

        private void picColor17_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[17];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[17];
            }
            this.Invalidate();
        }

        private void picColor18_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[18];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[18];
            }
            this.Invalidate();
        }

        private void picColor19_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[19];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[19];
            }
            this.Invalidate();
        }

        private void picColor20_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[20];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[20];
            }
            this.Invalidate();
        }

        private void picColor21_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[21];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[21];
            }
            this.Invalidate();
        }

        private void picColor22_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[22];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[22];
            }
            this.Invalidate();
        }

        private void picColor23_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[23];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[23];
            }
            this.Invalidate();
        }

        private void picColor24_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[24];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[24];
            }
            this.Invalidate();
        }

        private void picColor25_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[25];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[25];
            }
            this.Invalidate();
        }

        private void picColor26_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[26];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[26];
            }
            this.Invalidate();
        }

        private void picColor27_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[27];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[27];
            }
            this.Invalidate();
        }

        private void picColor28_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[28];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[28];
            }
            this.Invalidate();
        }

        private void picColor29_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[29];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[29];
            }
            this.Invalidate();
        }

        private void picColor30_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[30];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[30];
            }
            this.Invalidate();
        }

        private void picColor31_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[31];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[31];
            }
            this.Invalidate();
        }

        private void picColor32_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[32];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[32];
            }
            this.Invalidate();
        }

        private void picColor33_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[33];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[33];
            }
            this.Invalidate();
        }

        private void picColor34_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[34];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[34];
            }
            this.Invalidate();
        }

        private void picColor35_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[35];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[35];
            }
            this.Invalidate();
        }

        private void picColor36_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[36];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[36];
            }
            this.Invalidate();
        }

        private void picColor37_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[37];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[37];
            }
            this.Invalidate();
        }

        private void picColor38_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[38];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[38];
            }
            this.Invalidate();
        }

        private void picColor39_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[39];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[39];
            }
            this.Invalidate();
        }

        private void picColor40_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[40];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[40];
            }
            this.Invalidate();
        }

        private void picColor41_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[41];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[41];
            }
            this.Invalidate();
        }

        private void picColor42_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[42];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[42];
            }
            this.Invalidate();
        }

        private void picColor43_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[43];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[43];
            }
            this.Invalidate();
        }

        private void picColor44_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[44];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[44];
            }
            this.Invalidate();
        }

        private void picColor45_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[45];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[45];
            }
            this.Invalidate();
        }

        private void picColor46_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[46];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[46];
            }
            this.Invalidate();
        }

        private void picColor47_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[47];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[47];
            }
            this.Invalidate();
        }

        private void picColor48_Click(object sender, EventArgs e)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = m_clrColor[48];
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = m_clrColor[48];
            }
            this.Invalidate();
        }

        #endregion

        public void PickColor(Color c)
        {
            if (this.cboFrontOrBack.SelectedIndex == 0)
            {
                g_clrSelectedColor1 = c;
            }
            else if (this.cboFrontOrBack.SelectedIndex == 1)
            {
                g_clrSelectedColor2 = c;
            }
            this.Invalidate();
        }

    }
}
