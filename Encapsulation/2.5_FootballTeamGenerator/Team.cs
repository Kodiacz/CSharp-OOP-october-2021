using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._5_FootballTeamGenerator
{
    public class Team
    {
        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        private string name;
        private List<Player> players;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("A name should not be empty.");
                }

                name = value;
            }
        }

        public IReadOnlyCollection<Player> Players => players;

        public double Rating => Math.Round(players.Sum(player => player.Stats));

        public void Add(Player player)
        {
            players.Add(player);
        }

        public bool Remove(string name)
        {
            var player = players.FirstOrDefault(x => x.Name == name);
            return players.Remove(player);
        }
    }
}
