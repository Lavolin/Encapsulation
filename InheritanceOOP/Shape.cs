using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOOP
{
    public class Shape
    {
        private int drawCount = 0;
        private int maxDrawCount = 100;
        private int x = 25;
        private int y = 10;

        
        public void Draw()
        {
            if (CanDrawShapes())
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine($"Drawing shape! With size {6}");
            }
        }

        private bool CanDrawShapes()
        {
            drawCount++;
            if (drawCount > maxDrawCount)
            {
                Console.WriteLine("Too many shapes!");
                return false;
            }

            return true;
        }
    }
}
