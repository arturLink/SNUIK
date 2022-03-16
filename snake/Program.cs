﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание рамки
            Console.SetWindowSize(80, 25);//uuuu
            //Создание линий для рамки
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            //Отрисовка этих линий
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(3,2,'*');
            p2.Draw();

            
            Console.ReadLine();
        }
    }
}
