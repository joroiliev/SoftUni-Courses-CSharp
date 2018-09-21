using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(counter + " ");

                    if (counter >= n)
                    {
                        Console.WriteLine();
                        return;
                    }


                    counter++;
                }

                Console.WriteLine();
            }
        }
    }
}
