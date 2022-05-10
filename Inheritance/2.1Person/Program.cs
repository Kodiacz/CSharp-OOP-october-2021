using System;

namespace Person
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string inputName = Console.ReadLine();
            int inputAge = int.Parse(Console.ReadLine());
            string output = "";

            if (inputAge > 15)
            {
                var person = new Person(inputName, inputAge);
                output = person.ToString();
            }
            else if (inputAge > 0 && inputAge <= 15)
            {
                var child = new Child(inputName, inputAge);
                output = child.ToString();
            }

            Console.WriteLine(output);
        }
    }
}
