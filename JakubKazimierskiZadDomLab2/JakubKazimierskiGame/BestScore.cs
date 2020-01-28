using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
   public class BestScore : Scores
    {
        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="number"></param>
        public BestScore(int number)
        {
            score = number;
        }
         
    }
}
