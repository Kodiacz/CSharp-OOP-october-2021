using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Tiger : Feline
    {
        public Tiger()
        {
            Weight = 1;
        }
        public override void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}
