using System;

namespace _2._4_PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] input = Console.ReadLine().Split();
                string pizzaName = input[1];

                input = Console.ReadLine().Split();
                string doughType = input[1];
                string doughTechnique = input[2];
                int doughGrams = int.Parse(input[3]);

                var dough = new Dough(doughType, doughTechnique, doughGrams);
                var pizza = new Pizza(pizzaName, dough);

                input = Console.ReadLine().Split();

                while (input[0] != "END")
                {
                    string toppingName = input[1];
                    double toppingWeight = double.Parse(input[2]);

                    var topping = new Topping(toppingName, toppingWeight);

                    pizza.AddTopping(topping);

                    input = Console.ReadLine().Split();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories():F2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
