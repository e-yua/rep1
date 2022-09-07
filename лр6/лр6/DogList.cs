using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр6
{
    class DogList
    {
        // Поля класса DogList.
        private List<Dogs> doglist = new List<Dogs>();
        private int size;
        /// <summary>
        /// Конструктор класса DogList.
        /// </summary>
        public DogList()
        {
            size = 0;
        }
        /// <summary>
        /// Метод добавления значений в коллекцию DogList.
        /// </summary>
        /// <param name="D">Объект класса Dogs.</param>
         public void Add(Dogs D)
        {
            doglist.Add(D);
            size++;
        }
        /// <summary>
        /// Метод поиска собаки с максимальным весом и минимальной высотой в холке.
        /// </summary>
        /// <returns>Объект класса Dogs.</returns>
        public Dogs SearchDog()
        {
            // Вспомогательные переменные.
            int minheight = doglist[0].Height;
            double maxweight = doglist[0].Weight;
            Dogs temp = doglist[0];
            // Цикл перебора элементов коллекции.
            for (int i = 1; i< doglist.Count; i++)
            {
                if (maxweight < doglist[i].Weight && minheight > doglist[i].Height)
                {
                    minheight = doglist[i].Height;
                    maxweight = doglist[i].Weight;
                    temp = doglist[i];
                }
            }
            return temp;
        }
        /// <summary>
        /// Метод очищения коллекции.
        /// </summary>
        public void Clear()
        {
            doglist.Clear();
            size = 0;
        }
        /// <summary>
        /// Свойство доступа к значению поля size.
        /// </summary>
        public int Size
        {
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Метод вывода информации об объекте коллекции.
        /// </summary>
        /// <param name="i">Номер элемента коллекции.</param>
        /// <returns>Информации об i-м элементе коллекции в виде строкового значения.</returns>
        public string Show(int i)
        {
            // Присвоение вспомогательной переменной информации об элементе.
            string s = doglist[i].ToString();
            return s;
        }
    }
}
