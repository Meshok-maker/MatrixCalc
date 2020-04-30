using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalc
{
    public partial class Form2 : Form
    {
        public int cols;
        public int rows;
        public Form2()
        {
            InitializeComponent();
        }
        public void ChangeCAndR(int c, int r)
        {
            if (r == 0 || c == 0)
            {
                numericUpDown1.Value = 1;
                numericUpDown2.Value = 1;
            }
            else
            {
                numericUpDown1.Value = r;
                numericUpDown2.Value = c;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rows = (int)numericUpDown1.Value;
            cols = (int)numericUpDown2.Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
