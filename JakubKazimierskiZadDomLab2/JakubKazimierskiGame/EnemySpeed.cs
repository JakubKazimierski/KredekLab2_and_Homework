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
   public abstract class EnemySpeed
    {
        protected int speed;

        /// <summary>
        /// Mehod to get speed number 
        /// </summary>
        /// <returns></returns>
        public virtual int GetSpeed()
        {
            return speed;
        }

        /// <summary>
        /// Method to set speed number
        /// </summary>
        /// <param name="number"></param>
        public virtual void SetSpeed(int number)
        {
            speed = number;
        }
    }
}
