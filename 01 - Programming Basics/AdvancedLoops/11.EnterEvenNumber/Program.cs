using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (true)
            {

                try
                {
                    n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {n}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid number!");
                }

                
            } 
        }
    }
}
