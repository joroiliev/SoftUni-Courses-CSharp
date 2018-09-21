using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int lastDigit = 0;
            int sum = 0;

            while (n > 0)
            {
                lastDigit = n % 10;
                sum += lastDigit;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
