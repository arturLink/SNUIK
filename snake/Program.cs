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
            int Bunda = 0;
            //Создание рамки
            Console.SetWindowSize(110, 25);//uuuu

            Walls walls = new Walls(80, 25);
            walls.Draw();
            
            //Отрисовка змейки и ее направление
            Point p = new Point(1,3,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            
            //Создание еды для змейки и ее отрисовка
            FoodCreator foodCreator = new FoodCreator(80, 25, '¤');
            Point food = foodCreator.CreateFood();
            food.Draw();

            Score score = new Score(0);
            while (true)
            {


                //Условие проигрыша, либо змейка убивается об себя, либо об стенку
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                //Создание новой еды если съели старую
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    score.ScrPlus();
                    score.ScrUpdate();
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
            GameOver over = new GameOver(Bunda);
            over.Ending();
            Console.ReadLine();
        }
    }
}
