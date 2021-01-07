using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeorgiApostolov
{
    public partial class Form1 : Form
    {
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;  // широчина на екрана
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;  // височина на екрана

        public Form1()
        {
            this.TopMost = true;  // това е винаги формата да е отгоре
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");  // стартира notepad 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");  // стартира calculator
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string directory = Directory.GetParent(Environment.CurrentDirectory).ToString();  // взима текущата директория
            string lolPro = Path.GetFullPath(Path.Combine(directory, @"..\LOLPRO"));  // намира папката LOLPRO
            Process.Start(lolPro + @"\lolpro.exe");  // стартира lolpro
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string directory = Directory.GetParent(Environment.CurrentDirectory).ToString();  // взима текущата директория
            string game = Path.GetFullPath(Path.Combine(directory, @"..\GAME"));  // намира папката GAME
            Process.Start(game + @"\New Unity Project.exe");  // стартира New Unity Project
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string directory = Directory.GetParent(Environment.CurrentDirectory).ToString();  // взима текущата директория
            string love = Path.GetFullPath(Path.Combine(directory, @"..\LOVE"));  // намира папката LOVE
            Process.Start(love + @"\loveprocentform.exe");  // стартира loveprocentform
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);  // мести формата горе-ляво
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, screenHeight - this.Size.Height - 40);  // мести формата долу-ляво
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Location = new Point((screenWidth - this.Size.Width)/2, (screenHeight - this.Size.Height - 40)/2);  // мести формата в средата
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Location = new Point(screenWidth - this.Size.Width, 0);  // мести формата горе-дясно
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Location = new Point(screenWidth - this.Size.Width, screenHeight - this.Size.Height - 40);  // мести формата долу-дясно
        }



        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();  // затваря програмата
        }
    }
}
