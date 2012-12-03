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
    public partial class OptionBoxForm : Form
    {

        public OptionBoxForm()
        {
            InitializeComponent();
        }

        private void OptionBoxForm_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = MainForm.g_intPaperWidth.ToString();
            this.textBox2.Text = MainForm.g_intPaperHeight.ToString();
        }

        private void OptionBoxForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            int width = Convert.ToInt32(this.textBox1.Text);
            int height = Convert.ToInt32(this.textBox2.Text);
            if (width > 0 && width < 1200 && height > 0 && height <1200)
            {
                MainForm.g_intPaperWidth = width;
                MainForm.g_intPaperHeight = height;
            }
        }
    }
}
