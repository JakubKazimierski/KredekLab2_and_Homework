using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    abstract class Health
    {
        protected int lifeAmount;
        protected int shieldAmount;
        public virtual int GetLifeAmount()
        {
            return lifeAmount;
        }

        public virtual void SetLifeAmount(int amount)
        {
            lifeAmount = amount;
        }
        public void SetShieldAmount(int amount)
        {
            shieldAmount = amount;
        }

        public int GetShieldAmount()
        {
            return shieldAmount;
        }
    }
}
