using PracticeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Section
    {
        private readonly List<Animal> _animals = new ();

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }
        public Animal FindAnimalByName(string name)
        {
            return _animals.FirstOrDefault(animal => animal.Name == name);                
        }

        public List<Animal> SortByAge()
        {
            return _animals.OrderBy(animal => animal.Age).ToList();
        }
    }
}
