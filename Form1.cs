using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lift
{
    public partial class Form1 : Form
    {
        int k = 1; int j = 0; bool r;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Location = new Point(80, 240);
            timer1.Stop();
            timer2.Stop();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            r = false;
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            if (!r)
            {


                if (button3.ForeColor == Color.Red&& button2.ForeColor == Color.Black)
                {
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    timer1.Start();
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 3);
                    if (pictureBox1.Location.Y >= 240)
                    {
                        button3.ForeColor = Color.Black;
                        timer1.Stop();
                        k = 1;
                        pictureBox2.Visible = true;
                        r = true;
                        timer2.Start();
                    }
                }
                else if (k == 1 && button2.ForeColor == Color.Red && button1.ForeColor != Color.Red)
                {
                    pictureBox2.Visible = false;
                    pictureBox4.Visible = false;
                    timer1.Start();
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 3);
                    if (pictureBox1.Location.Y <= 130)
                    {
                        button2.ForeColor = Color.Black;
                        timer1.Stop();
                        k = 2;
                        pictureBox3.Visible = true;
                        r = true;
                        timer2.Start();
                    }
                }

                else if (k == 3 && button2.ForeColor == Color.Red)
                {
                    pictureBox2.Visible = false;
                    pictureBox4.Visible = false;
                    timer1.Start();
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 3);
                    if (pictureBox1.Location.Y >= 130)
                    {
                        button2.ForeColor = Color.Black;
                        timer1.Stop();
                        k = 2;
                        pictureBox3.Visible = true;
                        r = true;
                        timer2.Start();

                    }
                }
                else if (button1.ForeColor == Color.Red && k != 3)
                {


                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    timer1.Start();
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 3);
                    if (pictureBox1.Location.Y <= 26)
                    {
                        button1.ForeColor = Color.Black;
                        timer1.Stop();
                        k = 3;
                        pictureBox4.Visible = true;
                        r = true;
                        timer2.Start();
                    }
                }
            }
        }
    


        private void button2_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
            timer1.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Red;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (r)
            {
                j++;
                if (j == 50)
                {
                    r = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox4.Visible = false;
                    timer2.Stop();
                    j = 0;
                    timer1.Start();
                }
            }
        }
    }
}
