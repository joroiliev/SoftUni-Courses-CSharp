using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int sum = 0;

            for (int currentElement = 0; currentElement < text.Length; currentElement++)
            {
                //Console.WriteLine(text[currentElement]);
                char symbol = text[currentElement];

                switch (symbol)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
