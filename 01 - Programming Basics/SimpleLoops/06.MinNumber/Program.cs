using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers < minNumber)
                    minNumber = numbers;
            }
            Console.WriteLine(minNumber);
        }
    }
}
