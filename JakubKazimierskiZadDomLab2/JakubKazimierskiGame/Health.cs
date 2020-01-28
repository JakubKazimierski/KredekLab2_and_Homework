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
   public abstract class Health
    {
        protected int lifeAmount;
        protected int shieldAmount;
        
        /// <summary>
        /// Method to get life amount
        /// </summary>
        /// <returns></returns>
        public virtual int GetLifeAmount()
        {
            return lifeAmount;
        }

        /// <summary>
        /// Method o set life amount
        /// </summary>
        /// <param name="amount"></param>
        public virtual void SetLifeAmount(int amount)
        {
            lifeAmount = amount;
        }

        /// <summary>
        /// Method to set shield amount
        /// </summary>
        /// <param name="amount"></param>
        public void SetShieldAmount(int amount)
        {
            shieldAmount = amount;
        }

        /// <summary>
        /// Method to get shield amount
        /// </summary>
        /// <returns></returns>
        public int GetShieldAmount()
        {
            return shieldAmount;
        }
    }
}
