using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    class DifficultyModeBackground : Background
    {
        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="colorName"></param>
        /// <param name="amount"></param>
        public DifficultyModeBackground(string colorName, int amount)
        {
            colorBackground = colorName;
            obstaclesBackground = amount;
        }

    }
}
