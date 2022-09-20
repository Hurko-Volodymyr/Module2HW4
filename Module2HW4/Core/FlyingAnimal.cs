using PracticeSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
   public abstract class FlyingAnimal : Animal
    {
        protected FlyingAnimal(string name, int age) : base(name, age)
        {
        }

        public abstract int GetFlyingHigh();
        public abstract int GetFlyingSpeed();

        public override void Move()
        {
            Console.WriteLine($"{base.Name} am flying!!!");
        }
    }
}
