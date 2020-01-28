using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
  public  class EnemySpeedFromDifficultyMode : EnemySpeed
    {
        /// <summary>
        /// Connstructor of class
        /// </summary>
        /// <param name="number"></param>
        public EnemySpeedFromDifficultyMode(int number)
        {
            speed = number;
        }
    }
}
