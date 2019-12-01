using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    /// <summary>
    /// Abstract class
    /// </summary>
    abstract class Speed
    {
        protected int speedLevel;

        /// <summary>
        /// Method o get speed level
        /// </summary>
        /// <returns></returns>
        public virtual int GetSpeedLevel()
        {
            return speedLevel;
        }

        /// <summary>
        /// Method to set speed level
        /// </summary>
        /// <param name="level"></param>
        public virtual void SetSpeedLevel(int level)
        {
            speedLevel = level;
        }

    }
}
