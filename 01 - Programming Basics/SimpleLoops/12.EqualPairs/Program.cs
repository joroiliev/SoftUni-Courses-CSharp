using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstNumber = 0;
            int secondNumber = 0;

            int sum = 0;
            int lastSum = 0;
            int diff = 0;

            for (int i = 0; i < n; i++)
            {
                firstNumber = int.Parse(Console.ReadLine());
                secondNumber = int.Parse(Console.ReadLine());
                sum = firstNumber + secondNumber;

                if (i == 0)
                {
                    lastSum = sum;
                }

                if (lastSum != sum)
                {
                    if (Math.Abs(sum - lastSum) > diff)
                    {
                        diff = Math.Abs(sum - lastSum);  //Math.Max returns largest number
                    }

                    lastSum = sum;
                }
            }

            Console.WriteLine(diff != 0 ? $"No, maxdiff={diff}" : $"Yes, value={lastSum}");
        }
    }
}
