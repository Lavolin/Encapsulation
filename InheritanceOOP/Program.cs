using System;
using System.Reflection;
using System.Threading;

namespace InheritanceOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            var fields = shape.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var field in fields)
            {
                Console.WriteLine($"key: {field.Name}, value: {field.GetValue(shape)}");
            }

            return;

            for (int i = 0; i < 105; i++)
            {
                Thread.Sleep(10);

                Console.Clear();

                shape.Draw();

            }
        }
    }
}
