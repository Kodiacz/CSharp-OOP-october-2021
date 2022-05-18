using System;

namespace _2._3_ShoppingSpree
{
    public class Product
    {
        private int cost;
        private string name;

        public Product(string name, int cost )
        {
            Cost = cost;
            Name = name;
        }

        public int Cost
        {
            get { return cost; }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }

                cost = value; 
            }
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

    }
}
