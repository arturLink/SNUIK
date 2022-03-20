using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        //parametri
        public int x;
        public int y;
        public char sym;

        //constructori
        public Point() { }
        public Point(int X, int Y, char SYM)
        {
            x = X;
            y = Y;
            sym = SYM;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        
        //functions
        public void Move(int offset, Direction direction)
        {
            if (direction==Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction==Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y + offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y - offset;
            }
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}
