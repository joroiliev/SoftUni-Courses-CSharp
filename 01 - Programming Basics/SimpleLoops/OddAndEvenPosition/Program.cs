using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter \"a\":");  \ \ - escapes string
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter \"b\":");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a > b ? "A is greater" : "B is greater");*/



            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            double number = 0;

            for (int i = 1; i <= n; i++)
            {
                number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;

                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
                else
                {
                    oddSum += number;

                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                }
            }
            Console.WriteLine($"OddSum= {oddSum},");
            if (oddMin == double.MaxValue)
                Console.WriteLine("OddMin= No,");
            else
                Console.WriteLine($"OddMin = {oddMin},");

            if (oddMax == double.MinValue)
                Console.WriteLine("OddMax= No,");
            else
                Console.WriteLine($"OddMax = {oddMax},");

            Console.WriteLine($"EvenSum= {evenSum},");
            if (evenMin == double.MaxValue)
                Console.WriteLine("EvenMin= No,");
            else
                Console.WriteLine($"EvenMin = {evenMin},");

            if (evenMax == double.MinValue)
                Console.WriteLine("EvenMax= No,");
            else
                Console.WriteLine($"EvenMax = {evenMax}");
        }   
    }
}
