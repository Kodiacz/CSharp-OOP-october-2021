using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._3_Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public Smartphone(string text)
        {
            this.text = text;
        }

        private string text;

        public void Browse()
        {
            if (text.All(x => !char.IsDigit(x)) && !string.IsNullOrWhiteSpace(text))
            {
                string website = text;
                Console.WriteLine($"Browsing: {website}!");
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }

        public void Call()
        {
            if (text.All(x => char.IsDigit(x)))
            {
                string phoneNumber = text;
                Console.WriteLine($"Calling... {phoneNumber}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
