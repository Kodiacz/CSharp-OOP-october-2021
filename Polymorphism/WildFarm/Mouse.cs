using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse()
        {
            Weight = 0.10;
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion} {this.FoodEaten}]";
        }
    }
}
