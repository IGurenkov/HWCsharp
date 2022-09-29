using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CsharpHomework001
{
    internal class Program
    {   
        public static void Distance()
        {
            Console.WriteLine("Введите координату первой точки по оси X: ");
            string inputX1 = Console.ReadLine();
            double X1 = double.Parse(inputX1);

            Console.WriteLine("Введите координату первой точки по оси Y: ");
            string inputY1 = Console.ReadLine();
            double Y1 = double.Parse(inputY1);

            Console.WriteLine("Введите координату второй точки по оси X: ");
            string inputX2 = Console.ReadLine();
            double X2 = double.Parse(inputX2);

            Console.WriteLine("Введите координату второй точки по оси Y: ");
            string inputY2 = Console.ReadLine();
            double Y2 = double.Parse(inputY2);

            double r = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine("Расстояние между точками равно: " + "{0:0.00}", r);
        }

        public static void Print(string MSG, int X, int Y)
        {
            Console.WriteLine("Введите Ваше имя: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию: ");
            string Family = Console.ReadLine();

            Console.WriteLine("Введите Ваш город проживания: ");
            string Town = Console.ReadLine();
            
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(MSG);            
        }

        static void Main()
        {
            Console.WriteLine("ГУРЕНКОВ ИЛЬЯ АЛЕКСЕЕВИЧ, ПРОГРАММА: Microsoft Visual Studio 2022" + Environment.NewLine);
            
            /*1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
            В результате вся информация выводится в одну строчку:
            а) используя склеивание;
            б) используя форматированный вывод;
            в) используя вывод со знаком $.*/

            Console.WriteLine("ЗАДАНИЕ 1");
            Console.WriteLine("АНКЕТА:" + Environment.NewLine);

            Console.WriteLine("Введите Ваше имя: ");
            string NameNumber1 = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию: ");
            string FamilyNumber2 = Console.ReadLine();

            Console.WriteLine("Введите Ваш возраст: ");
            string inputstring3 = Console.ReadLine();
            int AgeNumber3 = int.Parse(inputstring3);

            Console.WriteLine("Введите Ваш рост, см: ");
            string inputstring4 = Console.ReadLine();
            int LongNumber4 = int.Parse(inputstring4);

            Console.WriteLine("Введите Ваш вес, кг: ");
            string inputstring5 = Console.ReadLine();
            int MassNumber5 = int.Parse(inputstring5);
                        
            Console.WriteLine("Имя: " + NameNumber1 + ", " + "Фамилия: " + FamilyNumber2 + ", " 
            + "Возраст: " + AgeNumber3 + ", " + "Рост, см: " + LongNumber4 + ", " + "Вес, кг: " + MassNumber5);

            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост, см: {3}, Вес, кг: {4}", 
            NameNumber1, FamilyNumber2, AgeNumber3, LongNumber4, MassNumber5);

            Console.WriteLine($"Имя: {NameNumber1}, Фамилия: {FamilyNumber2}, Возраст: {AgeNumber3}, Рост, см: {LongNumber4}, Вес, кг: {MassNumber5}");
            
            Console.WriteLine("==================================================================================");
            /*2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
            где m — масса тела в килограммах, h — рост в метрах.*/

            Console.WriteLine("ЗАДАНИЕ 2");
            Console.WriteLine("ИНДЕКС МАССЫ ТЕЛА:" + Environment.NewLine);

            Console.WriteLine("Введите Ваш рост, см: ");
            string inputstringlong = Console.ReadLine();
            float h = float.Parse(inputstringlong);

            Console.WriteLine("Введите Ваш вес, кг: ");
            string inputstringmass = Console.ReadLine();
            float m = float.Parse(inputstringmass);
                        
            float I = m / ((h / 100) * (h / 100));
            Console.WriteLine("Ваш индекс массы тела равен: " + I);
                        
            Console.WriteLine("==================================================================================");

            /*3.
            а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
            по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f 
            (с двумя знаками после запятой);*/

            Console.WriteLine("ЗАДАНИЕ 3, а");
            Console.WriteLine("РАСЧЁТ РАССТОЯНИЯ МЕЖДУ ТОЧКАМИ:" + Environment.NewLine);

            Console.WriteLine("Введите координату первой точки по оси X: ");
            string inputX1 = Console.ReadLine();
            double X1 = double.Parse(inputX1);

            Console.WriteLine("Введите координату первой точки по оси Y: ");
            string inputY1 = Console.ReadLine();
            double Y1 = double.Parse(inputY1);

            Console.WriteLine("Введите координату второй точки по оси X: ");
            string inputX2 = Console.ReadLine();
            double X2 = double.Parse(inputX2);

            Console.WriteLine("Введите координату второй точки по оси Y: ");
            string inputY2 = Console.ReadLine();
            double Y2 = double.Parse(inputY2);            

            double r = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine("Расстояние между точками равно: " + "{0:0.00}", r);

            Console.WriteLine("==================================================================================");
            Console.WriteLine("ЗАДАНИЕ 3, б" + Environment.NewLine);

            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

            Distance();
            
            Console.WriteLine("==================================================================================");

            /*4.Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            а) с использованием третьей переменной;
            */
            Console.WriteLine("ЗАДАНИЕ 4, а");
            Console.WriteLine("ОБМЕН ЧИСЛАМИ:" + Environment.NewLine);

            Console.WriteLine("Введите первое число для обмена: ");
            string exchange1 = Console.ReadLine();
            int EX1 = int.Parse(exchange1);

            Console.WriteLine("Введите второе число для обмена: ");
            string exchange2 = Console.ReadLine();
            int EX2 = int.Parse(exchange2);

            int EX3;

            EX3 = EX1;
            EX1 = EX2;
            EX2 = EX3;
                        
            Console.WriteLine(EX1 + ", " + EX2);

            Console.WriteLine("==================================================================================");
            //б) *без использования третьей переменной.
            Console.WriteLine("ЗАДАНИЕ 4, б" + Environment.NewLine);

            (EX1, EX2) = (EX2, EX1);

            Console.WriteLine(EX1 + ", " + EX2);
                        
            Console.WriteLine("==================================================================================");

            /*5.
            а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.*/

            Console.WriteLine("ЗАДАНИЕ 5, а");
            Console.WriteLine("ВЫВОД ИМЕНИ, ФАМИЛИИ, ГОРОДА:" + Environment.NewLine);

            Console.WriteLine("Введите Ваше имя: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию: ");
            string Family = Console.ReadLine();

            Console.WriteLine("Введите Ваш город проживания: ");
            string Town = Console.ReadLine();
                        
            Console.WriteLine("Ваше имя: " + Name + ", " + "Ваша фамилия: " + Family + ", " + "Ваш город проживания: " + Town);
                        
            Console.WriteLine("==================================================================================");

            //б) Сделать задание, только вывод организовать в центре экрана.
            Console.WriteLine("ЗАДАНИЕ 5, б" + Environment.NewLine);

            string YourName = "Ваше имя: " + Name + ", " + "Ваша фамилия: " + Family + ", " + "Ваш город проживания: " + Town;            

            Console.Write(new string(' ', (Console.WindowWidth - YourName.Length) / 2));

            Console.WriteLine(YourName);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("==================================================================================");

            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
            Console.WriteLine("ЗАДАНИЕ 5, в" + Environment.NewLine);

            
            string YourName2 = "Ваше имя: " + Name + ", " + "Ваша фамилия: " + Family + ", " + "Ваш город проживания: " + Town;
            Print(YourName2, (Console.WindowWidth / 2 - YourName2.Length / 2), (Console.WindowHeight / 2) + 75);

            Console.WriteLine("==================================================================================");

            Console.ReadLine();
        }
    }
}
