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
        
        //functions
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
