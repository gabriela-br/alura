using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());

            double media = Math.Round(A * (3.5/11) + B * (7.5/11), 5);

            Console.WriteLine("MEDIA = " + media.ToString("0.00000"));
        }
    }
}
