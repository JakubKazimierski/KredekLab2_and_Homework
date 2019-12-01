using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    abstract class EnemySpeed
    {
        protected int speed;

        public virtual int GetSpeed()
        {
            return speed;
        }

        public virtual void SetSpeed(int number)
        {
            speed = number;
        }
    }
}
