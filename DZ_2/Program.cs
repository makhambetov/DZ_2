using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            do
            {
                Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Вывод на экран в одну строку трех любых чисел с двумя пробелами между ними.");
                Console.WriteLine("2. Вывести на экран числа 5, 10 и 21 одно под другим");
                Console.WriteLine("3. Дано расстояние в сантиметрах. Найти число полных метров в нем");
                Console.WriteLine("4. С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?");
                Console.WriteLine("5. Дано двузначное число. Найти a.число десятков в нем; b.число единиц в нем;c.сумму его цифр;d.произведение его цифр");
                Console.WriteLine("");

                Console.Write("Выберите пункт меню ->");

                string str = Console.ReadLine();
                bool res = Int32.TryParse(str, out menu);
                if (!res) { menu = -1; continue; }
            
                Random rnd = new Random();
                if (menu == 1)
                {
                    int a = rnd.Next(0, 100);
                    int b = rnd.Next(0, 100);
                    int c = rnd.Next(0, 100);
                    Console.WriteLine(a + "  " + b + "  " + c);
                }

                else if (menu == 2)
                {
                    Console.WriteLine("5");
                    Console.WriteLine("10");
                    Console.WriteLine("21");
                }

                else if (menu == 3)
                {
                    bool convert;
                    int cm=0;
                    int meter=0;
                    do
                    {
                        Console.Write("Введите расстояние в см: ");
                        string str_cm = Console.ReadLine();
                        convert = Int32.TryParse(str_cm, out cm);
                        if (convert)
                        {
                            meter = cm / 100;
                        } 
                    } while (!convert);
                    Console.WriteLine("Количество полных метров: " + meter);
                }

                else if (menu == 4)
                {
                    int days = 234;                       
                    Console.WriteLine("Количество дней: " + days);
                    Console.WriteLine("Количество полных недель: " + days/7);
                }

                Console.ReadKey();
            } while (menu != 0);


            
        }
    }
}
