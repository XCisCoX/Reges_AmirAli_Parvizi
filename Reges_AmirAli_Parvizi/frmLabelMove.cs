using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reges_AmirAli_Parvizi
{
    public partial class frmLabelMove : Form
    {
        public frmLabelMove()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
        }
        bool up = true;
        bool down = false;
        bool right = true;
        bool left = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (up == true)
                label1.Top -= 5;
            if (down == true)
                label1.Top += 5;
            if (label1.Top < 26)
            {
                down = true; up = false;
            
            }
            if(label1.Top>296)
            {
                down =false; up = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //533
            //12
       
         
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (right == true)
                label1.Left -= 5;
            if (left == true)
                label1.Left += 5;
            if (label1.Left < 12)
            {
                left = true; right = false;

            }
            if (label1.Left > 533)
            {
                left = false; right = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer1.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer1.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog(); fnt.ShowDialog(); label1.Font = fnt.Font;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog(); cl.ShowDialog(); label1.ForeColor = cl.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog(); cl.ShowDialog(); label1.BackColor = cl.Color;
        }
    }
}
