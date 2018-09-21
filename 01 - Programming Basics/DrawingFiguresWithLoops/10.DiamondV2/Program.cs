using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.DiamondV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < Math.Ceiling(n / 2.0); i++)
            {
                if (n % 2 == 0 && i == 0)
                {
                    Console.WriteLine("{0}**{0}", new string('-', (n / 2) - 1));
                }
                else if (n % 2 != 0 && i == 0)
                {
                    Console.WriteLine("{0}*{0}", new string('-', n / 2));
                }

                if (i > 0)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', ((n - 1) / 2) - i), new string('-', i * 2));
                }
            }
        }
    }
}
