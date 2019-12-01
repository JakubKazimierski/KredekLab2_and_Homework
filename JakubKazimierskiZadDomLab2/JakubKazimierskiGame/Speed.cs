using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    abstract class Speed
    {
        protected int speedLevel;

        public virtual int GetSpeedLevel()
        {
            return speedLevel;
        }

        public virtual void SetSpeedLevel(int level)
        {
            speedLevel = level;
        }

    }
}
