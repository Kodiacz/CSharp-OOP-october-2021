using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._3_Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] webSites = Console.ReadLine().Split();

            foreach (var number in numbers)
            {
                if (number.Length == 10)
                {
                    var smarthphone = new Smartphone(number);
                    smarthphone.Call();
                }
                else if (number.Length == 7)
                {
                    var stationaryPhone = new StationaryPhone(number);
                    stationaryPhone.Call();
                }
            }

            foreach (var website in webSites)
            {
                var smartphone = new Smartphone(website);
                smartphone.Browse();
            }
        }
    }
}
