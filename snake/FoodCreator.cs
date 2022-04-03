using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class FoodCreator
    {
        //Размеры карты и используемый символ для обозначения еды
        private int mapWidth;
        private int mapHeight;
        private char sym;

        Random rnd = new Random();

        //Конструктор для еды
        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            //Приравнивание свойств к переменным коструктора
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        //Функция для создания еды на заданых координатах и с заданым символом
        public Point CreateFood()
        {
            int x = rnd.Next(2, mapWidth - 2);
            int y = rnd.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
