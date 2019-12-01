using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    class EnemyBulletsFromDifficultyMode : EnemyBullets
    {
        
        public EnemyBulletsFromDifficultyMode(int amount)
        {
            bullets = amount;
        }
    }
}
