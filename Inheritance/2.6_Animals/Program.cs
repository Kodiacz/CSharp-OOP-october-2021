using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Animal> animals = new List<Animal>();

            while (input != "Beast!")
            {
                string[] parts = Console.ReadLine().Split();
                string name = parts[0];
                int age = int.Parse(parts[1]);
                string gender = parts[2];

                if (age <= 0)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                switch (input)
                {
                    case "Dog":
                        var dog = new Dog(name, age, gender);
                        animals.Add(dog);
                        break;
                    case "Frog":
                        var frog = new Frog(name, age, gender);
                        animals.Add(frog);
                        break;
                    case "Cat":
                        var cat = new Cat(name, age, gender);
                        animals.Add(cat);
                        break;
                    case "Tomcat":
                        var tomcat = new Tomcat(name, age);
                        animals.Add(tomcat);
                        break;
                    case "Kitten":
                        var kitten = new Kitten(name, age);
                        animals.Add(kitten);
                        break;
                }

                input = Console.ReadLine();
            }

            foreach(var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}
