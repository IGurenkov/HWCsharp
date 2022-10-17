using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace CsharpHomework005
{
    /*2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
        а) Вывести только те слова сообщения, которые содержат не более n букв.
        б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        в) Найти самое длинное слово сообщения.
        г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.*/

    public static class Message
    {
        private static string[] separators = { " ", ",", ".", "-", "!", "?", ";", ":", "\n", "\t", "«", "»" };
        public static string message = "Первый роман в серии книг про юного волшебника Гарри Поттера, написанный Дж. К. Роулинг. " +
            "\nВ нём рассказывается, как Гарри узнает, что он волшебник, встречает близких друзей и немало врагов " +
            "\nв Школе Чародействаааа и Волшебствааааа Хогвартс.";

        //Или лучше было сообщение в конструктор засунуть?

        //а) Вывести только те слова сообщения, которые содержат не более n букв.
        public static void nLetter()
        {                        
            if (int.TryParse(Console.ReadLine(), out int n))
            {                
                Console.WriteLine("Слова из " + n + " букв:");

                string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length == n)
                    {
                        Console.WriteLine(words[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Вы ввели некорректные данные! Возврат в начальное меню!" + "\n");
            }
        }
        //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        public static void DeleteWord()
        {
            
            char n = char.Parse(Console.ReadLine());
            Console.WriteLine("Сообщение без удалённых слов: " + "\n");

            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string W;
            for (int i = 0; i < words.Length; i++)
            {
                /*if (words[i][words[i].Length - 1] != n)
                {
                    Console.WriteLine(words[i]);          ===Дайте пожалуйста комментарий, можно ли было сделать так?===         
                }*/
                if (words[i][words[i].Length - 1] == n)
                {
                    words[i] = words[i].Remove(0, words[i].Length);
                }
            }
            W = string.Join(" ", words);
            Console.WriteLine(W);
        }
        //в) Найти самое длинное слово сообщения.
        public static string LongWord()
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            
            string MaxWord = words[0];
            int max = words[0].Length;
            foreach (string word in words)
            {
                if (word.Length > max)         //Дайте пожалуйста комментарий, как правильно сделать так, чтобы выводились все длинные слова?
                {
                    max = word.Length;
                    MaxWord = word;
                }
            }
            Console.WriteLine("\nСамое длинное слово: " + MaxWord);
            return MaxWord;
        }
        //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        //public static void StringLongWord()
        static public StringBuilder StringLongWord()
        { 
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder SB = new StringBuilder();
            int max = Message.LongWord().Length;            
            foreach (string word in words)
            {
                if (word.Length == max)
                {
                    SB.Append(word.ToLower() + " ");
                }
            }
            Console.WriteLine("\nПолученная строка самых длинных слов: " + SB);
            return SB;
        }

        //3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
        public static bool PermutationStrings(string str1, string str2)
        {
            str1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(str2.Select(Char.ToUpper).OrderBy(x => x));
            
            Console.WriteLine("Проверяем строки: " + str1 + " и " + str2);

            if (str1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(str2.Select(Char.ToUpper).OrderBy(x => x)) == true)
            {
                Console.WriteLine("Результат: Строки являются перестановкой друг друга.");
            }
            else
            {
                Console.WriteLine("Результат: Строки не являются перестановкой друг друга.");
            }
            return true;
        }

    }
    internal class Program
    {
        /*1. Создать программу, которая будет проверять корректность ввода логина.Корректным логином 
        будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
        при этом цифра не может быть первой.*/

        public static bool CheckPassLog()
        {
            Regex regex = new Regex("^\\D[a-zA-Z0-9]{2,10}$");
            
            uint countdown = 3;
            while (countdown != 0)
            {
                Console.WriteLine("Введите логин: ");
                string Login = Console.ReadLine();
                Console.WriteLine("Введите пароль: ");
                string Password = Console.ReadLine();
                if (regex.IsMatch(Login) && Password == "GeekBrains")
                {
                    Console.WriteLine("Поздравляем! Вход произведён успешно!\n");
                    return true;
                }

                else if (!regex.IsMatch(Login) || Password != "GeekBrains")
                {
                    countdown--;
                    Console.WriteLine("Логин и/или пароль не корректны! " + "Попыток ввода осталось: " + countdown + "\n");
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nУРОК 5.\nСТУДЕНТ: ГУРЕНКОВ ИЛЬЯ АЛЕКСЕЕВИЧ.\nПРОГРАММА: MICROSOFT VISUAL STUDIO 2022.");
            bool Loop = true;
            while (Loop)
            {
                Console.WriteLine("\n1 - ПРОВЕРКА КОРРЕКТНОСТИ ЛОГИНА.");
                Console.WriteLine("\n2 - ВЫВЕСТИ СЛОВА СОДЕРЖАЩИЕ N БУКВ.");
                Console.WriteLine("\n3 - УДАЛИТЬ СЛОВА, КОТОРЫЕ ЗАКАНЧИВАЮТСЯ НА ЗАДАННУЮ БУКВУ.");
                Console.WriteLine("\n4 - НАЙТИ САМОЕ ДЛИННОЕ СЛОВО.");
                Console.WriteLine("\n5 - СФОРМИРОВАТЬ СТРОКУ ИЗ САМЫХ ДЛИННЫХ СЛОВ.");
                Console.WriteLine("\n6 - ОПРЕДЕЛЕНИЕ ЯВЛЯЕТСЯ ЛИ ОДНА СТРОКА ПЕРЕСТАНОВКОЙ ДРУГОЙ.");
                Console.WriteLine("\n0 - ВЫХОД.");

                Console.WriteLine("\nВЫБЕРИТЕ ДЕЙСТВИЕ И НАЖМИТЕ ENTER: ");
                if (int.TryParse(Console.ReadLine(), out int Sw) && Sw >= 0 && Sw <= 6)
                {
                    switch (Sw)
                    {
                        case 1:
                            Console.WriteLine("Задание 1" + "\n");
                            CheckPassLog();
                            Console.WriteLine("==========================================================================" + "\n");
                            break;
                        case 2:
                            Console.WriteLine("Задание 2а" + "\n");
                            Console.WriteLine("Сообщение: " + Message.message + "\n");
                            Console.WriteLine("Введите число букв в слове для вывода слов:");
                            Message.nLetter();
                            Console.WriteLine("==========================================================================" + "\n");
                            break;
                        case 3:
                            Console.WriteLine("Задание 2б" + "\n");
                            Console.WriteLine("Сообщение до редактирования: " + Message.message + "\n");
                            Console.WriteLine("Введите букву, на которую заканчивается слово, чтобы удалить все слова с этой буквой:");
                            Message.DeleteWord();
                            Console.WriteLine("==========================================================================" + "\n");
                            break;
                        case 4:
                            Console.WriteLine("Задание 2в" + "\n");
                            Console.WriteLine("Сообщение: " + Message.message);
                            Message.LongWord();
                            Console.WriteLine("==========================================================================" + "\n");
                            break;
                        case 5:
                            Console.WriteLine("Задание 2г" + "\n");
                            Console.WriteLine("Сообщение: " + Message.message);
                            Message.StringLongWord();
                            Console.WriteLine("==========================================================================" + "\n");
                            break;                        
                        case 6:
                            Console.WriteLine("Задание 3" + "\n");
                            
                            string str1 = "рарапрпрра";
                            string str2 = "рарарппррп";

                            string str3 = "рарап";
                            string str4 = "парар";

                            Message.PermutationStrings(str1, str2);
                            Console.WriteLine("\n");
                            Message.PermutationStrings(str3, str4);
                            Console.WriteLine("==========================================================================" + "\n");
                            break;
                        default:
                            Loop = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректные данные! Программа завершена!" + "\n");                    
                    break;
                }
            }
        }
    }
}