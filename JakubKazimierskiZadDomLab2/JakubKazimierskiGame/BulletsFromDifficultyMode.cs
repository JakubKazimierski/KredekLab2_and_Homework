using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    class BulletsFromDifficultyMode : Bullets
    {
        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="amount"></param>
        public BulletsFromDifficultyMode(int amount)
        {
            amountBullets = amount; 
        }

    }
}
