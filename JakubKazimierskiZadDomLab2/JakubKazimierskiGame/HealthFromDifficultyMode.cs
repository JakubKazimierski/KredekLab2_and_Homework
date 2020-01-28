using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
  public  class HealthFromDifficultyMode : Health
    {
        
        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="amountLife"></param>
        /// <param name="amountShield"></param>
        public HealthFromDifficultyMode(int amountLife, int amountShield)
        {
            lifeAmount = amountLife;
            shieldAmount = amountShield;
        }
    
        
    }
}
