using System;
using System.Collections.Generic;

namespace _2._3_ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var persons = new Dictionary<string, Person>();
                var products = new Dictionary<string, Product>();

                string[] inputPerson = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                string[] inputProduct = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < inputPerson.Length; i++)
                {
                    string[] personInformation = inputPerson[i].Split("=");
                    string personName = personInformation[0];
                    int personMoney = int.Parse(personInformation[1]);

                    var person = new Person(personName, personMoney);

                    persons.Add(personName, person);
                }

                for (int i = 0; i < inputProduct.Length; i++)
                {
                    string[] productInformation = inputProduct[i].Split("=");
                    string productName = productInformation[0];
                    int productCost = int.Parse(productInformation[1]);

                    var product = new Product(productName, productCost);

                    products.Add(productName, product);
                }

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] info = command.Split();
                    string name = info[0];
                    string product = info[1];

                    persons[name].AddToBag(products[product]);

                    command = Console.ReadLine();
                }

                foreach (var person in persons)
                {
                    if (person.Value.Bag != "")
                    {
                        Console.WriteLine($"{person.Key} - {person.Value.Bag}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Key} - Nothing bought");
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
