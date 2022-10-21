using System;

namespace CsharpHomework006
{
    /*1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
        Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).*/

    public delegate double Fun(double x, double a);
    public delegate double Minimum(double x);

    internal class Program
    {
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, b));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        public static double MyPow(double x, double a)
        {
            return a * Math.Pow(x, 2);
        }
        public static double MySin(double x, double a)
        {
            return a * Math.Sin(x);
        }

        /*2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
        а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить 
        минимум.Использовать массив(или список) делегатов, в котором хранятся различные функции.
        б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через 
        параметр(с использованием модификатора out).*/

        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double F30(double x)
        {
            return x * x - 50 * x + 30;
        }
        public static double F60(double x)
        {
            return x * x - 50 * x + 60;
        }
        
        public static void SaveFunc(string fileName, double a, double b, double h, Minimum MinArr)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create,
            FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(MinArr(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] Arr = new double[fs.Length];

            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                Arr[i] = (bw.ReadDouble());
            }
            bw.Close();
            fs.Close();
            min = double.MaxValue;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] < min) min = Arr[i];
            }
            return Arr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nУРОК 6.\nСТУДЕНТ: ГУРЕНКОВ ИЛЬЯ АЛЕКСЕЕВИЧ.\nПРОГРАММА: MICROSOFT VISUAL STUDIO 2022.");
            bool Loop = true;
            while (Loop)
            {
                Console.WriteLine("\n1 - ЗАДАНИЕ 1 a*x^2.");
                Console.WriteLine("\n2 - ЗАДАНИЕ 1 a*sin(x).");
                Console.WriteLine("\n3 - ЗАДАНИЕ 2 Минимум функции.");
                Console.WriteLine("\n0 - ВЫХОД.");

                Console.WriteLine("\nВЫБЕРИТЕ ДЕЙСТВИЕ И НАЖМИТЕ ENTER: ");
                if (int.TryParse(Console.ReadLine(), out int Menu1) && Menu1 >= 0 && Menu1 <= 3)
                {
                    switch (Menu1)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Функция a*x^2");
                            Table(new Fun(MyPow), -2, 2);
                            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
                            Table(MyPow, -2, 2);
                            Console.WriteLine("Еще раз но с анонимным методом");
                            Table(delegate (double b, double a)
                            {
                                return a * Math.Pow(b, 2);
                            }, -2, 2);
                            Console.WriteLine("Еще раз с лямбда выражением");
                            Table((b, a) => a * Math.Pow(b, 2), -2, 2);
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Функция a*sin(x)");
                            Table(new Fun(MySin), -2, 2);
                            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
                            Table(MySin, -2, 2);
                            Console.WriteLine("Еще раз но с анонимным методом");
                            Table(delegate (double b, double a)
                            {
                                return a * Math.Sin(b);
                            }, -2, 2);
                            Console.WriteLine("Еще раз с лямбда выражением");
                            Table((b, a) => a * Math.Sin(b), -2, 2);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Программа нахождения минимума функции");
                            double min;
                            Minimum[] minArr = { F, F30, F60 };

                            Console.WriteLine("\n1 - ПЕРВАЯ ФУНКЦИЯ, ПАРАМЕТР 10: ");
                            Console.WriteLine("\n2 - ПЕРВАЯ ФУНКЦИЯ, ПАРАМЕТР 30: ");
                            Console.WriteLine("\n3 - ПЕРВАЯ ФУНКЦИЯ, ПАРАМЕТР 60: ");
                            Console.WriteLine("\nВЫБЕРИТЕ ДЕЙСТВИЕ И НАЖМИТЕ ENTER: ");
                            if (int.TryParse(Console.ReadLine(), out int Menu2) && Menu2 >= 0 && Menu2 <= 3)
                            {
                                switch (Menu2)
                                {
                                    case 1:
                                        Console.Clear();
                                        SaveFunc("Minimum.txt", -100, 100, 0.5, minArr[0]);
                                        Load("Minimum.txt", out min);
                                        Console.WriteLine("Минимум функции: " + min);
                                        break;
                                    case 2:
                                        Console.Clear();
                                        SaveFunc("Minimum.txt", -100, 100, 0.5, minArr[1]);
                                        Load("Minimum.txt", out min);
                                        Console.WriteLine("Минимум функции: " + min);
                                        break;
                                    case 3:
                                        Console.Clear();
                                        SaveFunc("Minimum.txt", -100, 100, 0.5, minArr[2]);
                                        Load("Minimum.txt", out min);
                                        Console.WriteLine("Минимум функции: " + min);
                                        break;
                                    default:
                                        Loop = false;
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Вы ввели некорректные данные! Выход в главное меню!" + "\n");                                
                            } 
                            break;
                        default:
                            Loop = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректные данные! Повторите ввод!" + "\n");
                }
                
            }
        } 
    }
}