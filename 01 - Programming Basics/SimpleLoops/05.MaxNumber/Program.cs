using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers > maxNumber)
                    maxNumber = numbers;

            }
            Console.WriteLine(maxNumber);
            
        }
    }
}
