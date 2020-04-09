using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Graphics graphics;
        //int angle1 = 30;
        //int angle2 = 20;
        double th1 =30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        int n = 1;

        Pen color=Pens.Black;
        double Leng=100;
        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = panel1.CreateGraphics();
            
            drawCayleyTree(n, 200, 310, Leng, -Math.PI / 2);
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            n=hScrollBar1.Value;
            label1.Text = "深度:" + n;
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            
            graphics.DrawLine(color, (int)x0, (int)y0, (int)x1, (int)y1);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                color = Pens.Black;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                color = Pens.Red;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                color = Pens.Blue;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
        //void setValue(string str,bool isInt)
        //{

        //}
        private void hSB1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hSB1.Value.ToString();
            Leng = hSB1.Value;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(textBox1.Text, out int a))
            {
                hSB1.Value = 100;
                Leng = 100;
                textBox1.Text = "輸入錯誤";
            }
            else
            {
                if (a > 150)
                {
                    hSB1.Value = 100;
                    Leng = 100;
                    textBox1.Text= "輸入錯誤";
                }
                else
                {
                    hSB1.Value = a;
                    Leng = a;
                }
                
            }
        }
        private void per1Bar_Scroll(object sender, ScrollEventArgs e)
        {
            per1textBox2.Text = (per1Bar.Value).ToString();
            per1 = (per1Bar.Value) / 10.0;
        }
        private void per2Bar_Scroll(object sender, ScrollEventArgs e)
        {
            per2textBox3.Text = (per2Bar.Value).ToString();
            per2 = (per1Bar.Value) / 10.0;
        }
        private void per1textBox2_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(per1textBox2.Text,out int a))
            {
                per1Bar.Value = 6;
                per1 = 0.6;
                per1textBox2.Text= "輸入錯誤";

            }
            else
            {
                if (a == 0 || a > 10)
                {
                    per1Bar.Value = 6;
                    per1 = 0.6;
                    per1textBox2.Text= "輸入錯誤";
                }
                else
                {
                    per1Bar.Value =a;
                    per1 = a/10.0;
                }
            }
        }
        private void per2textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(per1textBox2.Text, out int a))
            {
                per2Bar.Value =7;
                per1 = 0.7;
                per1textBox2.Text = "輸入錯誤";

            }
            else
            {
                if (a == 0 || a > 10)
                {
                    per2Bar.Value = 7;
                    per1 = 0.7;
                    per1textBox2.Text = "輸入錯誤";
                }
                else
                {
                    per1Bar.Value =a;
                    per1 = a / 10.0;
                }
            }
        }

        private void th1Bar_Scroll(object sender, ScrollEventArgs e)
        {
            th1textBox.Text = th1Bar.Value.ToString();
            th1= th1Bar.Value * Math.PI / 180;
        }

        private void th2Bar_Scroll(object sender, ScrollEventArgs e)
        {
            th2textBox.Text = th2Bar.Value.ToString();
            th2 = th2Bar.Value * Math.PI / 180;
        }

        private void th1textBox_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(th1textBox.Text,out int a))
            {
                th1= 30 * Math.PI / 180;
                th1Bar.Value = 30;
                th1textBox.Text = "輸入錯誤";
            }
            else
            {
                if (a > 360)
                {
                    th1 = 30 * Math.PI / 180;
                    th1Bar.Value = 30;
                    th1textBox.Text = "輸入錯誤";
                }
                else
                {
                    th1 =a * Math.PI / 180;
                    th1Bar.Value = a;
                }
            }
        }

        private void th2textBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(th2textBox.Text, out int a))
            {
                th2 = 20 * Math.PI / 180;
                th2Bar.Value = 20;
                th2textBox.Text = "輸入錯誤";
            }
            else
            {
                if (a > 360)
                {
                    th2 = 20 * Math.PI / 180;
                    th2Bar.Value = 20;
                    th2textBox.Text = "輸入錯誤";
                }
                else
                {
                    th2 = a * Math.PI / 180;
                    th2Bar.Value = a;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (this.progressBar1.Value < this.progressBar1.Maximum - 10)
            //{
            //    this.progressBar1.Value = this.progressBar1.Value+10;
            //}
            //else
            //{
            //    this.progressBar1.Value = this.progressBar1.Minimum;
            //}
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.timer1.Start();
        }
    }
}
