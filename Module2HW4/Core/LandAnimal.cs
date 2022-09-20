using PracticeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class LandAnimal: Animal
    {
        protected LandAnimal(string name, int age) : base(name, age)
        {
        }

        public abstract int GetMoveSpeed();
        public override void Move()
        {
            Console.WriteLine($"{base.Name} is walking!!!");
        }
    }
}
