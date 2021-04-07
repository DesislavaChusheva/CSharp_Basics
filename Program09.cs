using System;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            Double PricePerSquareMeter = 7.61;
            Double SquareMeters = Double.Parse(Console.ReadLine());
            Double WholePrice = SquareMeters * PricePerSquareMeter;
            Console.WriteLine($"The final price is: {WholePrice - WholePrice * 0.18} lv.");
            Console.WriteLine($"The discount is: {WholePrice * 0.18} lv.");
        }
    }
}
