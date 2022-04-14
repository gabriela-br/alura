using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;

            for (int x = 1; x <= 10; x++)
            {
                fatorial *= x;
                Console.WriteLine(" O fatorial de " + x + " é igual a " + fatorial + ".");
            }

            Console.ReadLine();
        }
    }
}
