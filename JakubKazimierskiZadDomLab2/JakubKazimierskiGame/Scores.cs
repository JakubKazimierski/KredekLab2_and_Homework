using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    /// <summary>
    /// Abstract class scores
    /// </summary>
  public abstract class Scores
    {
        
        protected int score;

        /// <summary>
        /// Method to get amount of score
        /// </summary>
        /// <returns></returns>
        public virtual int GetScore()
        {
            return score;
        }

        /// <summary>
        /// Method to set amount of score
        /// </summary>
        /// <param name="number"></param>
        public virtual void SetScore(int number)
        {
            score = number;
        }

    }
}
