using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine(isPrime ? "Prime" : "Not Prime");
            }
        }
    }
}
