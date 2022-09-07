using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр4
{
    class Parallelogram : Rectangle
    {
        private double angle;
        public Parallelogram(double l, double w, double a) : base(l, w)
        {
            this.angle = a;
        }
        public double Angle
        {
            get
            {
                return angle;
            }
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Угол наклона = " + this.angle);
        }
        public override double Area()
        {
            return base.Area()* Math.Sin(angle);
        }
    }
}
