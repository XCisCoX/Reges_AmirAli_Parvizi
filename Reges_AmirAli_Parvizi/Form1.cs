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
using System.Xml;

namespace Reges_AmirAli_Parvizi
{
    public partial class Form1 : Form
    {
        bool img = false;
        public Form1()
        {
            InitializeComponent();
        }
      static  OpenFileDialog open;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
         open =
                new OpenFileDialog();
            open.Filter = 
                "Images |*.png;*.jpg;*.bmp|Gif |*.gif";
            if(open.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation 
                    =
                    open.FileName;
                img = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("Login"))
            {


                if (txtPW.Text != txtRePw.Text)
                {
                    MessageBox.Show("پسورد ها با هم شباهت ندارند", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (!File.Exists(@"Login\" + txtUser.Text + ".xml"))
                {
                    XmlWriter xmlWriter = XmlWriter.Create(@"Login\" + txtUser.Text + ".xml");
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("AmirAli_PVZ");
                    xmlWriter.WriteStartElement("USER");
                    xmlWriter.WriteAttributeString("pw",txtRePw.Text);
                    xmlWriter.WriteAttributeString("fristname", txtLastname.Text);
                    xmlWriter.WriteAttributeString("lastname", txtname.Text);
                    xmlWriter.WriteAttributeString("username", txtUser.Text);
                    xmlWriter.WriteAttributeString("Coder", "CisCo_X");      
                    if(img==true)
                        File.Copy(open.FileName, @"Login\" + txtUser.Text + ".png");                 
                   
                    xmlWriter.WriteEndElement();
                    xmlWriter.Close();
                
                    Clipboard.Clear();
                    MessageBox.Show("با موفقیت ثبت شد لطفا وارد شوید", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("این نام کاربری از قبل انتخاب شده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                    return;
                }
          
            
            
            }
                else
                {
                MessageBox.Show("فولدر اصلی پیدا نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                    return;
                }

        }

        private void Form1_Load(object sender, EventArgs e)
        {  if (!Directory.Exists("Login"))
            Directory.CreateDirectory("Login");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSingIn frm = new frmSingIn(); frm.ShowDialog();
            this.Close();
           
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool btn = true;
        private void button4_Click(object sender, EventArgs e)
        {
           
            if (btn == true)
            {
                txtPW.PasswordChar = (char)0;
                txtRePw.PasswordChar = (char)0;
                btn = false;
            }
            else
            {
                txtPW.PasswordChar = '*';
                txtRePw.PasswordChar = '*';
                btn = true;
            }
        }
    }
}
