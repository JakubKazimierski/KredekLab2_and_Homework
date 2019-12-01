using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame

{   /// <summary>
    ///Abstract class 
    /// </summary>
  abstract class Background
    {
        protected string colorBackground;
        protected int obstaclesBackground;

        /// <summary>
        /// Method to get color name
        /// </summary>
        /// <returns></returns>
        public virtual string GetColorBackground()
        {
            return colorBackground;
        }

        /// <summary>
        /// Method to get amount of obstackles in background
        /// </summary>
        /// <returns></returns>
        public virtual int GetObstaclesBackground()
        {
            return obstaclesBackground;
        }

        /// <summary>
        /// Method to set Color name 
        /// </summary>
        /// <param name="colorName"></param>
        public virtual void SetColorBackground(string colorName)
        {
            colorBackground = colorName;
        }

        /// <summary>
        /// Method to set amount of obstackles at background
        /// </summary>
        /// <param name="amount"></param>
        public virtual void SetObstaclesBackground(int amount)
        {
            obstaclesBackground = amount;
        }
    
    }
}
