using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio = Convert.ToDouble(Console.ReadLine());
            double n = 3.14159;
            double area = Math.Round(n * Math.Pow(raio,2),4);

            Console.WriteLine("A=" + area.ToString("0.0000"));
        }
    }
}