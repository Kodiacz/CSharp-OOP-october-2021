using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage : Product
    {
        public Beverage(string name, decimal price, double mililleters) : base(name, price)
        {
            Milliliters = mililleters;
        }
        public double Milliliters { get; set; }
    }
}
