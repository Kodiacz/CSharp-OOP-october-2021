using System;
using System.Collections.Generic;
using System.Text;

namespace _2._4_PizzaCalories
{
    public class Topping
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 50;

        private Dictionary<string, double> toppingType = new Dictionary<string, double>()
        {
            {"meat", 1.2 },
            {"veggies", 0.8 },
            {"cheese", 1.1 },
            {"sauce", 0.9 }
        };

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get { return type; }
            set
            {
                if (!toppingType.ContainsKey(value.ToLower()))
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }

                type = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set 
            { 
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new Exception($"{Type} weight should be in the range [1..50].");
                }

                weight = value; 
            }
        }

        public double CalculateCalories
            => Weight * 2 * toppingType[Type.ToLower()];
    }
}

