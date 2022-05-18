using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> players = new List<Person>();
            var team = new Team("Lokomitiv");

            for (int i = 0; i < n; i++)
            {
                string[] playersInformation = Console.ReadLine().Split();
                string firstName = playersInformation[0];
                string lastName = playersInformation[1];
                int age = int.Parse(playersInformation[2]);
                decimal salary = decimal.Parse(playersInformation[3]);

                var player = new Person(firstName, lastName, age, salary);
                team.AddPlayer(player);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"First team has {team.ReserveTeam.Count} players.");
        }
    }
}
