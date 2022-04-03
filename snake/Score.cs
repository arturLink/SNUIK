using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace snake
{
    class Score
    {
        public int score;

        public Score(int score)
        {
            this.score = score;
            Console.SetCursorPosition(90, 2);
            Console.WriteLine("Points: {0}",score);
        }

        public void ScrPlus()
        {
            score = +10;
        }

        public void ScrUpdate()
        {
            Console.SetCursorPosition(90, 2);
            Console.WriteLine("Points: {0}", score);
        }

    }
}
