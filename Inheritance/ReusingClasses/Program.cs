using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new RandomList();
            list.Add("Toshko");
            list.Add("Dekster");
            list.Add("Maimuncho");
            list.Add("Pedro");
            Console.WriteLine(list.Count);
            string element = list.RandomString();
            Console.WriteLine(element);
            Console.WriteLine(list.Count);
        }
    }
}
