using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilliPiyango
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int s1, s2, s3, s4, s5, s6, s7;

            s1 = rnd.Next(0, 10);
            s2 = rnd.Next(0, 10);
            s3 = rnd.Next(0, 10);
            s4 = rnd.Next(0, 10);
            s5 = rnd.Next(0, 10);
            s6 = rnd.Next(0, 10);
            s7 = rnd.Next(0, 10);

            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();
            label5.Text = s5.ToString();
            label6.Text = s6.ToString();
            label7.Text = s7.ToString();
        }
    }
}
