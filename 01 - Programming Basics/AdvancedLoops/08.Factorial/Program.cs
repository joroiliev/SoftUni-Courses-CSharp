﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int startingNumber = 1;

            for (int i = 1; i <= n; i++)
            {
                startingNumber *= i;
            }
            Console.WriteLine(startingNumber);
        }
    }
}
