using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RhombusOfStars
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int row = 2; row <= n; row++)
            {
                Console.Write(new string(' ', n - row + 1));
                Console.Write("*");
                for (int i = 2; i < row; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (int j = n; j >= 1; j--)
            {
                Console.Write(new string(' ', n - j));
                Console.Write("*");
                for (int k = 1; k < j; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
