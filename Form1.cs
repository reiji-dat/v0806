using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0806
{
    public partial class Form1 : Form
    {
        float vx = -10;
        float vy = -10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += (int)vx;
            label1.Top += (int)vy;
            if (label1.Left < 0)
            {
                vx = Math.Abs(vx) * 1.1f;
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx) * 1.1f;
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy) * 1.1f;
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy) * 1.1f;
            }  
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("幅" + ClientSize.Width);
            //MessageBox.Show("高さ" + ClientSize.Height);
        }
    }
}
