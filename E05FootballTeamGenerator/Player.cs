using System;
using System.Collections.Generic;
using System.Text;

namespace E05FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        public Player(string name, int endurance,
            int sprint, int dribble,int passing, int shooting)
        {
            Name = name;

            Validate("Endurance", endurance);
            Validate("Sprint", sprint);
            Validate("Dribble", dribble);
            Validate("Passing", passing);
            Validate("Shooting", shooting);

            this.endurance = endurance;
            this.sprint = sprint;
            this.dribble = dribble;
            this.passing = passing;
            this.shooting = shooting;
        }

        

        public string Name
        {
            get { return name; }

            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value; 
            }
        }

        public double Stats
            => (this.endurance + this.sprint + this.dribble + this.passing + this.shooting) 
            / 5.0;

        private void Validate(string name ,int endurance)
        {
            if (endurance < 0 || endurance > 100)
            {
                throw new ArgumentException($"{name} should be between 0 and 100.");
            }
        }
    }
}
