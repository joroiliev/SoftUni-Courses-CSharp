using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int number = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());

                sum += number;

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            if (maxNumber == sum - maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber - (sum - maxNumber))}");
            }
        }
    }
}
