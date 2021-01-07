using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeorgiApostolovConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            if (numericUpDown1.Value==0)
            {
                label2.Text = "";
            }
            else
            {
                var eur = this.numericUpDown1.Value;
                var bgn = eur * 1.95583m;
                label2.Text = eur + "EUR =" + Math.Round(bgn, 2) + "BGN ";
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value==0)
            {
                label4.Text = "";
            }
            else
            {
                var bgn2 = this.numericUpDown2.Value;
                var eur2 = bgn2 / 1.95583m;
                label4.Text = bgn2 + " BGN = " + Math.Round(eur2, 2) + "EUR";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = 0;
            label4.Text = "";
        }

       

    }
}
