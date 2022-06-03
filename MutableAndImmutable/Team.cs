using System;
using System.Collections.Generic;
using System.Text;

namespace MutableAndImmutable
{
    public class Team
    {
        private List<Person> players;

        public Team(Person person)
        {
            players = new List<Person>() {person};
        }
        public IReadOnlyCollection<Person> Players
        { 
            get
            {
                return this.players.AsReadOnly();
            }
        }

        public void AddPlayer(Person player)
        {
            players.Add(player);
        }
    }
}
