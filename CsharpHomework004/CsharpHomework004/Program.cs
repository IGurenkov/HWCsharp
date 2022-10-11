using System;
using System.Security.Principal;
using System.IO;
using System.Linq;

namespace CsharpHomework004
{
    /*1. а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера 
         и заполняющий массив числами от начального значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, 
         метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений), метод Multi, 
         умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.*/

        //б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки

        //2. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.Создайте структуру Account, содержащую Login и Password.

    internal class Program
    {
        static void Main(string[] args)
        {
            bool Loop = true;
            while (Loop)
            {
                Console.WriteLine("\n1 - ЗАПОЛНЕНИЕ МАССИВА С ЗАДАННЫМ ШАГОМ.");
                Console.WriteLine("\n2 - СУММА ВСЕХ ЭЛЕМЕНТОВ МАССИВА.");
                Console.WriteLine("\n3 - НОВЫЙ МАССИВ С ИЗМЕНЁННЫМИ ЗНАКАМИ.");
                Console.WriteLine("\n4 - УМНОЖЕНИЕ МАССИВА НА ОПРЕДЕЛЁННОЕ ЧИСЛО.");
                Console.WriteLine("\n5 - НАХОЖДЕНИЕ КОЛИЧЕСТВА МАКСИМАЛЬНЫХ ЭЛЕМЕНТОВ В МАССИВЕ.");
                Console.WriteLine("\n6 - ПРОВЕРКА ЛОГИНА И ПАРОЛЯ С ПОМОЩЬЮ МАССИВА И ФАЙЛА.");
                Console.WriteLine("\n7 - ПРОВЕРКА ЛОГИНА И ПАРОЛЯ С ПОМОЩЬЮ СТРУКТУРЫ И МАССИВА.");
                Console.WriteLine("\n0 - ВЫХОД.");


                Console.WriteLine("\nВЫБЕРИТЕ ДЕЙСТВИЕ И НАЖМИТЕ ENTER: ");
                if (int.TryParse(Console.ReadLine(), out int Sw))
                {
                    switch (Sw)
                    {
                        case 1:                            
                            Console.WriteLine("ЗАПОЛНЕНИЕ МАССИВА С ЗАДАННЫМ ШАГОМ:\n");
                            int Num;
                            Console.WriteLine("\nЗАДАЙТЕ ШАГ ЗАПОЛНЕНИЯ МАССИВА: ");
                            int.TryParse(Console.ReadLine(), out Num);
                            Console.WriteLine("МАССИВ: ");
                            IlyaArray.Myarray array = new IlyaArray.Myarray(10, Num);

                            Console.WriteLine("\n");
                            break;

                        case 2:
                            Console.WriteLine("\nСУММА ВСЕХ ЭЛЕМЕНТОВ МАССИВА:\n");
                            Console.WriteLine("МАССИВ: ");
                            IlyaArray.Myarray array2 = new IlyaArray.Myarray(10, 3);
                            Console.WriteLine("\nСУММА МАССИВА: " + array2.Sum + "\n");
                            break;

                        case 3:
                            Console.WriteLine("НОВЫЙ МАССИВ С ИЗМЕНЁННЫМИ ЗНАКАМИ:\n");
                            Console.WriteLine("МАССИВ: ");
                            IlyaArray.Myarray array3 = new IlyaArray.Myarray(10, 3);
                            Console.WriteLine("\nМАССИВ С ИЗМЕНЁННЫМ ЗНАКОМ: ");
                            IlyaArray.Myarray array4 = array3.Inverse();
                            break;

                        case 4:
                            Console.WriteLine("УМНОЖЕНИЕ МАССИВА НА ОПРЕДЕЛЁННОЕ ЧИСЛО:\n");
                            Console.WriteLine("МАССИВ: ");
                            IlyaArray.Myarray array5 = new IlyaArray.Myarray(10, 3);
                            Console.WriteLine("\nВВЕДИТЕ ЧИСЛО, НА КОТОРОЕ УМНОЖИТЬ МАССИВ: ");
                            int Numbers;
                            int.TryParse(Console.ReadLine(), out Numbers);
                            Console.WriteLine("\nМАССИВ УМНОЖЕННЫЙ НА: " + Numbers);
                            array5.Multi(Numbers);
                            Console.WriteLine("\n");                            
                            break;
                        case 5:
                            Console.WriteLine("НАХОЖДЕНИЕ КОЛИЧЕСТВА МАКСИМАЛЬНЫХ ЭЛЕМЕНТОВ В МАССИВЕ:\n");
                            Console.WriteLine("МАССИВ: ");
                            IlyaArray.Myarray array6 = new IlyaArray.Myarray(10, 3);
                            Console.WriteLine(array6.MaxCount + "\n");
                            break;

                        case 6:
                            Console.WriteLine("ПРОВЕРКА ЛОГИНА И ПАРОЛЯ С ПОМОЩЬЮ МАССИВА И ФАЙЛА:\n");

                            string[] file = File.ReadAllLines("C:\\Users\\user\\source\\repos\\CsharpHomework004\\LogPass.txt");
                            string login = file[0];
                            string password = file[1];
                            int countdown = 3;

                            do
                            {
                                Console.Write("Login: ");
                                string Login = Console.ReadLine();
                                Console.Write("Password: ");
                                string Password = Console.ReadLine();

                                if (PassLog(Login, Password) == true)
                                {
                                    Console.WriteLine("Поздравляем! Вход произведён успешно!\n");
                                    break;
                                }
                                else
                                {
                                    countdown--;
                                    Console.WriteLine("Неверные учётные данные! " + "Попыток ввода осталось: " + countdown + "\n");
                                }

                            } while (countdown != 0);
                            bool PassLog(string userLogin, string userPassword)
                            {
                                if (userLogin == login && userPassword == password)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            break;
                        case 7:
                            Console.WriteLine("ПРОВЕРКА ЛОГИНА И ПАРОЛЯ С ПОМОЩЬЮ СТРУКТУРЫ И МАССИВА:\n");

                            string[] file2 = new string[2];
                            file2[0] = IlyaArray.UserPassLog.Login;
                            file2[1] = IlyaArray.UserPassLog.Password;
                            int countdown2 = 3;

                            do
                            {
                                Console.Write("Login: ");
                                string Login2 = Console.ReadLine();
                                Console.Write("Password: ");
                                string Password2 = Console.ReadLine();

                                if (IlyaArray.UserPassLog.PassLogStruct(Login2, Password2))
                                {
                                    Console.WriteLine("Поздравляем! Вход произведён успешно!\n");
                                    break;
                                }
                                else
                                {
                                    countdown2--;
                                    Console.WriteLine("Неверные учётные данные! " + "Попыток ввода осталось: " + countdown2 + "\n");
                                }

                            } while (countdown2 != 0);
                            break;
                        default:                            
                            Loop = false;
                            break;
                    }
                }
            }
        }
    }
}
//Тут я совместил и массив и структуру
/*string[] file = File.ReadAllLines ("C:\\Users\\user\\source\\repos\\CsharpHomework004\\LogPass.txt");
IlyaArray.UserPassLog.Login = file[0];
IlyaArray.UserPassLog.Password = file[1];
int countdown = 3;

do
{
    Console.Write("Login: ");
    string Login = Console.ReadLine();
    Console.Write("Password: ");
    string Password = Console.ReadLine();

    if(PassLog(Login, Password) == true)
    {
        Console.WriteLine("Поздравляем! Вход произведён успешно!\n");                    
        break;
    }
    else
    {
        countdown--;
        Console.WriteLine("Неверные учётные данные! " + "Попыток ввода осталось: " + countdown + "\n");
    }

} while (countdown != 0);
bool PassLog(string userLogin, string userPassword)
{                
    if (userLogin == IlyaArray.UserPassLog.Login && userPassword == IlyaArray.UserPassLog.Password)
    {
        return true;
    }
    else
    {
        return false;
    }

}*/