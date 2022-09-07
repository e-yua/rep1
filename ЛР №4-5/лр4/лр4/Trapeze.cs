using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр4
{
    class Trapeze : Rectangle
    {
        //Дополнительное поле класса.
        private double angle;
        /// <summary>
        /// Конструктор класса Trapeze.
        /// </summary>
        /// <param name="a">Основание трапеции.</param>ыыыы
        /// <param name="b">Основание трапеции.</param>
        /// <param name="alpha">Угол наклона при основании трапеции.</param>
        public Trapeze(double a=0.0, double b=0.0, double alpha=0.0): base(a,b)
        {
            this.angle = alpha;
        }
        /// <summary>
        /// Метод вывода информации об объекте на консоль.
        /// </summary>
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Угол наклона = " + angle);
        }
        /// <summary>
        /// Свойство доступа к полю angle.
        /// </summary>
        public double Angle
        {
            // Установка значения поля angle.
            set
            {
                angle = value;
            }
        }
        /// <summary>
        /// Метод вычисления площади трапеции.
        /// </summary>
        /// <returns>Дейтсвительное число, округленное до 3-го знака после запятой.</returns>
        public override double Area()
        {
            return Math.Round(((this.B * this.B - this.A * this.A) / 2) * ((Math.Sin(angle * (Math.PI / 180.0)) * Math.Sin(angle * (Math.PI / 180.0))) / Math.Sin(2*angle * (Math.PI / 180.0))), 3);
        }
    }
}
