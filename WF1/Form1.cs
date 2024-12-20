using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void PTB2(int a, int b, int c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Nghiem3.Text = "Phương trình vô số nghiệm";
                    }
                    else
                    {
                        Nghiem3.Text = "Phương trình vô nghiệm";
                    }
                }
                else
                {
                    double x = -c / (double)b;
                    Nghiem3.Text = $"x = {x:F2}";
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Nghiem1.Text = $"x1 = {x1:F2}";
                    Nghiem2.Text = $"x2 = {x2:F2}";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Nghiem3.Text = $"x = {x:F2}";
                }
                else
                {
                    Nghiem3.Text = "Phương trình vô nghiệm";
                }
            }
        }

        private void kq_Click(object sender, EventArgs e)
        {
            int a1 = Convert.ToInt32(a.Text);
            int b1 = Convert.ToInt32(b.Text);
            int c1 = Convert.ToInt32(c.Text);
            PTB2(a1, b1, c1);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            a.Clear();
            b.Clear();
            c.Clear();
            Nghiem1.Text = "";
            Nghiem2.Text = "";
            Nghiem3.Text = "";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
