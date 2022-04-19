using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());

            double media = A * 0.2 + B * 0.3 + C * 0.5;

            Console.WriteLine("MEDIA = " + media.ToString("0.0"));
        }
    }
}
