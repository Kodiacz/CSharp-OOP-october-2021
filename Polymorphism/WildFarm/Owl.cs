using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl()
        {
            Weight = 0.25;
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
