using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
   abstract class Scores
    {
        protected int score;

        public virtual int GetScore()
        {
            return score;
        }

        public virtual void SetScore(int number)
        {
            score = number;
        }

    }
}
