using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0102hw
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 100 || number < 1)
            {
                Console.WriteLine("Error");
            }
            else
            {
                if (number % 3 == 0 && number % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 3 != 0 && number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine($"{number}");
                }
            }
            #endregion

            #region 2
            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter percent:");
            int percent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Result:{number * percent / 100}");
            #endregion

            #region 3
            Console.WriteLine("Enter 4 numbers:");
            string a1 = Console.ReadLine();
            string a2 = Console.ReadLine();
            string a3 = Console.ReadLine();
            string a4 = Console.ReadLine();
            a1 += a2 + a3 + a4;
            number = Convert.ToInt32(a1);
            Console.WriteLine($"Result:{number}");
            #endregion

             #region 4
            int n1, n2, n3, n4, n5, n6;
            Console.WriteLine("Enter a six-digit number:");
            string numstr = Console.ReadLine();
            if (numstr.Length != 6)
            {
                Console.WriteLine("Error");
            }
            else
            {
                int num = Convert.ToInt32(numstr);
                n1 = num % 10;
                n2 = num % 100 / 10;
                n3 = num % 1000 / 100;
                n4 = num % 10000 / 1000;
                n5 = num % 100000 / 10000;
                n6 = num / 100000;
                int[] arr = new int[] { n1, n2, n3, n4, n5, n6 };
                Console.WriteLine("Enter 2 digits (1-6) :");
                int swap1 = Convert.ToInt32(Console.ReadLine());
                int swap2 = Convert.ToInt32(Console.ReadLine());
                int temp = arr[swap1 - 1];
                arr[swap1 - 1] = arr[swap2 - 1];
                arr[swap2 - 1] = temp;
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i]}");
                }
                Console.WriteLine();
            }
            #endregion

            #region 5
            Console.WriteLine("Enter a date, i.e 22.12.2021:");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            if (date.Month == 1 || date.Month == 12 || date.Month == 2)
            {
                Console.WriteLine("Winter");
            }
            else if (date.Month == 3 || date.Month == 4 || date.Month == 5)
            {
                Console.WriteLine("Spring");
            }
            else if (date.Month == 6 || date.Month == 7 || date.Month == 8)
            {
                Console.WriteLine("Summer");
            }
            else
            {
                Console.WriteLine("Fall");
            }
            Console.WriteLine(date.DayOfWeek);

            #endregion

            #region 6

            Console.WriteLine("Enter temperature:");
            int temperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C to F(1) or F to C(2):");
            string converttype = Console.ReadLine();
            switch (converttype)
            {
                case "1":
                    Console.WriteLine(temperature * 1.8 + 32);
                    break;
                case "2":
                    Console.WriteLine((temperature - 32) / 1.8);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            #endregion

            #region 7

            Console.WriteLine("Enter a range:");
            int bordermin = Convert.ToInt32(Console.ReadLine());
            int bordermax = Convert.ToInt32(Console.ReadLine());
            if (bordermax < bordermin)
            {
                int temp = bordermax;
                bordermax = bordermin;
                bordermin = temp;
            }
            for(int i = bordermin; i < bordermax; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} ");
                }
            }

            #endregion
        }
    }
}
