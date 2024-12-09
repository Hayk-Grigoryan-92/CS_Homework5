using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = int.Parse(Console.ReadLine());

            int x = 0;

            while (num > 0)
            {
                x = x * 10 + num % 10;
                num = num / 10;
            }

            Console.WriteLine(x);
           */

            /*
            int num = int.Parse(Console.ReadLine());
            float x = 1;
            double sum = 0;
            
            while(x<= num)
            {
                sum =sum + x / num;
                num--;
                
            }
            Console.WriteLine(sum);
            */

            /*
            int x = 100;
            int y = 200;
            int quantity = 0;
            int result = 0;

            while (x < y)
            {
                if (x % 9 == 0)
                {
                    result = result + x;
                    quantity++;
                };
                x++;
            }

            Console.WriteLine(result);
            Console.WriteLine(quantity);
            */

            int i = 0;
            int j = 0;

            //int num = int.Parse(Console.ReadLine());

            /* քառակուսի
             * 
            while (i < num)
            {
                while (j < num)
                {
                    Console.Write("* ");
                    j++;
                }
                j = 0;
                Console.WriteLine();
                i++;
            }
            */

            /*  Դատարկ քառակուսի
             *  
            int num = int.Parse(Console.ReadLine());
            while (i < num)
            {
                while (j < num)
                {
                    if(i == 0 || i == num - 1 || j == 0 || j == num - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    j++;

                }
                j = 0;
                Console.WriteLine();
                i++;
            }
            */


            // եռանկյունի
            /*
            int num = int.Parse(Console.ReadLine());
            while (i < num)
            {
                while (j <= i)
                {
                    Console.Write("* ");
                    j++;
                }
                j = 0;

                Console.WriteLine();
                i++;
            }
            */

            /*
            int num = int.Parse(Console.ReadLine());
            while (i < num)
            {
                while (j < num-i)
                {
                    Console.Write("* ");
                    j++;
                }
                j = 0;

                Console.WriteLine();
                i++;
            }
            */

            // ուղղանկյուն
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            while (i < num1)
            {
                while (j < num2)
                {
                    if (i == 0 || i == num1 - 1 || j == 0 || j == num2 - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    j++;

                }
                j = 0;
                Console.WriteLine();
                i++;
            }

        }
    }
}
