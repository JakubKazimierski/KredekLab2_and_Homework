using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    class SpeedFromDifficultyMode : Speed
    {
        /// <summary>
        /// constructor of class
        /// </summary>
        /// <param name="level"></param>
        public SpeedFromDifficultyMode(int level)
        {
            speedLevel = level;
        }
    }
}
