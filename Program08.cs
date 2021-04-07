using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Double PriceHisDogs = 2.5;
            Double PriceOtherDogs = 4.0;
            int HisDogs = int.Parse(Console.ReadLine());
            int OtherDogs = int.Parse(Console.ReadLine());
            Console.WriteLine($"{HisDogs*PriceHisDogs + OtherDogs*PriceOtherDogs} lv.");
        }
    }
}
