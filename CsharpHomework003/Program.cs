using System;

namespace CsharpHomework003
{
    //1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
    struct Complex
    {
        public double im;
        public double re;
        // в C# в структурах могут храниться также действия над данными
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        } // Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        } // Пример вычитания двух комплексных чисел
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    //1.б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.

    class Complex2
    {
        // Поля приватные.
        private double im;
        // По умолчанию элементы приватные, поэтому private можно не писать.
        double re;
        // Конструктор без параметров.
        public Complex2()
        {
            im = 0;
            re = 0;
        }
        // Конструктор, в котором задаем поля.
        // Специально создадим параметр re, совпадающий с именем поля в классе.
        public Complex2(double _im, double re)
        {
            // Здесь имена не совпадают, и компилятор легко понимает, что чем является.
            im = _im;
            // Чтобы показать, что к полю нашего класса присваивается параметр,
            // используется ключевое слово this
            // Поле параметр
            this.re = re;
        }
        public Complex2 PlusB(Complex2 x2)
        {
            Complex2 x3 = new Complex2();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        public Complex2 MinusB(Complex2 xMinus)
        {
            Complex2 xMinus1 = new Complex2();
            xMinus1.im = xMinus.im - im;
            xMinus1.re = xMinus.re - re;
            return xMinus1;
        }
        public Complex2 MultiB(Complex2 xMulti)
        {            
            Complex2 xMulti1 = new Complex2();
            xMulti1.im = re * xMulti.im + im * xMulti.re;
            xMulti1.re = re * xMulti.re - im * xMulti.im;
            return xMulti1;
        }

        // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return im; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) im = value;
            }
        } // Специальный метод, который возвращает строковое представление данных.
        public string ToStringB()
        {
            return re + "+" + im + "i";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;
            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;                       

            bool Loop = true;
            while (Loop)
            {
                Console.WriteLine("\n1 - ВЫЧИТАНИЕ КОМПЛЕКСНЫХ ЧИСЕЛ В СТРУКТУРЕ.");
                Console.WriteLine("\n2 - ВЫЧИТАНИЕ И УМНОЖЕНИЕ КОМПЛЕКСНЫХ ЧИСЕЛ В КЛАССЕ.");
                Console.WriteLine("\n3 - ИСПОЛЬЗОВАНИЕ tryParse.");
                Console.WriteLine("\nВЫБЕРИТЕ ДЕЙСТВИЕ И НАЖМИТЕ ENTER, ДЛЯ ВЫХОДА НАЖМИТЕ ЛЮБУЮ ДРУГУЮ КЛАВИШУ: ");
                if (int.TryParse(Console.ReadLine(), out int Sw))
                {                    
                    switch (Sw)
                    {
                        case 1:
                            Console.WriteLine("\n1.а) ВЫЧИТАНИЕ КОМПЛЕКСНЫХ ЧИСЕЛ В СТРУКТУРЕ.\n");

                            Console.WriteLine("Сложение\n");
                            Complex result = complex1.Plus(complex2);
                            Console.WriteLine(result.ToString());

                            Console.WriteLine("\nУмножение\n");
                            result = complex1.Multi(complex2);
                            Console.WriteLine(result.ToString());

                            Console.WriteLine("\nВычитание\n");
                            result = complex1.Minus(complex2);
                            Console.WriteLine(result.ToString());
                            break;

                        case 2:
                            Console.WriteLine("\n1.б) ВЫЧИТАНИЕ И УМНОЖЕНИЕ КОМПЛЕКСНЫХ ЧИСЕЛ В КЛАССЕ.\n");

                            // Описали ссылку на объект.
                            Complex2 complexB;
                            // Создали объект и сохранили ссылку на него в complex1.
                            complexB = new Complex2(1, 1);
                            // Описали объект и создали его.
                            Complex2 complexB2 = new Complex2(2, 2);
                            // С помощью свойства Im изменили внутреннее (приватное) поле im.
                            complexB2.Im = 3;
                            // Создали ссылку на объект.
                            Complex2 resultB;
                            Console.WriteLine("Сложение\n");
                            // Так как в методе Plus создается новый объект,
                            // в result сохраняем ссылку на вновь созданный объект.
                            resultB = complexB.PlusB(complexB2);
                            Console.WriteLine(resultB.ToStringB());

                            Console.WriteLine("\nВычитание\n");
                            resultB = complexB.MinusB(complexB2);
                            Console.WriteLine(resultB.ToStringB());

                            Console.WriteLine("\nУмножение\n");
                            resultB = complexB.MultiB(complexB2);
                            Console.WriteLine(resultB.ToStringB());
                            break;

                        case 3:
                            Console.WriteLine("\n2.а) ИСПОЛЬЗОВАНИЕ tryParse.\n");

                            Console.WriteLine("Введите числа: ");

                            float Numbers;
                            float sumOddNumbers = 0;
                            do
                            {
                                if (float.TryParse(Console.ReadLine(), out Numbers))
                                {
                                    if (Numbers % 2 != 0 && Numbers > 0)
                                    {
                                        sumOddNumbers += Numbers;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели некорректные данные!\n");
                                }
                            }
                            while (Numbers != 0);

                            Console.WriteLine("Сумма всех введёных нечётных положительных чисел: " + sumOddNumbers + "\n");
                            break;

                        default:
                            Console.WriteLine("Вы ввели некорректное число!\n");
                            Loop = false;
                            break;
                    }
                }
        }   }
    }
}