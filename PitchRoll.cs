using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GY521Panel
{
	class PitchRoll
	{
		public static Bitmap DrawPitchRoll(double pitch, double roll, Size s)
		{
			pitch = Math.Min(90, pitch);
			roll = Math.Min(90, roll);
			int lineWidth = 1;
			int scaleLength = 6;
			Bitmap result = null;
			if (s.Width * s.Height > 0)
			{
				result = new Bitmap(s.Width, s.Height);
				Graphics g = Graphics.FromImage(result);
				Pen penWhite = new Pen(Color.FromArgb(255, 255, 255), lineWidth);
				Pen penOrange = new Pen(Color.FromArgb(255, 150, 0), lineWidth);
				Font font1 = new Font("Arial", 12);
				Font font2 = new Font("Arial", 16);
				SolidBrush brushWhite = new SolidBrush(Color.FromArgb(240, 255, 255, 255));
				SolidBrush brushOrange = new SolidBrush(Color.FromArgb(240, 255, 150, 0));

				//draw horizon
				g.DrawLine(penWhite, s.Width / 21, s.Height / 2, s.Width * 20 / 21, s.Height / 2);

				//draw vertical axes for pitch value
				g.DrawLine(penWhite, s.Width / 2, s.Height / 21, s.Width / 2, s.Height * 20 / 21);
				for (int i = 1; i <= 20; i++)
				{
					g.DrawLine(penWhite, s.Width / 2 - scaleLength, s.Height * i / 21 , s.Width / 2 + scaleLength, s.Height * i / 21);
				}

				//draw axes labels
				g.DrawString("-90°", font1, brushWhite, new Point(s.Width / 2 + scaleLength, s.Height * 39 / 42));
				g.DrawString("90°", font1, brushWhite, new Point(s.Width / 2 + scaleLength, s.Height / 42));
				
				//draw pitch and roll values
				String pit = Math.Round(pitch, 2).ToString("0.00") + "°";
				String rol = Math.Round(roll, 2).ToString("0.00") + "°";
				g.DrawString(pit, font2, brushOrange, new Point(0, 0));
				g.DrawString(rol, font2, brushOrange, new Point(0, 18));

				//draw the eye level according to pitch and roll value
				double rollRadius = Math.PI * roll / 180;
				double slope = Math.Tan(rollRadius);
				double intercept = -s.Width * slope / 2 - pitch * s.Height / 200 + s.Height / 2;
				g.DrawLine(penOrange, 
					s.Width / 21, 
					(float)(s.Width / 21 * slope + intercept), 
					s.Width * 20 / 21, 
					(float)(s.Width * 20 / 21 * slope + intercept));
			}

			return result;
		}
	}
}
