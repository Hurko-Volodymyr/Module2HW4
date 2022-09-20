using Core;
using PracticeSolution;

namespace Module2HW4
{
    /// <summary>
    /// Main Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Starts the App.
        /// </summary>
        /// <param name="args">console call params.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Сафари парк");
            var lion = new Lion("Иосиф Эдуардович", 3);
            var wolf = new Wolf("Виталий", 6);
            var tiger = new Tiger("Василий", 4);
            var lion1 = new Lion("Иосиф", 10);
            var wolf1 = new Wolf("Витя", 7);
            var tiger1 = new Tiger("Валерий", 1);

            lion.Eat();

            var section = new Section();
            section.AddAnimal(lion);
            section.AddAnimal(lion1);
            section.AddAnimal(wolf);
            section.AddAnimal(wolf1);
            section.AddAnimal(tiger);
            section.AddAnimal(tiger1);

            var sortedSection = section.SortByAge();
            var countSection = sortedSection.Count;

            Console.WriteLine("Животные после сортировки по возрасту: ");
            foreach (var animal in sortedSection)
            {
                animal.WriteAnimal();
            }

            Console.WriteLine($"Количество животных: {countSection}");

            var findedAnimal = section.FindAnimalByName("Василий");
            Console.WriteLine($"Найденное животное: {findedAnimal.Name}");
        }
    }
}