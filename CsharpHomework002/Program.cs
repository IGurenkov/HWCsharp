using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;


namespace CsharpHomework002
{
    internal class Program
    {
        //1.Написать метод, возвращающий минимальное из трёх чисел.
        public static void MinForThreeNumber()
        { 
            Console.WriteLine("Введите число a: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите число b: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите число c: ");
            float c = float.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine("Наименьшее из трёх чисел: " + a + "\n");

            }
            else if (b < a && b < c)
            {
                Console.WriteLine("Наименьшее из трёх чисел: " + b + "\n");
            }
            else
            {
                Console.WriteLine("Наименьшее из трёх чисел: " + c + "\n");
            }
        }
        //2.Написать метод подсчета количества цифр числа.
        public static void TotalSymbol()
        {
            Console.WriteLine("Введите число для подсчёта количества цифр: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Количество цифр в числе: " + ((int)Math.Log10(n) + 1) + "\n");            

        }

        /*4.Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль.На выходе истина, 
        если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). Используя метод 
        проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает 
        его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.*/

        public static bool CheckPassLog()
        {            
            uint countdown = 3;
            while (countdown != 0)
            {
                Console.WriteLine("Введите логин: ");
                string Login = Console.ReadLine();
                Console.WriteLine("Введите пароль: ");
                string Password = Console.ReadLine();
                if (Login == "root" && Password == "GeekBrains")
                {
                    Console.WriteLine("Поздравляем! Вход произведён успешно!\n");
                    return true;
                }

                else if (Login != "root" || Password != "GeekBrains")
                {
                    countdown--;
                    Console.WriteLine("Неверный пароль! " + "Попыток ввода осталось: " + countdown + "\n");
                }
            }
            return true;
        }
        /*6. * Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
        «Хорошим» называется число, которое делится на сумму своих цифр.Реализовать подсчёт времени выполнения программы, 
         используя структуру DateTime.*/
        
        public static void GoodNumber()
        {
            DateTime start = DateTime.Now;
            int GoodNumCount = 0;
            int minNum = 1;
            int maxNum = 1000000;
            int temp;
            int testNum;

            for (int Num = minNum; Num <= maxNum; Num++)
            {
                temp = 0;
                testNum = Num;
                while (testNum != 0)
                {
                    temp += testNum % 10;
                    testNum /= 10;
                }                
                if (Num % temp == 0)
                {
                    GoodNumCount++;
                }                
            }
            Console.WriteLine("Количество хороших чисел в диапазоне от 1 до 1 000 000 000: " + GoodNumCount);
            DateTime finish = DateTime.Now;
            Console.WriteLine("Время исполнения программы: " + (finish - start) + "\n");
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("УРОК 2");
            Console.WriteLine("ГУРЕНКОВ ИЛЬЯ АЛЕКСЕЕВИЧ, ПРОГРАММА: Microsoft Visual Studio 2022" + "\n");

            Console.WriteLine("#############################################################################\n");
            //1.Написать метод, возвращающий минимальное из трёх чисел.
            Console.WriteLine("ЗАДАНИЕ 1: Метод, возвращающий минимальное из трёх чисел\n");            

            MinForThreeNumber();

            Console.WriteLine("#############################################################################\n");
            //2.Написать метод подсчета количества цифр числа.
            Console.WriteLine("ЗАДАНИЕ 2: Метод подсчета количества цифр числа\n");

            TotalSymbol();

            //3.С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечетных положительных чисел.

            Console.WriteLine("ЗАДАНИЕ 3: Сумма всех нечетных положительных чисел\n");

            Console.WriteLine("Введите числа: ");

            float Numbers;
            float sumOddNumbers = 0;
            do
            {
                Numbers = float.Parse(Console.ReadLine());
                if (Numbers % 2 != 0 && Numbers > 0)
                {
                    sumOddNumbers += Numbers;
                }
            } 
            while (Numbers != 0);
            
            Console.WriteLine("Сумма всех введёных нечётных положительных чисел: " + sumOddNumbers + "\n");
            Console.WriteLine("#############################################################################\n");

            /*4.Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль.На выходе истина, 
                если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). Используя метод 
                проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает 
                его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.*/

            Console.WriteLine("ЗАДАНИЕ 4: Проверка логина и пароля\n");                        
           
            CheckPassLog();
            
            Console.WriteLine("#############################################################################\n");
            /*5.
            а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли 
            человеку похудеть, набрать вес или всё в норме.
            */
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            Console.WriteLine("ЗАДАНИЕ 5: Индекс массы тела и сообщение о похудении или наборе веса с указанием количества\n");
            
            Console.WriteLine("Введите Ваш рост, см: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите Ваш вес, кг: ");
            float mass = float.Parse(Console.ReadLine());

            float index = mass / ((height / 100) * (height / 100));
            Console.WriteLine("Ваш индекс массы тела равен: " + index);
                        
            if (index < 19)
            {
                Console.WriteLine("Внимание! Низкий индекс, Вам следует набрать " + (19 - index) * (height / 100) * (height / 100) + " кг\n");                
            }
            else if (index >= 19 && index <= 25)
            {
                Console.WriteLine("Ваш вес в норме!\n");
            }
            else if (index > 25 && index <= 30)
            {
                Console.WriteLine("Внимание! Небольшой лишний вес, Вам следует немного похудеть на " + (index - 25) * (height / 100) * (height / 100) + " кг\n");
            }
            else if (index > 30)
            {
                Console.WriteLine("Внимание! У Вас излишний вес, Вам следует похудеть на " + (index - 25) * (height / 100) * (height / 100) + " кг\n");
            }
            Console.WriteLine("#############################################################################\n");
            /*6. * Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
                «Хорошим» называется число, которое делится на сумму своих цифр.Реализовать подсчёт времени выполнения программы, 
                используя структуру DateTime.
                */
            Console.WriteLine("ЗАДАНИЕ 6\n");

            GoodNumber();

            Console.WriteLine("#############################################################################\n");
        }
    }
}