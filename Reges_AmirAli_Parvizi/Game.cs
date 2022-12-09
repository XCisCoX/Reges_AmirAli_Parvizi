using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reges_AmirAli_Parvizi
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }        int speed = 10;
        int result;
        bool top, left;
  

        private void Game_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            pictureBox1.Location = new Point(0, rand.Next(this.Height));
            top = left = true;
            timer1.Enabled = true;
        }
        bool b = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left > pictureBox2.Left)
            {
                timer1.Enabled = false;
                if(DialogResult.Yes==MessageBox.Show("شما باختید...امتیاز " + result.ToString()+"\r\nآیا مایل به انجام دوباره هستید؟","",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1))
                {
                    this.pictureBox1.Left = 100;
                    this.pictureBox1.Top = 200;
                    timer1.Enabled = true;
                    result = 0;
                }
                else
                {
                    this.Close();
                }
              
            }
            if (pictureBox1.Left + pictureBox1.Width >= pictureBox2.Left &&
                pictureBox1.Left + pictureBox1.Width <= pictureBox2.Left + pictureBox2.Width &&
                pictureBox1.Top + pictureBox1.Height >= pictureBox2.Top &&
                pictureBox1.Top + pictureBox1.Height <= pictureBox2.Top + pictureBox2.Height + pictureBox1.Height)
            {
                left = false;
                result += 1;
               
               
         
                
                Random md = new Random();
                int mdr = md.Next(25, 255);
                Thread.Sleep(10);
                Random sdr = new Random();
                int sdrr = sdr.Next(25, 255);
                Thread.Sleep(10);
                Random rnd = new Random();
                int rndr = rnd.Next(25, 255);
                Thread.Sleep(10);
            this.BackColor = Color.FromArgb(rndr, sdrr, mdr);
      
                   
                this.Text = "امتیاز شما "+result.ToString();


                if(result==30)
                {
                    b = true;
                }


            }
            if (left)
                pictureBox1.Left += speed; 
            else
                pictureBox1.Left -= speed;
            if (top)
                pictureBox1.Top += speed; 
            else
                pictureBox1.Top -= speed;
            if 
                (pictureBox1.Top >= this.Height - 50) 
                top = false;
            if (pictureBox1.Top <= 0)
                top = true;
            if (pictureBox1.Left <= 0)
                left = true;
            if(b==true)
            {

            }
        }

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Top = e.Y;
    
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
    
        }
    }
}
