using System;
using System.Collections.Generic;

namespace ЛР3
{
    class Program
    {
        // Определение структуры Subject.
        struct Subjects
        {
            // Элементы структуры Subject.
            public string spec;
            public string subject;
            public int hourPerWeek;
            public int totalHours;
            public Boolean exam;
        };
        // Коллекция объектов типа Subject, содержащая список предметов.
        static List<Subjects> MyList = new List<Subjects>();
        // Функция добавления новой записи в коллекцию.
        static void Add_To_List()
        {
            // Создание вспомогательного объекта структуры.
            Subjects S = new Subjects();
            // Заполнение элементов структуры.
            Console.WriteLine("Введите название предмета : ");
            S.subject = Console.ReadLine();
            Console.WriteLine("Введите специальность :");
            S.spec = Console.ReadLine();
            // Бесконечный цикл для проверки корректности ввода часов в неделю и общего количества часов
            while (true)
            {
                // Вспомогательные переменные для ввода часов.
                string hour1;
                string hour2;
                int n1, n2;
                Console.WriteLine("Введите количество часов в неделю :");
                hour1 = Console.ReadLine();
                Console.WriteLine("Введите общее количество часов :");
                hour2 = Console.ReadLine();
                // Проверка, являются ли введенные значения целыми числами.
                if (Int32.TryParse(hour1, out n1) == true && Int32.TryParse(hour2, out n2) == true)
                {
                    // Присвоение введенных значений элементам коллекции.
                    S.hourPerWeek = Int32.Parse(hour1);
                    S.totalHours = Int32.Parse(hour2);
                    // Проверка того, что количество часов в неделю не превышает общее количество часов.
                    if (S.hourPerWeek > S.totalHours)
                    {
                        Console.WriteLine("Количество часов в неделю не может превышать общее количество часов.");
                    }
                    // Выход из цикла.
                    else
                        break;
                }
                else
                    Console.WriteLine("Введено неверное значение.");
            }
            Console.WriteLine("Есть ли по предмету экзамен?");
            string k = "0";
            while (k != "1" && k != "2")
            {
                Console.WriteLine("Введите 1, если экзамен есть, и 2, если экзамена нет : ");
                k = Console.ReadLine();
                // Проверка введенного значения k.
                switch (k)
                {
                    case "1":
                        S.exam = true;
                        break;
                    case "2":
                        S.exam = false;
                        break;
                    default:
                        Console.WriteLine("Введено неверное значение!");
                        break;
                }
            }
            // Добавление вспомогательной структуры в коллекцию.
            MyList.Add(S);
            Console.WriteLine("Новый предмет добавлен.");
        }
        // Функция вывода всех элементов коллекции на консоль.
        static void ShowList()
        {
            // Проверка наличия элементов в коллекции.
            if (MyList.Count == 0)
                Console.WriteLine("Список предметов пуст.");
            // Цикл вывода информации об объектах на консоль.
            for (int i = 0; i < MyList.Count; i++)
            {
                Show(i);
            }
            Console.WriteLine();
        }
        // Фунция отбора предметов по специальности.
        static void FindBySpec(string n)
        {
            // Цикл перебора всех элементов коллекции.
            for (int i = 0; i < MyList.Count; i++)
            {
                // Поиск элемнетов MyList со специальностью n.
                if (MyList[i].spec == n)
                {
                    // Вызов функции вывода предмета на экран.
                    Show(i);
                }
            }
        }
        // Функция поиска предметов по наименованию.
        static int FindBySubj(string k)
        {
            // Вспомогательная коллекция для хранения индексов отобранных предметов с одинаковым наименованием.
            List<int> index = new List<int>();
            // Цикл отбора элементов из коллекции.
            for (int i = 0; i < MyList.Count; i++)
            {
                // Проверка соответсвия наименования предмета аргументу функции.
                if (MyList[i].subject == k)
                {
                    // Добавление нового элемента во вспомогательюную колекцию.
                    index.Add(i);
                }
            }
            switch (index.Count)
            {
                // Найден 1 элемент.
                case 1:
                    // Вывод индекса найденного предмета.
                    return index[0];
                // Не найдено ни одного соответсвия.
                case 0:
                    return -1;
                // Найдено несколько предметов с одинаковым названием.
                default:
                    // Цикл вывода найденных элементов на экран.
                    for (int j = 0; j < index.Count; j++)
                    {
                        Console.Write(j + 1 + ". ");
                        Show(index[j]);
                    }
                    // Бесконечный цикл для выбора нужного объекта из найденных.
                    while (true)
                    {
                        Console.WriteLine("Выберите номер предмета : ");
                        // Ввод номера выбранного объекта.
                        string s = Console.ReadLine();
                        // Вспомогательная переменная для проверки введенного значения.
                        int s1;
                        // Проверка, можно ли преобразовать введенное значение в число.
                        if (Int32.TryParse(s, out s1) && Int32.Parse(s) <= index.Count)
                        {
                            // Возвращение индекса элемента коллекции MyList.
                            return index[Int32.Parse(s) - 1];
                        }
                        else
                        {
                            Console.WriteLine("Введён неверный номер!");
                            continue;
                        }

                    }
            }
        }
            // Вывод отдельного элемента на консоль.
            static void Show(int n)
            {
            // Проверка наличия элемента в коллекции.
                if (n < 0)
                {
                    Console.WriteLine("Такого предмета нет.");
                }
                else
                {
                // Цикл поиска объекта с индексом n.
                    for (int i = 0; i < MyList.Count; i++)
                    {
                    //Отбор нужного элемента по его индексу.
                        if (i == n)
                        {
                        // Вывод информации об объекте на экран.
                            Console.WriteLine("Предмет :  " + MyList[i].subject);
                            Console.WriteLine("Специальность : " + MyList[i].spec);
                            Console.WriteLine("Количество часов в неделю: " + MyList[i].hourPerWeek);
                            Console.WriteLine("Общее количество часов : " + MyList[i].totalHours);
                            Console.Write("Наличие экзамена : ");
                            if (MyList[i].exam == true) Console.Write("есть\n");
                            else Console.Write("нет\n");
                            Console.WriteLine("--------------------------------------");
                        }
                    }
                }
            }
        // Функция редактирования выбранного элемента листа.
        static void edit(int a)
        {
            // Создание вспомогательной 
            Subjects S = new Subjects();
            // Присвоение вспомогательной структуре элементов структуры из MyList
            S = MyList[a];
            // Переменная для ввода новых значений.
            string t;
            Console.WriteLine("Введите новое название предмета : ");
            t = Console.ReadLine();
            if (t != "")
            {
                S.subject = t;
            }
            Console.WriteLine("Введите новое название специальности : ");
            t = Console.ReadLine();
            if (t != "")
            {
                S.spec = t;
            }
            // Бесконечный цикл для ввода часов.
            while (true)
            {
                // Вспомогательная переменная для проверки введенного значения.
                int res;
                Console.WriteLine("Введите количество часов в неделю : ");
                t = Console.ReadLine();
                // Проверка введенного значения.
                if (t != "" && Int32.TryParse(t, out res) == true)
                {
                    S.hourPerWeek = Int32.Parse(t);
                }
                if (t != "" && Int32.TryParse(t, out res) == false)
                {
                    Console.WriteLine("Введено неверное число.");
                    continue;
                }
                Console.WriteLine("Введите общее количество часов : ");
                t = Console.ReadLine();
                if (t == "")
                    break;
                else if (t != "" && Int32.TryParse(t, out res) == true)
                {
                    if (Int32.Parse(t) > S.hourPerWeek)
                    {
                        S.totalHours = Int32.Parse(t);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Количестов часов в неделю не может превышать общее количество часов.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Введено неверное количество часов.");
                    continue;
                }
            }
            while (true)
            {
                Console.WriteLine("Введите 1, если экзамен есть, 2, если экзамена нет  или Enter, чтобы не изменять данный параметр: ");
                t = Console.ReadLine();
                // Проверка введенного значения.
                switch (t)
                {
                    case "1":
                        S.exam = true;
                        break;
                    case "2":
                        S.exam = false;
                        break;
                    case "":
                        break;
                    default:
                        Console.WriteLine("Введено неверное значение!");
                        break;
                }
                // Выход из цикла.
                if (t == "" || t=="1" || t=="2")
                    break;
            }

            // Присвоение значений вспомогательного объекта элементу MyList.
            MyList[a] = S;
        }
            static void Main(string[] args)
            {
                // Бесконечный цикл для выбора пунктов меню.
                while (true)
                {
                // Вывод на консоль пунктов меню.
                    Console.WriteLine("1. Создать новый предмет.");
                    Console.WriteLine("2. Просмотр списка.");
                    Console.WriteLine("3. Поиск выбранного предмета (по названию).");
                    Console.WriteLine("4. Поиск предметов (по специальности).");
                    Console.WriteLine("5. Редактрировать предмет.");
                    Console.WriteLine("6. Выйти из программы.");
                    Console.WriteLine("Для выбора пункта меню введите его номер : ");
                    // Вспомогательная переменная для выбора пункта.
                    string f = Console.ReadLine();
                    switch (f)
                    {
                        case "1":
                            // Добавление в лист нового элемента.
                            Add_To_List();
                            break;
                        case "2":
                            // Вывод листа на консоль.
                            ShowList();
                            break;
                        case "3":
                            // Поиск предмета по названию.
                            Console.WriteLine("Введите название предмета : ");
                            string p = Console.ReadLine();
                            Show(FindBySubj(p));
                            break;
                        case "4":
                            // Отбор предметов по специальности.
                            Console.WriteLine("Введите название специальности : ");
                            string m = Console.ReadLine();
                            FindBySpec(m);
                            break;
                        // Редактирование предмета.
                    case "5":
                        Console.WriteLine("Введите название предмета : ");
                        // Выбор предмета для редактирования.
                        string n = Console.ReadLine();
                        edit(FindBySubj(n));
                    break;
                        // Выход.
                    case "6":
                    break;
                        // Если введенное значение не соответстует ни одному пункту меню.
                    default:
                        Console.WriteLine("Такого пункта нет.");
                    break;
                }
                // Выход из цикла.
                if (f == "6") break;
            }
        }
    }
}

