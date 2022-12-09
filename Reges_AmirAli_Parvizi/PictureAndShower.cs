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
    public partial class PictureAndShower : Form
    {
        public PictureAndShower()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = L2.SelectedItem.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {           
                if (textBox1.Text != "")
                {
                    L1.Items.Add(textBox1.Text);
                }              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                L2.Items.Add(L1.SelectedItem);
                L1.Items.Remove(L1.SelectedItem);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select Item!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(L1.Items.Count.ToString()!="0")
                try
                {
                    foreach (var item in L1.Items)
                    {
                        
                        L2.Items.Add(item);
                    }
                    L1.Items.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("You Not Have Item In This List!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (L2.Items.Count.ToString() != "0")
                foreach (var item in L2.Items)
                {
                   
                    L1.Items.Add(item); 
                }
            L2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Pictures(Picture File) |*.png;*.bmp;*.jpg";
            if(DialogResult.OK==op.ShowDialog())
            {
                textBox1.Text = op.FileName;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(textBox2.Text!="")
            {
                axWindowsMediaPlayer1.URL = textBox2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (L2.Items.Count.ToString() != "0")
            {
                try { 
                L1.Items.Add(L2.SelectedItem); L2.Items.Remove(L2.SelectedItem);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select Item!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Players (Players File) |*.avi;*.mp3;*.mp4";
            if (DialogResult.OK == op.ShowDialog())
            {
                textBox2.Text = op.FileName;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try { 
            L1.Items.Remove(L1.SelectedItem);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Select Item!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            L1.Items.Clear();L2.Items.Clear();
        }
    }
}
