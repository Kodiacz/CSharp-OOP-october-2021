using System;
using System.Collections.Generic;
using System.Text;

namespace _2._4_PizzaCalories
{
    public class Dough
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 200;

        private Dictionary<string, double> flourType = new Dictionary<string, double>
        {
            {"white", 1.5 },
            {"wholegrain", 1 }
        };

        private Dictionary<string, double> bakingTechnique = new Dictionary<string, double>
        {
            {"crispy", 0.9 },
            {"chewy", 1.1 },
            {"homemade", 1 }
        };

        private string type;
        private double grams;
        private string technique;

        public Dough(string type, string technique, double grams)
        {
            Type = type;
            Technique = technique;
            Grams = grams;
        }

        public string Type
        {
            get { return type; }
            set
            {
                if (!flourType.ContainsKey(value.ToLower()))
                {
                    throw new Exception("Invalid type of dough.");
                }

                type = value;
            }
        }

        public string Technique
        {
            get { return technique; }
            set 
            {
                if (!bakingTechnique.ContainsKey(value.ToLower()))
                {
                    throw new Exception("Invalid type of dough.");
                }

                technique = value; 
            }
        }

        public double Grams
        {
            get { return grams; }
            set 
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
                }

                grams = value; 
            }
        }

        public double CalculateCalories
            => (2 * Grams) * flourType[Type.ToLower()] * bakingTechnique[Technique.ToLower()];
    }
}
