using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PriceTable priceTable = new PriceTable();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(priceTable[i]);
            }

            Console.WriteLine("Введите номер товара для поиска:");
            string product = Console.ReadLine();

            Console.WriteLine(priceTable[product]);

            // Delay.
            Console.ReadKey();
        }
    }
}
