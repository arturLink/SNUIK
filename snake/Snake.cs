using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace snake
{
    //Класс наследник использующий параметры из класса фигура
    class Snake : Figure
    {
        //Конструктор для создания змейки
        public Snake(Point tail, int length, Direction direction)
        {
            //Список точек
            pList = new List<Point>();
            //Добавление точек в список
            for (int i = 0; i < length; i++)
            {
                //Создание точек
                Point p = new Point(tail);
                //Направление точек
                p.Move(i, direction);
                //Добавление этих точек
                pList.Add(p);
            }
        }
    }
}
