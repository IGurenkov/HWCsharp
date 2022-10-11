using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlyaArray
{
    public class Myarray
    {
        int[] a;
        public Myarray(int n, int m)
        {
            a = new int[n];
            int j = 0;
            for (int i = 0; i < n; i++, j += m)
            {
                a[i] = j;
                Console.Write(a[i] + "  ");
            }
        }
        public Myarray(int[] a)
        {
            this.a = a;
        }



        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int for_sum in a)
                {
                    sum += for_sum;
                }
                return sum;
            }
        }

        public Myarray Inverse()
        {

            int[] Arr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                Arr[i] = a[i] * (-1);
                Console.Write(Arr[i] + "  ");
            }
            Console.Write("\n\n");
            return new Myarray(Arr);

        }
        public void Multi(int n)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * n;
                Console.Write(a[i] + "  ");
            }
        }
        public int MaxCount
        {
            get
            {
                int count = 0;
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                }
                count++;
                Console.Write("\nМАКСИМАЛЬНЫЙ ЭЛЕМЕНТ МАССИВА: " + max + "\nКОЛИЧЕСТВО МАКСИМАЛЬНЫХ ЭЛЕМЕНТОВ: ");
                return count;
            }
        }

    }
    public struct UserPassLog
    {
        public static string Login = "root";
        public static string Password = "GeekBrains";

        public static bool PassLogStruct(string userLogin2, string userPassword2)
        {
            if (userLogin2 == UserPassLog.Login && userPassword2 == UserPassLog.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
    

