using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

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
            
            //Отрисовка змейки и ее направление
            Point p = new Point(1,3,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            
            //Создание еды для змейки и ее отрисовка
            FoodCreator foodCreator = new FoodCreator(80, 25, '¤');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                //Создание новой еды если съели старую
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                
                Thread.Sleep(100);
                //Управление
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}
