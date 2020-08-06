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
        int vx = -10;
        int vy = -10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Location.X < 0)
            {
                vx = 10;
            }else if(label1.Location.X > 570)
            {
                vx = -10;
            }
            if (label1.Location.Y < 0)
            {
                vy = 10;
            }
            else if (label1.Location.Y > 340)
            {
                vy = -10;
            }
            label1.Left += vx;
            label1.Top += vy;
        }
    }
}
