﻿using System;
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
        //Конструктор создающий точки x,y и символ
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
        //Функция которая направляет змейку в заданое направление
        public void Move(int offset, Direction direction)
        {
            //Направление в право
            if (direction==Direction.RIGHT)
            {
                x = x + offset;
            }
            //Направление в лево
            else if (direction==Direction.LEFT)
            {
                x = x - offset;
            }
            //Направление в верх
            else if (direction == Direction.UP)
            {
                y = y + offset;
            }
            //Направление в вниз
            else if (direction == Direction.DOWN)
            {
                y = y - offset;
            }
        }
        //Функция рисующая символ на координатах
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
