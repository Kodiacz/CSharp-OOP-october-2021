using System;
using System.Collections.Generic;

namespace _2._5_FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string command = Console.ReadLine();
                Dictionary<string, Team> teams = new Dictionary<string, Team>();

                while (command != "END")
                {
                    string[] information = command.Split(";");
                    command = information[0];

                    if (command == "Team")
                    {
                        string name = information[1];

                        if (!teams.ContainsKey(name))
                        {
                            teams.Add(name, new Team(name));
                        }
                    }
                    else if (command == "Add")
                    {
                        string teamName = information[1];
                        string playerName = information[2];
                        int endurance = int.Parse(information[3]);
                        int sprint = int.Parse(information[4]);
                        int dribble = int.Parse(information[5]);
                        int passing = int.Parse(information[6]);
                        int shooting = int.Parse(information[7]);

                        var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                        if (teams.ContainsKey(teamName))
                        {
                            teams[teamName].Add(player);
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                    }
                    else if (command == "Remove")
                    {
                        string teamName = information[1];
                        string playerName = information[2];

                        if (!teams[teamName].Remove(playerName))
                        {
                            Console.WriteLine($"Player {playerName} is not in {teamName} team.");
                        }
                    }
                    else if (command == "Rating")
                    {
                        string teamName = information[1];

                        if (teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"{teamName} - {teams[teamName].Rating}");
                        }
                        else
                        {
                            Console.WriteLine($"Team {teamName} does exist.");
                        }
                    }

                    command = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
