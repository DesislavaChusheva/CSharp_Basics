using System;

namespace _07.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            // This task isn`t realistic! Trust me, I`m an Architect...
            String Name = Console.ReadLine();
            int ProjectsNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"The architect {Name} will need {ProjectsNumber * 3} hours to complete {ProjectsNumber} project/s.");
        }
    }
}
