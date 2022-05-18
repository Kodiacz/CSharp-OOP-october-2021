using System;
using System.Collections.Generic;

namespace _2._3_ShoppingSpree
{
    public class Person
    {
        private string name;
        private int money;
        private List<Product> bag;

        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty");
                }

                name = value;
            }
        }

        public int Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }

                money = value;
            }
        }

        public void AddToBag(Product product)
        {
            try
            {
                if (money - product.Cost < 0)
                {
                    throw new Exception($"{this.Name} can't afford {product.Name}");
                }

                bag.Add(product);
                Money -= product.Cost;

                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public string Bag
        {
            get
            {
                List<string> names = new List<string>();

                foreach (var product in bag)
                {
                    names.Add(product.Name);
                }

                return string.Join(", ", names);
            }
        }
    }
}
