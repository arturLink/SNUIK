using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace snake
{
    class Score
    {
        int score;

        public Score(int Scr)
        {
            score = Scr;
            Console.SetCursorPosition(90, 2);
            Console.WriteLine("Points: {0}",Scr);
        }

        public int Scr
        {
            set { score = value; }
            get { return score; }
        }

        public void AddUp()
        {
            Scr +=10;
        }

        public void ScoreReader()
        {
            Console.SetCursorPosition(90, 2);
            Console.WriteLine("Points: {0}", Scr);
        }
    }
}
