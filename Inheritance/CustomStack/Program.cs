using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<string> items = new List<string>();
            items.Add("Dekster");
            items.Add("Mekster");
            items.Add("Pedro");
            items.Add("Medro");

            var stakche = new StackOfStrings();
            Console.WriteLine(stakche.IsEmpty());
            stakche.AddRange(items);
            Console.WriteLine(stakche.Count);
            Console.WriteLine(stakche.IsEmpty());
        }
    }
}
