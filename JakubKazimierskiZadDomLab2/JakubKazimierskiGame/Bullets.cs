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
    public abstract class Bullets
    {
        protected int amountBullets;

        /// <summary>
        /// Method to get player's bullets amount
        /// </summary>
        /// <returns></returns>
        public virtual int GetBulletsAmount()
        {
            return amountBullets;
        }

        /// <summary>
        /// Method to set player's bullets amount
        /// </summary>
        /// <param name="amount"></param>
        public virtual void SetBulletsAmount(int amount)
        {
            amountBullets = amount;
        }
    }
}
