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
        //Направление змейки
        Direction direction;
        //Конструктор для создания змейки
        public Snake(Point tail, int length, Direction direction1)
        {
            direction = direction1;
            //Список точек
            pList = new List<Point>();
            //Добавление точек в список
            for (int i = 0; i < length; i++)
            {
                //Создание точек
                Point p = new Point(tail);
                //Направление точек
                p.Move(i, direction1);
                //Добавление этих точек
                pList.Add(p);
            }
        }

        //Функция для движения змейки
        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        //Функция которая двигает змейку на следующий координат по направлению
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        //Функция отвечающая за управление
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        //Функция отвечающая за пищеварительный тракт змейки
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            //Если голова змейки касается food возвращает true и рисует новую еду на новых координатах 
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                //Увелечение змейки
                pList.Add(food);
                return true;
            }
            //В других случаях если не касается false
            else
                return false;
        }
    }
}
