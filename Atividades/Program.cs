using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario = 3300.0;
            double aliquota = 0.0;

            if (salario > 1900.0)
            {
                if (salario < 2800.0)
                    aliquota = 0.075;
                if (salario < 3750.0)
                    aliquota = 0.15;
                if (salario < 4664.0)
                    aliquota = 0.225;
            }

            Console.WriteLine("O valor do salário menos IR é igual a R$" +
                salario * (1.0 - aliquota) + ", sendo a alíquota de " +
                aliquota * 100.0 + "%.");

            Console.ReadLine(); 
        }
    }
}
