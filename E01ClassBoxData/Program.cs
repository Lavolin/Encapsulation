﻿using System;

namespace E01ClassBoxData
{
    public class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(lenght, width, height);
                Console.WriteLine(box);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
