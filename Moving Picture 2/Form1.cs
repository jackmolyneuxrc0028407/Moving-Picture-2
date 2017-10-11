using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving_Picture_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            while (pictureBox1.Location.X + 50 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 50, pictureBox1.Location.Y);
                await Task.Delay(500);
                //pictureBox1.Location = new Point(pictureBox1.Location.X - 175, pictureBox1.Location.Y - 200);
                //await Task.Delay(500);
                //pictureBox1.Location = new Point(pictureBox1.Location.X - 175, pictureBox1.Location.Y + 200);
                //await Task.Delay(500);
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            while (pictureBox1.Location.X > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 50, pictureBox1.Location.Y);
                await Task.Delay(500);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            while (pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 50);
                await Task.Delay(500);
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            while (pictureBox1.Location.Y + 50 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 50);
                await Task.Delay(500);
            }
        }
    }
}

