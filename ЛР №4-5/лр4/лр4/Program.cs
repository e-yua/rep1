using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] figures = new Rectangle[6];
            figures[0] = new Trapeze(5.5, 7.3, 45);

            figures[1] = new Trapeze();
            Console.WriteLine("Введите верхнее основание трапеции : ");
            figures[1].A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите нижнее основание трапеции : ");
            figures[1].B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите угол между верхним и нижним основаниями трапеции : ");
            ((Trapeze)figures[1]).Angle = Convert.ToDouble(Console.ReadLine());
            figures[2] = new Parallelogram(3.0, 5.5, 30);
            figures[3] = new Rectangle(6.3,10.5);
            figures[4] = new Rectangle();
            Console.WriteLine("Введите сторону прямоугольника : ");
            figures[4].A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямоугольника : ");
            figures[4].B = Convert.ToDouble(Console.ReadLine());
            figures[5] = new Parallelogram();
            Console.WriteLine("Введите сторону параллелограмма : ");
            figures[5].A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону параллелограмма : ");
            figures[5].B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите угол между сторонами : ");
            ((Parallelogram)figures[5]).Angle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nПлощади фигур : \n");
            // Цикл вывода массива на консоль.
            for (int i = 0; i < figures.Length; i++)
            {
                string str1 = "";
                string str2 = "";
                if (figures[i].GetType().ToString()=="лр4.Rectangle")
                {
                    str1 = "Прямоугольник";
                    str2 = "прямоугольника ";
                }
                if (figures[i].GetType().ToString() == "лр4.Trapeze")
                {
                    str1 = "Трапеция";
                    str2 = "трапеции "; ;
                }
                if (figures[i].GetType().ToString() == "лр4.Parallelogram")
                {
                    str1 = "Параллелограмм";
                    str2 = "параллелограмма ";
                }
                Console.WriteLine(str1+" №" + (i + 1));
                figures[i].Show();
                Console.WriteLine("Площадь "+str2 + figures[i].Area() + "\n");
            }
            Console.ReadKey();
        }
    }
}
