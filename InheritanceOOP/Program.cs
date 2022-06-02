using System;
using System.Threading;

namespace InheritanceOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();

            for (int i = 0; i < 105; i++)
            {
                Thread.Sleep(10);
                
                Console.Clear();

                shape.Draw();

            }
        }
    }
}
