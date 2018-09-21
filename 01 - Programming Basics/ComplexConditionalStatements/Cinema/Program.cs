using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double ticketPrice = 0.0;

            if (projection == "Premiere")
                ticketPrice = r * c * 12.00;
            
            else if (projection == "Normal")
                ticketPrice = r * c * 7.50;
            
            else if (projection == "Discount")
                ticketPrice = r * c * 5.00;

            Console.WriteLine("{0:f2}", ticketPrice);
        }
    }
}
