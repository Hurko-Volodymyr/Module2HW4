using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Tiger : Predator, IJumpable
    {
        public Tiger(string name, int age) : base(name, age)
        {
        }

        public override int GetMoveSpeed()
        {
            return 78;
        }

        public override int GetPower()
        {
            return 50;
        }

        public void Jump()
        {
            Console.WriteLine("I can jump!!"); ;
        }
    }
}
