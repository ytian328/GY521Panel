using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MyCompass
{
	/// <summary>
	/// Summary description for MyCompass.
	/// </summary>
	/// 
	public partial class MyCompass : System.Windows.Forms.UserControl
	{
		private int center;
		/// <summary>
		/// Required designer variable.
		/// </summary>


		public MyCompass()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitComponent call

			this.BackColor = Color.Black;
			this.SetStyle(ControlStyles.ResizeRedraw, true);
			this.SetStyle(ControlStyles.DoubleBuffer, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.UserPaint, true);
			this.Height = 100;
			this.Width = 100;
			this.range = 36;
			this.angle = 0;
			this.arrowColor = System.Drawing.Color.Red;
			this.numNumbers = 10;

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>


		protected override void OnPaint(PaintEventArgs e)
		{
			float divisor = range / 360;
			if (this.ClientRectangle.Width < this.ClientRectangle.Height)
				this.center = ClientRectangle.Width;
			else
				this.center = ClientRectangle.Height;
			center = center / 2;
			PointF centerPt = new PointF(center, center);
			Graphics g = e.Graphics;


			using (GraphicsPath gp = new GraphicsPath())
			{
				gp.AddEllipse(0, 0, 2 * center, 2 * center);
				this.Region = new Region(gp);

				using (Brush brush = new SolidBrush(Color.Yellow))
				{
					if (numNumbers == 0)
						numNumbers = 1;
					for (int i = 0; i < 360; i += 360 / numNumbers)
					{
						Matrix matrix = new Matrix();
						matrix.RotateAt(i + this.angle, centerPt);
						g.Transform = matrix;
						g.DrawLine(Pens.Yellow, center, center, center, center * 3 / 10);
						g.DrawString(((int)(i * divisor)).ToString(), this.Font, brush, center - 6, center * 5 / 100,
							StringFormat.GenericTypographic);
					}

				}

			}
			using (GraphicsPath gp2 = new GraphicsPath())
			{
				using (Pen pen = new Pen(arrowColor, 12))
				{
					Matrix matrix = new Matrix();
					matrix.RotateAt(0, centerPt);
					g.Transform = matrix;
					pen.EndCap = LineCap.ArrowAnchor;
					g.DrawLine(pen, center, center, center, center / 8);
					g.DrawLine(pen, center, center, (center * 9) / 10, center);
					g.DrawLine(pen, center, center, (center * 11) / 10, center);
					g.DrawLine(pen, center, center, center, (center * 11) / 10);
				}
			}
		}


		#region Custom Properties
		/// <summary>
		/// 
		/// New properties, available in in Designer's properties browser
		/// 
		/// </summary>

		[
		CategoryAttribute("Appearance"),
		DescriptionAttribute("Initial angle of gauge")
		]
		public float Angle
		{
			get { return angle; }
			set
			{
				angle = (360f - value);
				if (angle < 0f)
					angle = 0f;
				this.Refresh();
			}
		}

		[
		CategoryAttribute("Appearance"),
		DescriptionAttribute("the maximum value represented by dial")
		]
		public float Range
		{
			get { return range; }
			set
			{
				range = value;
				this.Refresh();
			}
		}


		[
		CategoryAttribute("Appearance"),
		DescriptionAttribute("Initial color of arm")
		]
		public Color ArrowColor
		{
			get { return arrowColor; }
			set
			{
				arrowColor = value;
				this.Refresh();
			}
		}

		[
		CategoryAttribute("Appearance"),
		DescriptionAttribute("the number of markings that appear on the dial")
		]
		public int NumNumbers
		{
			get { return numNumbers; }
			set
			{
				numNumbers = value;
				this.Refresh();
			}
		}

		#endregion

		private float range, angle;
		private Color arrowColor;
		private int numNumbers;
	}
}
