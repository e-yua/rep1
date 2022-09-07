using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр4
{
    class Rectangle
    {
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public virtual void Show()
        {
            Console.WriteLine("a = " + this.length + "\nb = " + this.width);
        }
        public virtual double Area()
        {
            return this.length * this.width;
        }
        //public static double Area1(Object R)
        //{
        //    double alpha;
        //    if (R is Parallelogram)
        //    {
        //        alpha = ((Parallelogram)R).Angle;
        //        return Math.Sin(alpha) * ((Parallelogram)R).length * ((Parallelogram)R).width;
        //    }
        //    if (R is Trapeze)
        //    {
        //        alpha = ((Trapeze)R).Angle;
        //        return (((((Trapeze)R).width * ((Trapeze)R).width - ((Trapeze)R).length * ((Trapeze)R).length) / 2) * ((Math.Sin(alpha) * Math.Sin(alpha)) / Math.Sin(2 * alpha)));
        //    }
        //    return ((Rectangle)R).width * ((Rectangle)R).length;
        //}
    }
}
