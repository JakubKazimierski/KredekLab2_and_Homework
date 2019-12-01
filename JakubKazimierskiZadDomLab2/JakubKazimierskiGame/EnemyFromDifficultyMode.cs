using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    class EnemyFromDifficultyMode : Enemy
    {
        
        public EnemyFromDifficultyMode(int amount)
        {
            bullets = amount;
        }
    }
}
