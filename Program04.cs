using System;

namespace _04.InchesToCM
{
    class Program
    {
        static void Main(string[] args)
        {
            double Inches = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Inches * 2.54}");
        }
    }
}
