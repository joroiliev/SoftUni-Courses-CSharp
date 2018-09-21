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
            int stars = 10;

            for (int i = 1; i <= stars; i++)
            {
                    Console.WriteLine(new string('*', 10));
            }
        }
    }
}
