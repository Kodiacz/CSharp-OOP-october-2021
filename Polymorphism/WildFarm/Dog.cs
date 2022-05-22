using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        public Dog()
        {
            Weight = 0.40;
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Woof");
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion} {this.FoodEaten}]";
        }
    }
}
