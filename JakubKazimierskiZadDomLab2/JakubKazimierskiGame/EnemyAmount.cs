using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
  abstract class EnemyAmount
    {
        protected int amount;

        public virtual int GetAmount()
        {
            return amount;
        }

        public virtual void SetAmount(int number)
        {
           amount = number;
        }
    }
}
