using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine(1);
                return;
            }


            int lastNumber = 0;

            int firstNumber = 0;
            int secondNumber = 1;

            for (int i = 0; i < n; i++)
            {
                lastNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = lastNumber;
            }
            Console.WriteLine(lastNumber);
        }
    }
}
