using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E05FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;

            this.players = new List<Player>();
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
        
        public void AddPlayer(Player player)
                   => players.Add(player);

        public bool RemovePlayer(string name)
        {
            Player player = players.FirstOrDefault(x => x.Name == name);
            return players.Remove(player); // null = false, jhk = false, Todor = true
        }

        public int Stats
            => players.Any()
            ? (int)Math.Round(players.Average(x => x.Stats))
            : 0;
    }
}
