using System;
using System.Collections.Generic;
using System.Text;

namespace _2._5_FootballTeamGenerator
{
    public class Player
    {
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            if (endurance < 0 || endurance > 100)
            {
                throw new Exception("Endurance should be between 0 and 100.");
            }

            if (sprint < 0 || sprint > 100)
            {
                throw new Exception("Sprint should be between 0 and 100.");
            }

            if (dribble < 0 || dribble > 100)
            {
                throw new Exception("Dribble should be between 0 and 100.");
            }

            if (passing < 0 || passing > 100)
            {
                throw new Exception("Passing should be between 0 and 100.");
            }

            if (shooting < 0 || shooting > 100)
            {
                throw new Exception("Shooting should be between 0 and 100.");
            }

            this.name = name;
            this.endurance = endurance;
            this.sprint = sprint;
            this.dribble = dribble;
            this.passing = passing;
            this.shooting = shooting;
        }

        private string name;

        private int endurance;

        private int sprint;

        private int dribble;

        private int passing;

        private int shooting;

        public double Stats => (double)(endurance + sprint + dribble + passing + shooting) / 5;

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
    }
}
