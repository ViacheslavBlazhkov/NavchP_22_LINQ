using System;
using System.Linq;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[20];
            Random rand = new Random();

            Console.WriteLine("Array:");
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = rand.Next(-100, 100);
                Console.Write($"{myArr[i]} ");
            }
            Console.WriteLine("\n");

            myArr[6] = 0;

            // LINQ
            // 1
            Console.WriteLine("LINQ:");
            var x = (from arr in myArr
                    where (arr != 0)
                    select arr).Count();

            Console.WriteLine($"Number Count = {x}");

            // 2
            var y = from arr in myArr
                    where (arr > 10 && arr < 20)
                    select arr;

            Console.Write("More than 10 & Less than 20: ");
            foreach(int a in y)
                Console.Write($"{a} ");
            Console.WriteLine("\n");

            // Lambda
            // 1
            Console.WriteLine("Lambda: ");
            var z = myArr.Count(num => num != 0);
            Console.WriteLine($"Number Count = {z}");

            // 2
            var p = myArr.Where(num => num > 10 && num < 20);
            Console.Write("More than 10 & Less than 20: ");
            foreach (int a in p)
                Console.Write($"{a} ");
            Console.WriteLine("\n");
        }
    }
}
