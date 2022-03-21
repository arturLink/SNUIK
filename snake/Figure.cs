using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    //Класс родитель для других классов связаных с созданием фигур
    class Figure
    {
        //Лист для функции
        protected List<Point> pList;
        //Функция отрисовывающия каждую точку в списке
        public void Drow()
        {
            //Для каждой точки в списке
            foreach (Point p in pList)
            {
                //Использование функции отрисовки
                p.Draw();
            }
        }
    }
}
