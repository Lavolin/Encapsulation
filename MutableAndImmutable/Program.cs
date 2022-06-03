using System;

namespace MutableAndImmutable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person p = null;
            Team team = new Team(p);
           
            Console.WriteLine(team.Players.Count);
        }
    }
}
