using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    //Класс наследник использующий параметры из класса фигура
    class VerticalLine : Figure
    {
        //Конструктор для создания вертикальной линии
        public VerticalLine(int yLeft, int yRight, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yLeft; y <= yRight; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
