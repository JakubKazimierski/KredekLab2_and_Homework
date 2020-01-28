using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
  public  class EnemyAmountFromDifficultyMode : EnemyAmount
    {
        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="number"></param>
        public EnemyAmountFromDifficultyMode(int number)
        {
            amount = number;
        }
    }
}
