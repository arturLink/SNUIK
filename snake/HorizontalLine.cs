using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    //Класс наследник использующий параметры из класса фигура
    class HorizontalLine : Figure
    {
        //Конструктор для создания горизонтальной линии
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
