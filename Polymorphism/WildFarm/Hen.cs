using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        public Hen()
        {
            Weight = 0.35;
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
