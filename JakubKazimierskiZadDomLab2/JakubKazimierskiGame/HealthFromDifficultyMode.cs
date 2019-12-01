using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    class HealthFromDifficultyMode : Health
    {
        

        public HealthFromDifficultyMode(int amountLife, int amountShield)
        {
            lifeAmount = amountLife;
            shieldAmount = amountShield;
        }
    
        
    }
}
