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
    abstract class EnemyBullets
    {
        protected int bullets;
        
        /// <summary>
        /// Method to get amount of bullets for enemies
        /// </summary>
        /// <returns></returns>
        public virtual int GetBullets()
        {
            return bullets;
        }

        /// <summary>
        /// Method to set enemies amount of bullets
        /// </summary>
        /// <param name="amount"></param>
        public virtual void SetBullets(int amount)
        {
            bullets = amount;
        }

    }
}
