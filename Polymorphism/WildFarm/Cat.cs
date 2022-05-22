using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Cat : Feline
    {
        public Cat()
        {
            Weight = 0.30;
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
