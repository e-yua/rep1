using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр4
{
    class Parallelogram : Rectangle
    {
        // Дополнительное поле класса.
        private double angle;
        /// <summary>
        /// Конструктор класса Parallelogram.
        /// </summary>
        /// <param name="a">Сторона параллелограмма.</param>
        /// <param name="b">Сторона параллелограмма.</param>
        /// <param name="alpha">Угол наклона между сторонами параллелограмма.</param>
        public Parallelogram(double a=0.0, double b=0.0, double alpha=0.0):base(a, b)
        {
            this.angle = alpha;
        }
        /// <summary>
        /// Метод вывода информации об объекте класса на консоль.
        /// </summary>
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Угол наклона = "+this.angle);
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
        /// Метод вычисления площади параллелограмма.
        /// </summary>
        /// <returns>Дейтсвительное число, округленное до 3-го знака после запятой.</returns>
        public override double Area()
        {
            return Math.Round(base.Area() * Math.Sin(angle * (Math.PI / 180.0)), 3);
        }
    }
}
