using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Lion : Predator, IJumpable
    {
        public Lion(string name, int age) : base(name, age)
        {
        }

        public override int GetMoveSpeed()
        {
            return 60;
        }

        public override int GetPower()
        {
            return 100;
        }

        public void Jump()
        {
            Console.WriteLine("I can jump!!"); ;
        }
    }
}
