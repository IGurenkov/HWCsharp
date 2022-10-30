using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{   

    public class Sample
    {
        public int Param { get; set; }

        public void Run(int a, int b)
        {
            Console.WriteLine($"Run {a} ... {b} ...");
            Console.WriteLine(a + b);
        }
    }

    internal class Sample01
    {
        static void Main(string[] args)
        {
            Sample sample1 = new Sample();
            sample1.Param = 10;

            Sample sample2 = new Sample();
            sample2.Param = -30;

            Type type02 = typeof(Sample);

            Type type01 = sample2.GetType();

                       
        

            PropertyInfo propertyInfo = type01.GetProperty("Param");
            if (propertyInfo == null)
                return;

            if (propertyInfo.CanRead)
            {
                int paramValue = (int)propertyInfo.GetValue(sample2);
                Console.WriteLine($"value -> {paramValue}");
            }

            if (propertyInfo.CanWrite)
            {
                propertyInfo.SetValue(sample2, 50);
            }

            if (propertyInfo.CanRead)
            {
                int paramValue = (int)propertyInfo.GetValue(sample2);
                Console.WriteLine($"value -> {paramValue}");
            }

            foreach(MethodInfo methodInfo in type01.GetMethods())
            {
                if (methodInfo.Name == "Run")
                {
                    methodInfo.Invoke(sample1, new object[] { 5, 12});

                    break;
                }
            }
            //ДОМАШНЕЕ ЗАДАНИЕ
            //1. С помощью рефлексии выведите все свойства структуры DateTime.
            Console.WriteLine("\nЗАДАНИЕ 1 - РЕФЛЕКСИЯ.\n");
              

            var date1 = new DateTime(2022, 10, 26, 20, 35, 44);
            Console.WriteLine(date1);

            Type TYPE1 = date1.GetType();
            Type TYPE2 = typeof(DateTime);
            
            
            Console.WriteLine(TYPE1);
            Console.WriteLine(TYPE2);

            PropertyInfo[] propertyInfos = TYPE1.GetProperties();
            Console.WriteLine("\nСВОЙСТВА СТРУКТУРЫ DateTime С ПОМОЩЬЮ GetProperties():\n");
            for (int i = 0; i < propertyInfos.Length; i++)
            {
                Console.WriteLine(propertyInfos[i].ToString());
            }
            Console.WriteLine("\nСВОЙСТВА СТРУКТУРЫ DateTime С ПОМОЩЬЮ GetMethods():\n");
            foreach (MethodInfo methodInfo2 in TYPE1.GetMethods())
            {
                Console.WriteLine(methodInfo2.ToString());
            }

            Console.ReadKey();
        }
    }
}
