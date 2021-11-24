using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hodiny
{
   public partial class Form1 : Form
   {
      Timer timer;
      DateTime dt;
      Point clockPos = new Point(50, 40);
      int clockSize = 350;
      int r; //radius
      Point clockCenter;
      public Form1()
      {
         InitializeComponent();
         timer = new Timer();
         timer.Interval = 10;
         timer.Tick += new EventHandler(timer_tick);
         timer.Start();
         r = clockSize / 2;
         clockCenter = new Point(clockPos.X + r, clockPos.Y + r);
      }

      //paint:
      private void Form1_Paint(object sender, PaintEventArgs e)
      {
         Graphics gfx = e.Graphics;
         //draw analog clock:
         Pen circlePen = new Pen(Color.Black, 3);
         Pen hoursPen = new Pen(Color.Black, 8);
         Pen minutesPen = new Pen(Color.Black, 4);
         Pen secondsPen = new Pen(Color.DarkRed, 2);
         gfx.DrawEllipse(circlePen, clockPos.X, clockPos.Y, clockSize, clockSize);
         Point handPoint;
         //hours:
         handPoint = hrCoord(dt.Hour, dt.Minute, r - 32);
         gfx.DrawLine(hoursPen, clockCenter, handPoint);
         //minutes:
         handPoint = msCoord(dt.Minute, r - 5);
         gfx.DrawLine(minutesPen, clockCenter, handPoint);
         //seconds:
         handPoint = msCoord(dt.Second, r - 5);
         gfx.DrawLine(secondsPen, clockCenter, handPoint);
      }

      //coordinates for minutes and seconds:
      private Point msCoord(int val, int hlen)
      {
         Point coord = new Point(-1);
         val *= 6; //each minute and seconds make a 6 degree   
         if (val >= 0 && val <= 100)
         {
            coord.X = clockCenter.X + (int)(hlen * Math.Sin(Math.PI * val / 180));
            coord.Y = clockCenter.Y - (int)(hlen * Math.Cos(Math.PI * val / 180));
         }
         else
         {
            coord.X = clockCenter.X - (int)(hlen * -Math.Sin(Math.PI * val / 180));
            coord.Y = clockCenter.Y - (int)(hlen * Math.Cos(Math.PI * val / 180));
         }
         return coord;
      }

      //coord for hours:
      private Point hrCoord(int hval, int mval, int hlen)
      {
         Point coord = new Point(-1);
         //each hour makes 60 degree with min making 0.5 degree   
         int val = (int)((hval * 30) + (mval * 0.5));
         if (val >= 0 && val <= 180)
         {
            coord.X = clockCenter.X + (int)(hlen * Math.Sin(Math.PI * val / 180));
            coord.Y = clockCenter.Y - (int)(hlen * Math.Cos(Math.PI * val / 180));
         }
         else
         {
            coord.X = clockCenter.X - (int)(hlen * -Math.Sin(Math.PI * val / 180));
            coord.Y = clockCenter.Y - (int)(hlen * Math.Cos(Math.PI * val / 180));
         }
         return coord;
      }

      //timer:
      int lastMinutes, lastSeconds;
      private void timer_tick(object s, EventArgs a)
      {
         dt = DateTime.Now;
         string minutes = dt.Minute > 9 ? $"{dt.Minute}" : $"0{dt.Minute}";
         string seconds = dt.Second > 9 ? $"{dt.Second}" : $"0{dt.Second}";
         lbDigitalClock.Text = $"{dt.Hour}:{minutes}:{seconds}";
         if (dt.Minute != lastMinutes || dt.Second != lastSeconds)
         {
            Refresh();
         }
         lastMinutes = dt.Minute;
         lastSeconds = dt.Second;
      }
   }
}
