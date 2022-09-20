using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
   public abstract class Predator:LandAnimal
    {
        protected Predator(string name, int age) : base(name, age)
        {
        }

        public abstract int GetPower();
    }
}
