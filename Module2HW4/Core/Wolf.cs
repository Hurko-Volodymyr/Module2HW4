using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Wolf : Predator, IJumpable
    {
        public Wolf(string name, int age) : base(name, age)
        {
        }

        public override int GetMoveSpeed()
        {
            return 65;
        }

        public override int GetPower()
        {
            return 10;
        }

        public void Jump()
        {
            Console.WriteLine("I can jump!"); ;
        }
    }
}
