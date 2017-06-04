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
                Console.WriteLine("0. Выход.");
                Console.WriteLine("1. Вывод на экран в одну строку трех любых чисел с двумя пробелами между ними.");
                Console.WriteLine("2. Вывести на экран числа 5, 10 и 21 одно под другим");
                Console.WriteLine("3. Дано расстояние в сантиметрах. Найти число полных метров в нем");
                Console.WriteLine("4. С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?");
                Console.WriteLine("5. Дано двузначное число. Найти a.число десятков в нем; b.число единиц в нем;c.сумму его цифр;d.произведение его цифр");
                Console.WriteLine("6. Вычислить значение логического выражения при следующих значениях логических величин А, В и С:");
                Console.WriteLine("   А = Истина, В = Ложь, С = Ложь:");
                Console.WriteLine("   a.А или В;");
                Console.WriteLine("   b.А и В;");
                Console.WriteLine("   c.В или С.");
                Console.WriteLine("7. Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?");
                Console.WriteLine("8. Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?");
                Console.WriteLine("9. Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них.");
                Console.WriteLine("   По какому участку протекает меньший ток?");
                Console.WriteLine("10. Напечатать 'столбиком': ");
                Console.WriteLine("    a. все целые числа от 20 до 35");
                Console.WriteLine("    b. квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10)");
                Console.WriteLine("    c. третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50)");
                Console.WriteLine("    d. все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a)");
                Console.WriteLine("11. Вычисления значения функции y=7x^2-3x+4 при любом значении x");
                Console.WriteLine("12. Дан радиус окружности. Найти длину окружности и площадь круга");
                Console.WriteLine("17. В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному");
                Console.WriteLine("    числу справа приписали вторую цифру числа x, то получилось число 456. Найти число x.");
                Console.WriteLine("18. Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:");
                Console.WriteLine("    a. не X и не Y;");
                Console.WriteLine("    b. X или (не X и Y);");
                Console.WriteLine("    c. (не X и Y) или Y.");

                Console.Write("Выберите пункт меню ->");
                
                Int32.TryParse(Console.ReadLine(), out menu);

                Random rnd = new Random();
                switch (menu)
                {
                    case 1:
                        int a = rnd.Next(0, 100);
                        int b = rnd.Next(0, 100);
                        int c = rnd.Next(0, 100);
                        Console.WriteLine(a + "  " + b + "  " + c);
                        break;
                    case 2:
                        Console.WriteLine("5");
                        Console.WriteLine("10");
                        Console.WriteLine("21");
                        break;
                    case 3:
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
                        break;
                    case 4:
                        int days = 234;                       
                        Console.WriteLine("Количество дней: " + days);
                        Console.WriteLine("Количество полных недель: " + days/7);
                        break;
                    case 5:
                        int num = 0;
                        bool res;
                        do
                        {
                            Console.Write("Введите двузначное число: ");
                            res = Int32.TryParse(Console.ReadLine(), out num);
                            
                        }
                        while (!res || num < 10 || num > 99);
                        Console.WriteLine("a. Число десятков: " + num/10);
                        Console.WriteLine("b. Число единиц: " + (num - (num / 10)*10));
                        Console.WriteLine("c. Сумма цифр: " + ((num - (num / 10) * 10) + (num / 10)));
                        Console.WriteLine("d. Произведение цифр: " + (num - (num / 10) * 10) * (num / 10));
                        break;
                    case 6:
                        bool A = true, B = false, C = false;
                        Console.WriteLine("A = true, B = false, C = fals");
                        Console.WriteLine("a. А или В = " + (A || B));
                        Console.WriteLine("b. А  и  В = " + (A && B));
                        Console.WriteLine("c. B или C = " + (B || C));
                        break;
                    case 7:
                        Console.WriteLine("Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?");
                        Console.WriteLine("Введите радиус круга");
                        int rad;
                        Int32.TryParse(Console.ReadLine(), out rad);
                        Console.WriteLine("Введите сторону квадрата");
                        int len;
                        Int32.TryParse(Console.ReadLine(), out len);
                        double circle_area = Math.PI * Math.Pow(rad, 2);
                        double square_area = Math.Pow(len,2);
                        Console.WriteLine("Площадь круга: " + circle_area);
                        Console.WriteLine("Сторона квадрата: " + square_area);
                        if(circle_area > square_area)
                            Console.WriteLine("Площадь круга больше");
                        else if(square_area > circle_area)
                            Console.WriteLine("Площадь квадрата больше");
                        else
                            Console.WriteLine("Площадь круга и квадрата равны");
                        break;
                    case 8:
                        Console.WriteLine("Объемы тела А = 2.1 м3 | масса тела А = 1500 кг");
                        Console.WriteLine("Объемы тела В = 3.2 м3 | масса тела В = 2100 кг");
                        double volume1 = 2.1;
                        double volume2 = 3.2;
                        double mass1 = 1500;
                        double mass2 = 2100;
                        double density1 = volume1 / mass1;
                        double density2 = volume2 / mass2;
                        if (density1 > density2)
                            Console.WriteLine("Плотность тела А больше");
                        else if (density1 < density2)
                            Console.WriteLine("Плотность тела В больше");
                        else
                            Console.WriteLine("Плотность тела А и тела В равны");
                        break;
                    case 9:
                        /*Известны сопротивления двух несоединенных друг 
                         * с другом участков электрической цепи и напряжение на каждом из них.");
                         По какому участку протекает меньший ток?
                         */
                        Console.WriteLine("Напряжение участка А = 5.4 В | сопротивление участка А = 1.2 Ом");
                        Console.WriteLine("Напряжение участка В = 6.1 В | сопротивление участка В = 1.5 Ом");
                        double voltage1 = 5.4;
                        double voltage2 = 6.1;
                        double res1 = 1.2;
                        double res2 = 1.5;
                        double current1 = voltage1 / res1;
                        double current2 = voltage2 / res2;
                        if (current1 > current2)
                            Console.WriteLine("Ток участка А больше");
                        else if (current1 < current2)
                            Console.WriteLine("Ток участка В больше");
                        else
                            Console.WriteLine("Ток участка А и участка В равны");
                        break;
                    case 10:
                        int number = 20;
                        Console.WriteLine("a)");
                        while (number < 36)
                            Console.WriteLine(number++);

                        Console.WriteLine("\nb)");
                        Console.WriteLine("Введите число больше 10: ");
                        int start = 10;
                        int end;
                        Int32.TryParse(Console.ReadLine(), out end);
                        if (end > start)
                        {
                            while (start < end + 1)
                                Console.WriteLine(start + "^2 = " + Math.Pow(start++, 2));
                        }
                        else
                            Console.WriteLine("Вы ввели неверное число.");

                        Console.WriteLine("\nc)");
                        Console.WriteLine("Введите число меньше 50: ");
                        end= 50;
                        Int32.TryParse(Console.ReadLine(), out start);
                        if (start < end)
                        {
                            while (start < end + 1)
                                Console.WriteLine(start + "^2 = " + Math.Pow(start, 2) + "\t" + start + "^3 = " + Math.Pow(start, 3) + "\t" + start + "^4 = " + Math.Pow(start++, 4));
                        }
                        else
                            Console.WriteLine("Вы ввели неверное число.");

                        Console.WriteLine("\nc)");
                        Console.WriteLine("Введите 1-е целое число: ");
                        Int32.TryParse(Console.ReadLine(), out start);
                        Console.WriteLine("Введите 2-е целое число: ");
                        Int32.TryParse(Console.ReadLine(), out end);
                        if(start < end)
                        {
                            while (start < end+1)
                                Console.WriteLine(start++);
                        }
                        else
                            while (end <  start + 1)
                                Console.WriteLine(end++);
                        break;
                    case 11:
                        Console.WriteLine("Введите число x: ");
                        int x;
                        Int32.TryParse(Console.ReadLine(), out x);
                        Console.WriteLine("y = 7x^2 - 3x + 4;");
                        Console.WriteLine("y = 7" + x + "^2-3" + x + "+4;");
                        Console.WriteLine("y = " + (7*Math.Pow(x, 2) - 3*x + 4));
                        break;
                    case 12:
                        Console.WriteLine("Введите радиус круга: ");
                        int radius;
                        Int32.TryParse(Console.ReadLine(), out radius);
                        Console.WriteLine("Радиус круга: " + 2 * Math.PI * radius);
                        Console.WriteLine("Площадь круга: " + Math.PI * Math.Pow(radius, 2));
                        break;
                    case 17:
                        Console.WriteLine("В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному");
                        Console.WriteLine("числу справа приписали вторую цифру числа x, то получилось число 456. Найти число x.");
                        int result = 456;
                        int num_x = (result / 100)*100 + (result - (result / 10) * 10)*10 + ((result / 10) - (result / 100) * 10);
                        Console.WriteLine("Число х = " + num_x);
                        break;
                    case 18:
                        bool X, Y;

                        X = true; Y = true;
                        Console.WriteLine("\n1. X = true;  Y = true");
                        Console.WriteLine("a) не X и не Y      => " + (!X && !Y));
                        Console.WriteLine("b) X или (не X и Y) => " + (X || (!X && Y)));
                        Console.WriteLine("c) (не X и Y) или Y => " + ((!X && Y)|| Y));

                        X = false; Y = false;
                        Console.WriteLine("\n2. X = false; Y = false");
                        Console.WriteLine("a) не X и не Y      => " + (!X && !Y));
                        Console.WriteLine("b) X или (не X и Y) => " + (X || (!X && Y)));
                        Console.WriteLine("c) (не X и Y) или Y => " + ((!X && Y) || Y));

                        X = true; Y = false;
                        Console.WriteLine("\n3. X = true;  Y = false");
                        Console.WriteLine("a) не X и не Y      => " + (!X && !Y));
                        Console.WriteLine("b) X или (не X и Y) => " + (X || (!X && Y)));
                        Console.WriteLine("c) (не X и Y) или Y => " + ((!X && Y) || Y));

                        X = false; Y = true;
                        Console.WriteLine("\n4. X = false; Y = true");
                        Console.WriteLine("a) не X и не Y      => " + (!X && !Y));
                        Console.WriteLine("b) X или (не X и Y) => " + (X || (!X && Y)));
                        Console.WriteLine("c) (не X и Y) или Y => " + ((!X && Y) || Y));
                        break;
                }

                Console.ReadKey();
            } while (menu != 0);


            
        }
    }
}
