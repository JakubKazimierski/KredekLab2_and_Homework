using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    abstract class Bullets
    {
        protected int amountBullets;

        public virtual int GetBulletsAmount()
        {
            return amountBullets;
        }

        public virtual void SetBulletsAmount(int amount)
        {
            amountBullets = amount;
        }
    }
}
