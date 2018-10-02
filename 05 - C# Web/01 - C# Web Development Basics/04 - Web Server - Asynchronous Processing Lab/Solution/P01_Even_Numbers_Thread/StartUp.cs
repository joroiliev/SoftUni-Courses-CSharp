namespace P01_Even_Numbers_Thread
{
    using System;
    using System.Linq;
    using System.Threading;

    public class StartUp
    {
        public static void Main()
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Thread evens = new Thread(() => PrintEvenNumbers(range[0], range[1]));
            evens.Start();
            evens.Join();
            Console.WriteLine("Thread finished working");
        }

        private static void PrintEvenNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
