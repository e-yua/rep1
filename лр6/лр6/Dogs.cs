using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр6
{
    class Dogs
    {
        // Поля класса.
        private string name;
        private string breed;
        private int height;
        private double weight;
        /// <summary>
        /// Конструктор класса Dogs.
        /// </summary>
        /// <param name="n">Кличка собаки. Строковое значение.</param>
        /// <param name="b">Порода собаки. Строковое значение.</param>
        /// <param name="h">Высота в холке. Целочисленное значение.</param>
        /// <param name="w">Вес собаки. Действительное число.</param>
        public Dogs(string n, string b, int h, double w)
        {
            // Присвоение значений полям класса.
            name = n;
            breed = b;
            height = h;
            weight = w;
        }
        /// <summary>
        /// Метод вывода информации об объекте класса в виде строки.
        /// </summary>
        /// <returns>Строка со значениями полей класса.</returns>
        public override string ToString()
        {
            return "Кличка : " + this.name + "\nПорода : " + this.breed + "\nРост : " + this.height + "\nВес : " + this.weight+"\n\n";
        }
        /// <summary>
        /// Свойство доступа к значению поля height.
        /// </summary>
        public int Height
        {
            get
            {
                return height;
            }
        }
        /// <summary>
        ///  Свойство доступа к значению поля height.
        /// </summary>
        public double Weight
        {
            get
            {
                return weight;
            }
        }
        /// <summary>
        /// Свойство доступа к значению поля name.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
