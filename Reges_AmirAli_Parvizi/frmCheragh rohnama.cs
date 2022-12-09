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
    public partial class frmCheragh_rohnama : Form
    {
        public frmCheragh_rohnama()
        {
            InitializeComponent();
        }
        static int tmr1 = 30;
        static int tmr2 = 5;
        static int tmr3 = 40;

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
   
    void Zrd()
        {
        sbz.BackColor = Color.FromArgb(0,100,0);
        zard.BackColor = Color.FromArgb(255, 255, 0);
        ghermez.BackColor = Color.FromArgb(100,0,0);
        times.ForeColor = Color.FromArgb(255,255,0);
     
        }
    void GHMZ()
    {
        sbz.BackColor = Color.FromArgb(0,100,0);
        zard.BackColor = Color.FromArgb(100, 100, 0);
        ghermez.BackColor = Color.FromArgb(255,0,0);
        times.ForeColor = Color.FromArgb(255,0,0);
     
    }
    void SaBZ()
    {
        sbz.BackColor = Color.FromArgb(0,255, 0);
        zard.BackColor = Color.FromArgb(100, 100, 0);
        ghermez.BackColor = Color.FromArgb(100, 0, 0);
        times.ForeColor = Color.FromArgb(0, 255, 0);
    
    }
        private void frmCheragh_rohnama_Load(object sender, EventArgs e)
        {
            mashinspeed.Text = mchin.Interval.ToString();
            cheraghspeed.Text = timer1.Interval.ToString();
            timer1.Enabled = true;
            mchin.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tmr1--;
            SaBZ();
            times.Text = tmr1.ToString();
          
            if (tmr1 == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
               
                tmr1=30;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            tmr2--;
            times.Text = tmr2.ToString();
            Zrd();
            if (tmr2 == 0)
            {
                timer3.Enabled = true;
                timer2.Enabled = false;
                tmr2 = 5;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            tmr3--;
            times.Text = tmr3.ToString();
            GHMZ();
            if (tmr3 == 0)
            {
                timer1.Enabled = true;
                timer3.Enabled = false;
                tmr3 = 40;
            }
        }

        private void mchin_Tick(object sender, EventArgs e)
        { 
            if (ghermez.BackColor == Color.FromArgb(255, 0, 0))
            {
               if(mashin.Top<260||mashin.Top>280)
               {
                   mashin.Top-=2;
               }
            }
            else
            {
                
                    mashin.Top-=2;
                
            }
            if(mashin.Top<0)
            {
                mashin.Top = 470;
            }
        }

        private void mashinspeed_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void cheraghspeed_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mashinspeed.Text == "")
                mashinspeed.Text = "1";
            int speeds = int.Parse(mashinspeed.Text);
            mchin.Interval = speeds;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cheraghspeed.Text == "")
                cheraghspeed.Text = "1";
            int speeds = int.Parse(cheraghspeed.Text);
            if (speeds == 0)
                speeds = 1;
            timer1.Interval = speeds; timer2.Interval = speeds; timer3.Interval = speeds;
        }
    }
}
