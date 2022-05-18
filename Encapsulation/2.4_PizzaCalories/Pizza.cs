using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._4_PizzaCalories
{
    public class Pizza
    {
        private const int MinLength = 15;
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            this.dough = dough;
            toppings = new List<Topping>();
        }

        public string Name
        {
            get { return name; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value) || value.Length > MinLength)
                {
                    throw new Exception($"Pizza name should be between 1 and 15 symbols.");
                }

                name = value; 
            }
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count > 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
        }

        public double TotalCalories()
        {
            double totalToppingCalories = 0;
            toppings.ForEach(x => totalToppingCalories += x.CalculateCalories);

            return this.dough.CalculateCalories + totalToppingCalories;
        }
            

    }
}
