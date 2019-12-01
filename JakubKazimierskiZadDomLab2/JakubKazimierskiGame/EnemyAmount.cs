using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
    /// <summary>
    /// Abstract Class
    /// </summary>
  abstract class EnemyAmount
    {
        protected int amount;

        /// <summary>
        /// Method to get amount of enemies
        /// </summary>
        /// <returns></returns>
        public virtual int GetAmount()
        {
            return amount;
        }

        /// <summary>
        /// Method to set amount of enemies
        /// </summary>
        /// <param name="number"></param>
        public virtual void SetAmount(int number)
        {
           amount = number;
        }
    }
}
