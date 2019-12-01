using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    abstract class EnemyBullets
    {
        protected int bullets;
        

        public virtual int GetBullets()
        {
            return bullets;
        }

        public virtual void SetBullets(int amount)
        {
            bullets = amount;
        }

    }
}
