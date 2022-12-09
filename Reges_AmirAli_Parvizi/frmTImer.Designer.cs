namespace Reges_AmirAli_Parvizi
{
    partial class frmTImer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.h = new System.Windows.Forms.Label();
            this.r2 = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.Label();
            this.r1 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.h.Font = new System.Drawing.Font("Mj_Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.h.Location = new System.Drawing.Point(41, 49);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(48, 72);
            this.h.TabIndex = 0;
            this.h.Text = "0";
            this.h.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.r2.Font = new System.Drawing.Font("Mj_Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.r2.Location = new System.Drawing.Point(114, 49);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(41, 72);
            this.r2.TabIndex = 0;
            this.r2.Text = ":";
            this.r2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.m.Font = new System.Drawing.Font("Mj_Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.m.Location = new System.Drawing.Point(172, 49);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(48, 72);
            this.m.TabIndex = 0;
            this.m.Text = "0";
            this.m.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.r1.Font = new System.Drawing.Font("Mj_Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.r1.Location = new System.Drawing.Point(250, 49);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(41, 72);
            this.r1.TabIndex = 0;
            this.r1.Text = ":";
            this.r1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.s.Font = new System.Drawing.Font("Mj_Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.s.Location = new System.Drawing.Point(308, 49);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(48, 72);
            this.s.TabIndex = 0;
            this.s.Text = "0";
            this.s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(9, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "شروع";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(142, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "توقف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(270, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 33);
            this.button4.TabIndex = 1;
            this.button4.Text = "صفر کردن";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(300, 161);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 33);
            this.button5.TabIndex = 1;
            this.button5.Text = "رنگ فونت";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(203, 161);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 33);
            this.button6.TabIndex = 1;
            this.button6.Text = "رنگ زمینه";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(106, 161);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 33);
            this.button7.TabIndex = 1;
            this.button7.Text = "عکس زمینه";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(9, 161);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 33);
            this.button8.TabIndex = 1;
            this.button8.Text = "فونت ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTImer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 245);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.s);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.m);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.h);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTImer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کورنومتر";
            this.Load += new System.EventHandler(this.frmTImer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Label r2;
        private System.Windows.Forms.Label m;
        private System.Windows.Forms.Label r1;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Timer timer1;
    }
}