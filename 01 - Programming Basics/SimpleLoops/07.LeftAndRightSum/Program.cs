﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());

                leftSum += firstNumber;
            }
            for (int i = 1; i <= n; i++)
            {
                int secondNumber = int.Parse(Console.ReadLine());

                rightSum += secondNumber;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {Math.Abs(leftSum)}");
            }
            else
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
        }
    }
}
