using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._3_Telephony
{
    public class StationaryPhone : ICallable
    {
        public StationaryPhone(string text)
        {
            this.text = text;
        }

        private string text;

        public void Call()
        {
            if (text.All(x => char.IsDigit(x)))
            {
                string phoneNumber = text;
                Console.WriteLine($"Dialing... {phoneNumber}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
