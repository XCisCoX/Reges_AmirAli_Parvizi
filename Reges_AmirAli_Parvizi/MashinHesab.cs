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
    public partial class MashinHesab : Form
    {
        public MashinHesab()
        {
            InitializeComponent();
        }
        string textboxe = "0";
        int model = 0;


        /*
         if Model == 1 jam mishe
         if Model == 2 menha mishe
         if Model == 3 Zarb mishe
         if Model == 4 taghsim 
         if Model == 5 Baghi mande
         if Model == 6 tavan
         */
        private void button5_Click(object sender, EventArgs e)
        {
            if(button5.Text=="0")
            {
                textBox1.Text = "1";
                textboxe = textBox1.Text;
            }
            else
            {
                textBox1.Text += "1";
                textboxe = textBox1.Text;
        
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button5.Text == "0")
            {
                textBox1.Text = "2"; textboxe = textBox1.Text;
              
            }
            else
            {
                textBox1.Text += "2"; textboxe = textBox1.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button5.Text == "0")
            {
                textBox1.Text = "3"; textboxe = textBox1.Text;
              
            }
            else
            {
                textBox1.Text += "3"; textboxe = textBox1.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button5.Text == "0")
            {
                textBox1.Text = "4"; textboxe = textBox1.Text;
                
            }
            else
            {
                textBox1.Text += "4"; textboxe = textBox1.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                textBox1.Text = "4"; textboxe = textBox1.Text;
            }
            else
            {
                textBox1.Text += "4"; textboxe = textBox1.Text;
               
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                textBox1.Text = "6"; textboxe = textBox1.Text;
            }
            else
            {
                textBox1.Text += "6"; textboxe = textBox1.Text;
               
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                textBox1.Text = "7"; textboxe = textBox1.Text;
              
            }
            else
            {
                textBox1.Text += "7"; textboxe = textBox1.Text;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button5.Text== "")
            {
                textBox1.Text = "8"; textboxe = textBox1.Text;
            }
            else
            {
                textBox1.Text += "8"; textboxe = textBox1.Text;
               
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
              
                textBox1.Text = "9"; textboxe = textBox1.Text;
            }
            else
            {
                textBox1.Text += "9"; textboxe = textBox1.Text;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                textBox1.Text = "0"; textboxe = textBox1.Text;
            }
            else
            {
textBox1.Text += "0"; textboxe = textBox1.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int textlength = textBox1.Text.Length;
            if (textlength > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textlength - 1);
                textboxe = textBox1.Text;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double x,total;
            total = double.Parse(textBox1.Text);
            x = Math.Sin(3.14 * total / 180);
            textBox1.Text = x.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x,total;
            total = double.Parse(textBox1.Text);
            x = Math.Cos(3.14 * total / 180);
            textBox1.Text = x.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            btnCos.Enabled = true;
            BtnJ.Enabled = true;
            btnM.Enabled = true; btnZ.Enabled = true;
            btnMaghsom.Enabled = true;
            btnSIn.Enabled = true;
            btnTaghsim.Enabled = true;
            btnTavan.Enabled = true;
            textboxe = "0";
            textBox1.Text = "";
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            btnCos.Enabled = false;
            BtnJ.Enabled = false;
            btnM.Enabled = false; btnZ.Enabled = false;
            btnMaghsom.Enabled = false;
            btnSIn.Enabled = false;
            btnTaghsim.Enabled = false;
            btnTavan.Enabled = false;
            label1.Text = textBox1.Text;textBox1.Clear();
            model = 3;   
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            btnCos.Enabled = false;
            BtnJ.Enabled = false;
            btnM.Enabled = false; btnZ.Enabled = false;
            btnMaghsom.Enabled = false;
            btnSIn.Enabled = false;
            btnTaghsim.Enabled = false;
            btnTavan.Enabled = false;
            model = 2; label1.Text = textBox1.Text; textBox1.Clear();
        }

        private void BtnJ_Click(object sender, EventArgs e)
        {
            btnCos.Enabled = false;
            btnZ.Enabled = false;
            btnMaghsom.Enabled = false;
            BtnJ.Enabled = false;
            btnM.Enabled = false;
            btnSIn.Enabled = false;
            btnTaghsim.Enabled = false;
            btnTavan.Enabled = false;
            model = 1; label1.Text = textBox1.Text; textBox1.Clear();
        }

        private void btnTavan_Click(object sender, EventArgs e)
        {
            btnCos.Enabled = false;
            BtnJ.Enabled = false;
            btnM.Enabled = false;
            btnSIn.Enabled = false;
            btnTaghsim.Enabled = false;
            btnTavan.Enabled = false;
            model = 
                6;
            label1.Text = textBox1.Text; textBox1.Clear();
        }

        private void btnMaghsom_Click(object sender, EventArgs e)
        {
            btnCos.Enabled = false;
            BtnJ.Enabled = false;
            btnM.Enabled = false; btnZ.Enabled = false;
            btnMaghsom.Enabled = false;
            btnSIn.Enabled = false;
            btnTaghsim.Enabled = false;
            btnTavan.Enabled = false;
            model = 5; label1.Text = textBox1.Text;textBox1.Clear();
        }

        private void btnTaghsim_Click(object sender, EventArgs e)
        {
            btnCos.Enabled = false;
            BtnJ.Enabled = false;
            btnM.Enabled = false; btnZ.Enabled = false;
            btnMaghsom.Enabled = false;
            btnSIn.Enabled = false;
            btnTaghsim.Enabled = false;
            btnTavan.Enabled = false;
            model = 4; label1.Text = textBox1.Text; textBox1.Clear();
        }

        private void btnMosavi_Click(object sender, EventArgs e)
        {
            btnCos.Enabled = true;
            BtnJ.Enabled = true;
            btnM.Enabled = true; btnZ.Enabled = true;
            btnMaghsom.Enabled = true;
            btnSIn.Enabled = true;
            btnTaghsim.Enabled = true;
            btnTavan.Enabled = true;
            if(model==1)
            {
                int jm2 = int.Parse(textBox1.Text);
                int jm1 = int.Parse(label1.Text);
                int javab = jm1 + jm2;
                textBox1.Text = javab.ToString();
                label1.Text = jm1.ToString() + "+" + jm2.ToString() + "=" + javab.ToString();
            }
            if(model==2)
            {
                int jm2 = int.Parse(textBox1.Text);
                int jm1 = int.Parse(label1.Text);
                int javab = jm1- jm2;
                textBox1.Text = javab.ToString();
                label1.Text = jm1.ToString() + "+" + jm2.ToString() + "=" + javab.ToString();
            }
            if(model==3)
            {
                int jm2 = int.Parse(textBox1.Text);
                int jm1 = int.Parse(label1.Text);
                int javab = jm1 * jm2;
                textBox1.Text = javab.ToString();
                label1.Text = jm1.ToString() + "+" + jm2.ToString() + "=" + javab.ToString();
            }
            if(model==4)
            {
                int jm2 = int.Parse(textBox1.Text);
                int jm1 = int.Parse(label1.Text);
                int javab = jm1/ jm2;
                textBox1.Text = javab.ToString();
                label1.Text = jm1.ToString() + "+" + jm2.ToString() + "=" + javab.ToString();
            }
            if(model==5)
            {
                int jm2 = int.Parse(textBox1.Text);
                int jm1 = int.Parse(label1.Text);
                int javab = jm1 % jm2;
                textBox1.Text = javab.ToString();
                label1.Text = jm1.ToString() + "+" + jm2.ToString() + "=" + javab.ToString();
            }
            if(model==6)
            {
                int jm2 = int.Parse(textBox1.Text);
                int jm1 = int.Parse(label1.Text);
                int javab = jm1 ^ jm2;
                textBox1.Text = javab.ToString();
                label1.Text = jm1.ToString() + "+" + jm2.ToString() + "=" + javab.ToString();
            }
        }
    }
}
