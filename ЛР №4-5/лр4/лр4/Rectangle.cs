using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр4
{
    class Rectangle
    {
        // Поля класса.
        private double a;
        private double b;
        /// <summary>
        /// Конструктор класса Rectangle.
        /// </summary>
        /// <param name="a">Длина прямоугольника.</param>
        /// <param name="b">Ширина прямоугольника.</param>
        public Rectangle(double a=0.0, double b=0.0)
        {
            this.a = a;
            this.b = b;
        }
        /// <summary>
        /// Свойство доступа к полю a.
        /// </summary>
        public double A
        {
            // Установка значения поля a.
            set
            {
                a = value;
            }
            // Установка значния поля b.
            get
            {
                return a;
            }
        }
        /// <summary>
        /// Свойство доступа к полю b.
        /// </summary>
        public double B
        {
            // Установка значения поля b.
            set
            {
                b = value;
            }
            // Получение значения поля b.
            get
            {
                return b;
            }
        }
        /// <summary>
        /// Метод вывода объекта класса на консоль.
        /// </summary>
        public virtual void Show()
        {
            Console.WriteLine("Сторона a = " + this.a + "\nСторона b = " + this.b);
        }
        /// <summary>
        /// Метод вычисления площади прямоугольника.
        /// </summary>
        /// <returns>Действительное число, округленное до 3 знака после запятой.</returns>
        public virtual double Area()
        {
            return Math.Round(this.a * this.b, 3);
        }
    }
}
