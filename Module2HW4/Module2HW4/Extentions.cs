using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace PracticeSolution
{
    public static class Extentions
    {
        public static string GetAgeAsString(this Animal animal)
        {
            return (animal.Age).ToString();
        }
        public static bool IsThisIosif(this string Name)
        {
            return Name == "Иосиф";
        }
        public static void WriteAnimal(this Animal animal)
        {
            Console.WriteLine($"Имя: {animal.Name}, возраст(лет): {(animal.Age)}.");
        }
    }
}
