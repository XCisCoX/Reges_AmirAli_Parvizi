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
    public partial class frmTImer : Form
    {
        public frmTImer()
        {
            InitializeComponent();
        }
        int secound = 00;
        int minite = 00;
        int hourse = 00;

        private void button8_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog()
            ;         
           if(DialogResult.OK==fnt.ShowDialog())
           {
               r1.Font = fnt.Font;
               r2.Font = fnt.Font;
               s.Font = fnt.Font;
               h.Font = fnt.Font;
               m.Font = fnt.Font;
           }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog cl=new ColorDialog();
            if(DialogResult.OK==cl.ShowDialog())
            {
                r1.ForeColor = cl.Color;
                r2.ForeColor = cl.Color;
                s.ForeColor = cl.Color;
                h.ForeColor = cl.Color;
                m.ForeColor = cl.Color;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
         //   button1.Enabled = false;
        //    button3.Enabled = true;
            button4.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secound++;
            s.Text = secound.ToString();
            m.Text = minite.ToString();
            h.Text = hourse.ToString();
         
            if(secound==100)
            {
                secound = 0;
                minite++;
            }
            if(minite==60)
            {
                minite = 0;
                hourse ++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void frmTImer_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            secound
              = 0;
            hourse
                = 0;
            minite =
                0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn=new OpenFileDialog();
            if (DialogResult.OK == opn.ShowDialog())
            {

                string img = opn.FileName;
                this.BackgroundImage = Image.FromFile(img);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog(); cl.ShowDialog();
            BackColor = cl.Color;
            BackgroundImage = null;
        }
    }
}
