using System;
using System.Collections.Generic;
using System.Text;

namespace _2._6FoodShortage
{
    public interface IBuyer
    {
        public int Food { get; set; }

        public int BuyFood();
    }
}
