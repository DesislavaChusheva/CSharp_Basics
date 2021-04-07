using System;

namespace _06.ConcatenateData
{
    class Program
    {
        static void Main(string[] args)
        {
            String FirstName = Console.ReadLine();
            String LastName = Console.ReadLine();
            int Age = int.Parse(Console.ReadLine());
            String Town = Console.ReadLine();
            Console.WriteLine($"You are {FirstName} {LastName}, a {Age}-years old person from {Town}.");
        }
    }
}
