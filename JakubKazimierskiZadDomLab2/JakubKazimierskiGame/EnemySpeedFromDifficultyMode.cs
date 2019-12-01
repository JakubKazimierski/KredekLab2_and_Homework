using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    class EnemySpeedFromDifficultyMode : EnemySpeed
    {
        public EnemySpeedFromDifficultyMode(int number)
        {
            speed = number;
        }
    }
}
