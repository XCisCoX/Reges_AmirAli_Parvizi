using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reges_AmirAli_Parvizi
{
    public partial class frmSingIn : Form
    {
        public frmSingIn()
        {
            InitializeComponent();
        }
        static public string LNAMEl = "";
        static public string PWl = "";
        static public string FNAME1 = "";
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void frmSingIn_Load(object sender, EventArgs e)
        {

        }

        private void ctlModernBlack1_Load(object sender, EventArgs e)
        {

        }
        public string frname = "";public string lastname = "";
        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Login\" + txtUser1.Text + ".xml"))
            {
                StreamReader read = new StreamReader(@"Login\" + txtUser1.Text + ".xml");
                string reads = read.ReadToEnd();
                read.Close();
                MatchCollection lname = Regex.Matches(reads, "lastname=\"(.+?)\"");
                MatchCollection pw1 = Regex.Matches(reads, "pw=\"(.+?)\"");
                MatchCollection fname = Regex.Matches(reads, "fristname=\"(.+?)\"");

                foreach (Match m in lname)
                {
                    LNAMEl = m.Groups[1].Value.ToString();
                }

                foreach (Match m in pw1)
                {
                    PWl = m.Groups[1].Value.ToString();
                }
                foreach (Match m in fname)
                {
                    FNAME1 = m.Groups[1].Value.ToString();
                }
                if (PWl == txtPW1.Text)
                {
                    frname = LNAMEl;
                   lastname = FNAME1;
                    LBLnm.Text = "Welcome [" + LNAMEl + " " + FNAME1 + "] !";
                    if (File.Exists(@"Login\" + txtUser1.Text + ".png"))
                    pictureBox2.ImageLocation = @"Login\" + txtUser1.Text + ".png";
                    button4.Visible = false;
                    button5.Visible= false;
                    txtPW1.Visible = false;
                    txtUser1.Visible = false;
                   
                    button8.Visible = true;
                    button14.Visible = true;
                    label3.Visible = false;
                    button10.Visible = true;
                    label4.Visible = false;
                    button12.Visible = true;
                    button13.Visible = true;
                    button9.Visible = true;
                    button6.Visible = true;
                    button11.Visible = true;
                    button7.Visible = true;
                }
                else
                {
                    MessageBox.Show("پسورد شما اشتباه میباشد!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("!این نام کاربری وجود ندارد", "", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();Form1 frm = new Form1(); frm.ShowDialog(); this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Login\" + txtUser1.Text + ".png"))
                File.Delete(@"Login\" + txtUser1.Text + ".png");
            File.Delete(@"Login\" + txtUser1.Text + ".xml");
            this.Hide(); Form1 frm = new Form1(); frm.ShowDialog(); this.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Game gm = new Game(); gm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmTImer frm = new frmTImer(); frm.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.0; frmCheragh_rohnama frm = new frmCheragh_rohnama(); frm.ShowDialog(); this.Opacity = 1;
        }

        private void frmSingIn_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmLabelMove frm = new frmLabelMove(); frm.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide(); Form1 frm = new Form1(); frm.ShowDialog(); this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();Riazi frmw = new Riazi();
            frmw.lblFristname.Text = frname ;
            frmw.lblLastname.Text = lastname;
            frmw.pictureBox1.Image = pictureBox2.Image;
            frmw.ShowDialog(); this.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
          MashinHesab frm = new MashinHesab(); frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide(); PictureAndShower frm = new PictureAndShower(); frm.ShowDialog(); this.Show();
        }
    }
}
