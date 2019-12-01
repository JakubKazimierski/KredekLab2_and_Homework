using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    class SpeedFromDifficultyMode : Speed
    {
        public SpeedFromDifficultyMode(int level)
        {
            speedLevel = level;
        }
    }
}
