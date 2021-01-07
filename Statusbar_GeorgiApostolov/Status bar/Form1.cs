namespace Status_bar
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            labelValue.Text = numericUpDown1.Value.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)numericUpDown1.Value;

            toolStripProgressBar1.Value = value;
            labelValue.Text = numericUpDown1.Value.ToString();

            if (value <= 19 || value > 40)
            {
                typeLabel.Text = "Критична стойност!";
                labelValue.BackColor = Color.Red;
            }
            else if(labelValue.BackColor != Color.Blue)
            {
                typeLabel.Text = "Нормална стойност!";
                labelValue.BackColor = Color.Blue;
            }
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void labelValue_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
