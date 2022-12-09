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
    public partial class Riazi : Form
    {
        int EMTIAZ=0;
        public Riazi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            t1.Enabled = true;
            button1.Enabled = false;
            txtJJ.ReadOnly = false;
            txtJM.ReadOnly = false;
            txtJT.ReadOnly = false;
            txtJX.ReadOnly = false;
            button1.Text = "در حال آزمون...";
            timer1.Enabled = true;
         
        }
        int timers = 20;
        private void t1_Tick(object sender, EventArgs e)
        {
            timers--;
            TMR.Text = timers.ToString();
            if(timers==0)
            {
                t1.Enabled = false;
                txtJJ.ReadOnly = true;
                txtJM.ReadOnly = true;
                txtJT.ReadOnly = true;
                txtJX.ReadOnly = true;
                timers = 20;
                int x11 = int.Parse(lblX1.Text); int x22 = int.Parse(lblX2.Text);
                int m11 = int.Parse(lblM1.Text); int m22 = int.Parse(lblM2.Text);
                int j11 = int.Parse(lblJ1.Text); int j22 = int.Parse(lblJ2.Text);
                int t11 = int.Parse(lblT1.Text); int t22 = int.Parse(lblT2.Text);
                int Jm = m11 - m22;
                int Jj = j11 + j22;
                int Jx = x11 * x22;
                int Jt = t11 / t22;
                txtJJ.ReadOnly = false;
                txtJM.ReadOnly = false;
                txtJT.ReadOnly = false;
                txtJX.ReadOnly = false;
              
                if (txtJX.Text == string.Empty)
                {
                    txtJX.BackColor = Color.Yellow;
                    lblEx.Text = " بدون تغییر در امتیاز";
                    EMTIAZ += 0;
                }

                if (txtJM.Text==Jm.ToString())
                {
                    txtJM.BackColor = Color.Green;
                  lblEM.Text = " افزایش 5 امتیاز";
                    EMTIAZ += 5;
                }
                else
                {
                    if (txtJM.Text == string.Empty)
                    {
                        txtJM.BackColor = Color.Yellow; lblEj.Text = " بدون تغییر در امتیاز";

                    }
                    else
                    {
                        txtJM.BackColor = Color.Red;
                        lblEM.Text = "کاهش 5 امتیاز";
                        EMTIAZ -= 5;
                    }
                }
                if (txtJT.Text == Jt.ToString())
                {
                    txtJT.BackColor = Color.Green;
                    lblEt.Text = " افزایش 5 امتیاز";
                    EMTIAZ += 5;
                }
                else
                {
                    if (txtJT.Text == string.Empty)
                    {
                        txtJT.BackColor = Color.Yellow;
                        lblEt.Text = " بدون تغییر در امتیاز";

                    }
                    else
                    {
                        txtJT.BackColor = Color.Red;
                        lblEt.Text = "کاهش 5 امتیاز";
                        EMTIAZ -= 5;
                    }
                }
                if (txtJJ.Text == Jj.ToString())
                {
                    txtJJ.BackColor = Color.Green;
                    lblEj.Text = " افزایش 5 امتیاز";
                    EMTIAZ += 5;
                }
                else
                {
                    txtJJ.BackColor = Color.Red;
                    lblEj.Text = "کاهش 5 امتیاز";
                    EMTIAZ -= 5;
                }
                if (txtJX.Text == Jx.ToString())
                {
                    txtJX.BackColor = Color.Green;
                    lblEx.Text = " افزایش 5 امتیاز";
                    EMTIAZ += 5;
                }
                else
                {
                    if (txtJX.Text == string.Empty)
                    {
                        txtJX.BackColor = Color.Yellow; lblEx.Text = " بدون تغییر در امتیاز";
                    }
                    else
                    {
                        txtJX.BackColor = Color.Red;
                        lblEx.Text = "کاهش 5 امتیاز";
                        EMTIAZ -= 5;
                    }
                }
           
                
              
      
                button1.Enabled = true;
                button1.Text = "شروع آزمون";
            }
            lblME.Text = "امتیازات گرفته شده :" + EMTIAZ.ToString(); ;
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
            {
                Random X11 = new Random();
                lblX1.Text = X11.Next(0, 10).ToString();
            }
            if (i == 2)
            {
                Random X22 = new Random();
                lblX2.Text = X22.Next(0, 10).ToString();
            }
            if (i == 3)
            {
                Random J11 = new Random();
                lblJ1.Text = J11.Next(0, 10).ToString();
            }
            if (i == 4)
            {
                Random J22 = new Random();
                lblJ2.Text = J22.Next(0, 10).ToString();
            }
            if (i == 5)
            {
                Random M11 = new Random();
                lblM1.Text = M11.Next(0, 10).ToString();
            }
            if (i == 6)
            {
                Random M22 = new Random();
                lblM2.Text = M22.Next(0, 10).ToString();
               
             
            }
            if (i == 7)
            {
                Random T22 = new Random();
                lblT2.Text = T22.Next(1, 13).ToString();
          
            }
            if (i == 8)
            {
                Random T11 = new Random();
               
                lblT1.Text = T11.Next(10, 30).ToString();
                
                i = 0;
                timer1.Enabled = false;
            }
            //  
        }

        private void ctlModernBlack1_Load(object sender, EventArgs e)
        {

        }

        private void koli_Tick(object sender, EventArgs e)
        {
            Socre.Text = EMTIAZ.ToString();
        }
    }
}
