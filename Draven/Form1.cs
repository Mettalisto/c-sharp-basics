using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            timer1.Enabled = true;
            pictureBox1.Left = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 10;
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                a++;
                pictureBox1.Left = 0;
                label2.Text = a.ToString();
                if (a == 10)
                {
                    timer1.Enabled = false;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
