using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр4
{
    class Trapeze : Rectangle
    {
        private double angle;
        public Trapeze(double l, double w, double a) : base(l, w)
        {
            this.angle = a;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Угол наклона = " + angle);
        }
        public double Angle
        {
            get
            {
                return angle;
            }
        }
        public override double Area()
        {
            return (((this.width * this.width - this.length * this.length) / 2) * ((Math.Sin(angle) * Math.Sin(angle)) / Math.Sin(2 * angle)));
        }
    }
}
