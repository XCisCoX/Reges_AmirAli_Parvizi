using Reges_AmirAli_Parvizi;
using Reges_AmirAli_Parvizi.Properties;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Reges_AmirAli_Parvizi
{
	// Token: 0x02000002 RID: 2
	[Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
	public class ctlModernBlack : UserControl
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		[Description("Runtime Form Resizing"), Category("Stretch")]
		public bool Stretch
		{
			get
			{
				return this._Stretch;
			}
			set
			{
				this._Stretch = value;
				if (value)
				{
					this.FixedSingle = false;
				}
				base.Invalidate();
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002094 File Offset: 0x00000294
		// (set) Token: 0x06000004 RID: 4 RVA: 0x000020AC File Offset: 0x000002AC
		[Description("단일고정 여부 (최소화, 최대화 없음)"), Category("FixedSingle")]
		public bool FixedSingle
		{
			get
			{
				return this._FixedSingle;
			}
			set
			{
				this._FixedSingle = value;
				if (value)
				{
					this.Stretch = false;
				}
				base.Invalidate();
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020D8 File Offset: 0x000002D8
		private bool IsFontInstalled(string fontName)
		{
			bool result;
			using (Font font = new Font(fontName, 8f))
			{
				result = (0 == string.Compare(fontName, font.Name, StringComparison.InvariantCultureIgnoreCase));
			}
			return result;
		}

		// Token: 0x06000006 RID: 6
		[DllImport("User32")]
		private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

		// Token: 0x06000007 RID: 7
		[DllImport("user32.dll")]
		private static extern IntPtr DefWindowProc(IntPtr hWnd, uint uMsg, UIntPtr wParam, IntPtr lParam);

		// Token: 0x06000008 RID: 8
		[DllImport("User32")]
		private static extern int ReleaseCapture();

		// Token: 0x06000009 RID: 9 RVA: 0x00002128 File Offset: 0x00000328
		private void ctlSkin_Paint(object sender, PaintEventArgs e)
		{
			BufferedGraphics bufferedGraphics = BufferedGraphicsManager.Current.Allocate(e.Graphics, base.ClientRectangle);
			bufferedGraphics.Graphics.Clear(this.BackColor);
			bufferedGraphics.Graphics.InterpolationMode = InterpolationMode.High;
			bufferedGraphics.Graphics.DrawImage(this.pLayout.Image, new Rectangle(0, 0, 10, 32), 0, 0, 10, 32, GraphicsUnit.Pixel);
			bufferedGraphics.Graphics.DrawImage(this.pLayout.Image, new Rectangle(10, 0, base.Width - 20, 32), 10, 0, 44, 32, GraphicsUnit.Pixel);
			bufferedGraphics.Graphics.DrawImage(this.pLayout.Image, new Rectangle(base.Width - 10, 0, 10, 32), 54, 0, 10, 32, GraphicsUnit.Pixel);
			bufferedGraphics.Graphics.DrawImage(this.pLayout.Image, new Rectangle(0, 32, 10, base.Height - 32 - 10), 0, 32, 10, 22, GraphicsUnit.Pixel);
			bufferedGraphics.Graphics.DrawImage(this.pLayout.Image, new Rectangle(10, 32, base.Width - 20, base.Height - 32 - 10), 10, 32, 44, 22, GraphicsUnit.Pixel);
			bufferedGraphics.Graphics.DrawImage(this.pLayout.Image, new Rectangle(base.Width - 10, 32, 10, base.Height - 32 - 10), 54, 32, 10, 22, GraphicsUnit.Pixel);
			bufferedGraphics.Graphics.DrawImage(this.pLayout.Image, new Rectangle(0, base.Height - 10, 10, 10), 0, 54, 10, 10, GraphicsUnit.Pixel);
			bufferedGraphics.Graphics.DrawImage(this.pLayout.Image, new Rectangle(10, base.Height - 10, base.Width - 20, 10), 10, 54, 44, 10, GraphicsUnit.Pixel);
			bufferedGraphics.Graphics.DrawImage(this.pLayout.Image, new Rectangle(base.Width - 10, base.Height - 10, 10, 10), 54, 54, 10, 10, GraphicsUnit.Pixel);
			Form form = base.Parent as Form;
			Icon icon = new Icon(form.Icon, new Size(16, 16));
			bufferedGraphics.Graphics.DrawIcon(icon, new Rectangle(7, 7, 16, 16));
			FontStyle style = FontStyle.Regular;
			SolidBrush brush = new SolidBrush(Color.WhiteSmoke);
			string familyName;
			int num;
			int num2;
			if (this.IsFontInstalled("맑은 고딕") || this.IsFontInstalled("Malgun Gothic"))
			{
				familyName = "Malgun Gothic";
				num = 4;
				num2 = 10;
				style = FontStyle.Bold;
			}
			else if (this.IsFontInstalled("나눔고딕") || this.IsFontInstalled("NanumGothic"))
			{
				familyName = "NanumGothic";
				num = 7;
				num2 = 10;
				style = FontStyle.Bold;
			}
			else if (this.IsFontInstalled("Segoe UI Symbol"))
			{
				style = FontStyle.Bold;
				familyName = "Segoe UI Symbol";
				num = 5;
				num2 = 10;
			}
			else
			{
				familyName = Control.DefaultFont.Name;
				num2 = 9;
				num = 10;
			}
			bufferedGraphics.Graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
			bufferedGraphics.Graphics.DrawString(form.Text, new Font(familyName, (float)num2, style), brush, 25f, (float)num);
			if (this._isMouseIn)
			{
				if (this._RightX - 8 <= 49)
				{
					this._isExit = true;
					this._isMin = false;
					this._isMax = false;
					if (this._isClicked)
					{
						bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29 + 27, 0, 49, 21), 56, 42, 49, 21, GraphicsUnit.Pixel);
					}
					else
					{
						bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29 + 27, 0, 49, 21), 56, 21, 49, 21, GraphicsUnit.Pixel);
					}
					if (!this.FixedSingle)
					{
						if (this.Stretch)
						{
							if (this._isMaxed)
							{
								bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29, 0, 27, 21), 0, 84, 27, 21, GraphicsUnit.Pixel);
							}
							else
							{
								bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29, 0, 27, 21), 29, 0, 27, 21, GraphicsUnit.Pixel);
							}
						}
						else
						{
							bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29, 0, 27, 21), 29, 63, 27, 21, GraphicsUnit.Pixel);
						}
						bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113, 0, 29, 21), 0, 0, 29, 21, GraphicsUnit.Pixel);
					}
				}
				else if (this._RightX - 8 <= 76)
				{
					this._isMin = false;
					this._isExit = false;
					if (!this.FixedSingle)
					{
						this._isMax = true;
						if (this.Stretch)
						{
							if (this._isClicked)
							{
								if (this._isMaxed)
								{
									bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29, 0, 27, 21), 54, 84, 27, 21, GraphicsUnit.Pixel);
								}
								else
								{
									bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29, 0, 27, 21), 29, 42, 27, 21, GraphicsUnit.Pixel);
								}
							}
							else if (this._isMaxed)
							{
								bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29, 0, 27, 21), 27, 84, 27, 21, GraphicsUnit.Pixel);
							}
							else
							{
								bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29, 0, 27, 21), 29, 21, 27, 21, GraphicsUnit.Pixel);
							}
						}
						else
						{
							bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29, 0, 27, 21), 29, 63, 27, 21, GraphicsUnit.Pixel);
						}
						bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113, 0, 29, 21), 0, 0, 29, 21, GraphicsUnit.Pixel);
					}
					bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29 + 27, 0, 49, 21), 56, 0, 49, 21, GraphicsUnit.Pixel);
				}
				else if (this._RightX - base.Right <= 105)
				{
					if (!this.FixedSingle)
					{
						this._isMin = true;
						this._isMax = false;
						this._isExit = false;
						if (this._isClicked)
						{
							bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113, 0, 29, 21), 0, 42, 29, 21, GraphicsUnit.Pixel);
						}
						else
						{
							bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113, 0, 29, 21), 0, 21, 29, 21, GraphicsUnit.Pixel);
						}
						if (this.Stretch)
						{
							if (this._isMaxed)
							{
								bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29, 0, 27, 21), 0, 84, 27, 21, GraphicsUnit.Pixel);
							}
							else
							{
								bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29, 0, 27, 21), 29, 0, 27, 21, GraphicsUnit.Pixel);
							}
						}
						else
						{
							bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29, 0, 27, 21), 29, 63, 27, 21, GraphicsUnit.Pixel);
						}
					}
					bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29 + 27, 0, 49, 21), 56, 0, 49, 21, GraphicsUnit.Pixel);
				}
			}
			else
			{
				if (!this.FixedSingle)
				{
					bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113, 0, 29, 21), 0, 0, 29, 21, GraphicsUnit.Pixel);
					if (this.Stretch)
					{
						if (this._isMaxed)
						{
							bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29, 0, 27, 21), 0, 84, 27, 21, GraphicsUnit.Pixel);
						}
						else
						{
							bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29, 0, 27, 21), 29, 0, 27, 21, GraphicsUnit.Pixel);
						}
					}
					else
					{
						bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29, 0, 27, 21), 29, 63, 27, 21, GraphicsUnit.Pixel);
					}
				}
				bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29 + 27, 0, 49, 21), 56, 0, 49, 21, GraphicsUnit.Pixel);
			}
			if (this.FixedSingle)
			{
				bufferedGraphics.Graphics.DrawImage(this.pButtons.Image, new Rectangle(base.Width - 113 + 29 + 27 - 2, 0, 2, 21), 0, 0, 2, 21, GraphicsUnit.Pixel);
			}
			bufferedGraphics.Render(e.Graphics);
			bufferedGraphics.Dispose();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002BA8 File Offset: 0x00000DA8
		private void ctlSkin_MouseDown(object sender, MouseEventArgs e)
		{
			this._RightX = base.Width - e.X;
			this._DownY = base.Height - e.Y;
			if (e.Button == MouseButtons.Left)
			{
				this._isClicked = true;
				base.Invalidate();
			}
			if (e.Button == MouseButtons.Left && !this._isMouseIn && !this._isMaxed && this.Stretch)
			{
				uint num = 0u;
				if (e.X < 4 && e.Y < 4)
				{
					num = 61444u;
				}
				else if (this._RightX < 4 && this._DownY < 4)
				{
					num = 61448u;
				}
				else if (e.X < 4 && this._DownY < 4)
				{
					num = 61447u;
				}
				else if (this._RightX < 4 && e.Y < 4)
				{
					num = 61445u;
				}
				else if (e.X < 4)
				{
					num = 61441u;
				}
				else if (this._RightX < 4)
				{
					num = 61442u;
				}
				else if (e.Y < 4)
				{
					num = 61443u;
				}
				else if (this._DownY < 4)
				{
					num = 61446u;
				}
				if (num != 0u)
				{
					ctlModernBlack.ReleaseCapture();
					ctlModernBlack.DefWindowProc(base.Parent.Handle, 274u, (UIntPtr)num, IntPtr.Zero);
					this.Cursor = Cursors.Default;
				}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002D70 File Offset: 0x00000F70
		private void ctlSkin_MouseUp(object sender, MouseEventArgs e)
		{
			if (this._isMouseIn && e.Button == MouseButtons.Left)
			{
				this._isClicked = false;
				Form form = base.Parent as Form;
				if (this._isExit)
				{
                    if (DialogResult.Yes == MessageBox.Show("آیا شما از خروج از برنامه اطمینان دارید؟",
             "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        form.Close();
                    }
                    else
                    {

                    }
					
				}
				if (this._isMin)
				{
					form.WindowState = FormWindowState.Minimized;
				}
				if (this._isMax && this.Stretch)
				{
					if (!this._isMaxed)
					{
						this._isMaxed = true;
						form.WindowState = FormWindowState.Maximized;
					}
					else
					{
						this._isMaxed = false;
						form.WindowState = FormWindowState.Normal;
					}
				}
				if (base.Parent is Form)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002E44 File Offset: 0x00001044
		private void ctlSkin_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
			this._isMouseIn = false;
			this._isClicked = false;
			base.Invalidate();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002E68 File Offset: 0x00001068
		private void ctlSkin_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (this.Stretch)
				{
					Form form = base.Parent as Form;
					if (!this._isMaxed)
					{
						this._isMaxed = true;
						form.WindowState = FormWindowState.Maximized;
					}
					else
					{
						this._isMaxed = false;
						form.WindowState = FormWindowState.Normal;
					}
				}
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002ED8 File Offset: 0x000010D8
		private void ctlSkin_MouseMove(object sender, MouseEventArgs e)
		{
			this._RightX = base.Width - e.X;
			this._DownY = base.Height - e.Y;
			if (0 < e.Y && e.Y < 21 && 8 < this._RightX && this._RightX < 113)
			{
				this._isMouseIn = true;
				this.Cursor = Cursors.Default;
			}
			else
			{
				this._isMouseIn = false;
			}
			if (this._isMouseIn)
			{
				base.Invalidate();
				this._isReset = true;
			}
			if (this._isReset && !this._isMouseIn)
			{
				base.Invalidate();
				this._isReset = false;
			}
			if (!this._isMaxed && !this._isMouseIn && e.Y < 30 && e.X > 4 && e.X < base.Width - 4 && e.Button == MouseButtons.Left)
			{
				ctlModernBlack.DefWindowProc(base.Parent.Handle, 274u, (UIntPtr)61458u, IntPtr.Zero);
				ctlModernBlack.ReleaseCapture();
			}
			if (!this._isMaxed && this.Stretch && !this._isMouseIn)
			{
				if ((e.X < 4 && e.Y < 4) || (this._RightX < 4 && this._DownY < 4))
				{
					this.Cursor = Cursors.SizeNWSE;
				}
				else if ((this._RightX < 4 && e.Y < 4) || (e.X < 4 && this._DownY < 4))
				{
					this.Cursor = Cursors.SizeNESW;
				}
				else if (e.X < 4 || this._RightX < 4)
				{
					this.Cursor = Cursors.SizeWE;
				}
				else if (e.Y < 4 || this._DownY < 4)
				{
					this.Cursor = Cursors.SizeNS;
				}
				else
				{
					this.Cursor = Cursors.Default;
				}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003124 File Offset: 0x00001324
		private void ctlSkin_Resize(object sender, EventArgs e)
		{
			if (base.Parent is Form)
			{
				base.Invalidate();
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003150 File Offset: 0x00001350
		private void ParentForm_TextChanged(object sender, EventArgs e)
		{
			base.Invalidate();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000315C File Offset: 0x0000135C
		public ctlModernBlack()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000031CD File Offset: 0x000013CD
		private void ctlModernBlack_Load(object sender, EventArgs e)
		{
			base.ParentForm.TextChanged += new EventHandler(this.ParentForm_TextChanged);
			base.ParentForm.FormBorderStyle = FormBorderStyle.None;
			base.SendToBack();
			this.Dock = DockStyle.Fill;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003204 File Offset: 0x00001404
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000323C File Offset: 0x0000143C
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ctlModernBlack));
			this.pButtons = new PictureBox();
			this.pLayout = new PictureBox();
			((ISupportInitialize)this.pButtons).BeginInit();
			((ISupportInitialize)this.pLayout).BeginInit();
			base.SuspendLayout();
            this.pButtons.Image = Resources.pButtons_Image;
			this.pButtons.Location = new Point(82, 0);
			this.pButtons.Name = "pButtons";
			this.pButtons.Size = new Size(105, 105);
			this.pButtons.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pButtons.TabIndex = 1;
			this.pButtons.TabStop = false;
			this.pButtons.Visible = false;
            this.pLayout.Image = Resources.pLayout_Image;
			this.pLayout.Location = new Point(0, 0);
			this.pLayout.Name = "pLayout";
			this.pLayout.Size = new Size(64, 64);
			this.pLayout.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pLayout.TabIndex = 0;
			this.pLayout.TabStop = false;
			this.pLayout.Visible = false;
			base.AutoScaleDimensions = new SizeF(7f, 12f);
//			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.pButtons);
			base.Controls.Add(this.pLayout);
			this.DoubleBuffered = true;
			base.Name = "ctlModernBlack";
			base.Size = new Size(220, 151);
			base.Load += new EventHandler(this.ctlModernBlack_Load);
			base.Paint += new PaintEventHandler(this.ctlSkin_Paint);
			base.MouseDoubleClick += new MouseEventHandler(this.ctlSkin_MouseDoubleClick);
			base.MouseDown += new MouseEventHandler(this.ctlSkin_MouseDown);
			base.MouseLeave += new EventHandler(this.ctlSkin_MouseLeave);
			base.MouseMove += new MouseEventHandler(this.ctlSkin_MouseMove);
			base.MouseUp += new MouseEventHandler(this.ctlSkin_MouseUp);
			base.Resize += new EventHandler(this.ctlSkin_Resize);
			((ISupportInitialize)this.pButtons).EndInit();
			((ISupportInitialize)this.pLayout).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private const uint WM_SYSCOMMAND = 274u;

		// Token: 0x04000002 RID: 2
		private const uint SC_DRAG_RESIZEL = 61441u;

		// Token: 0x04000003 RID: 3
		private const uint SC_DRAG_RESIZER = 61442u;

		// Token: 0x04000004 RID: 4
		private const uint SC_DRAG_RESIZEU = 61443u;

		// Token: 0x04000005 RID: 5
		private const uint SC_DRAG_RESIZEUL = 61444u;

		// Token: 0x04000006 RID: 6
		private const uint SC_DRAG_RESIZEUR = 61445u;

		// Token: 0x04000007 RID: 7
		private const uint SC_DRAG_RESIZED = 61446u;

		// Token: 0x04000008 RID: 8
		private const uint SC_DRAG_RESIZEDL = 61447u;

		// Token: 0x04000009 RID: 9
		private const uint SC_DRAG_RESIZEDR = 61448u;

		// Token: 0x0400000A RID: 10
		private const uint SC_DRAG_MOVE = 61458u;

		// Token: 0x0400000B RID: 11
		private const int _layoutW = 64;

		// Token: 0x0400000C RID: 12
		private const int _upCornerW = 10;

		// Token: 0x0400000D RID: 13
		private const int _upH = 32;

		// Token: 0x0400000E RID: 14
		private const int _downH = 10;

		// Token: 0x0400000F RID: 15
		private const int _barH = 22;

		// Token: 0x04000010 RID: 16
		private const int _btH = 21;

		// Token: 0x04000011 RID: 17
		private const int _btL = 113;

		// Token: 0x04000012 RID: 18
		private const int _btMinW = 29;

		// Token: 0x04000013 RID: 19
		private const int _btMaxW = 27;

		// Token: 0x04000014 RID: 20
		private const int _btExitW = 49;

		// Token: 0x04000015 RID: 21
		private const int _btRight = 8;

		// Token: 0x04000016 RID: 22
		private const int _TitleBarT = 30;

		// Token: 0x04000017 RID: 23
		private bool _Stretch = false;

		// Token: 0x04000018 RID: 24
		private bool _FixedSingle = false;

		// Token: 0x04000019 RID: 25
		private bool _isMin = false;

		// Token: 0x0400001A RID: 26
		private bool _isMax = false;

		// Token: 0x0400001B RID: 27
		private bool _isExit = false;

		// Token: 0x0400001C RID: 28
		public bool _isMaxed = false;

		// Token: 0x0400001D RID: 29
		private bool _isReset = false;

		// Token: 0x0400001E RID: 30
		private bool _isMouseIn = false;

		// Token: 0x0400001F RID: 31
		private bool _isClicked = false;

		// Token: 0x04000020 RID: 32
		private int _RightX = 0;

		// Token: 0x04000021 RID: 33
		private int _DownY = 0;

		// Token: 0x04000022 RID: 34
		private IContainer components = null;

		// Token: 0x04000023 RID: 35
		private PictureBox pLayout;

		// Token: 0x04000024 RID: 36
		private PictureBox pButtons;
	}
}
