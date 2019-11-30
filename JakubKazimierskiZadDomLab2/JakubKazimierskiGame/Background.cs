using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubKazimierskiGame
{
  abstract class Background
    {
        protected string colorBackground;
        protected int obstaclesBackground;

        public virtual string GetColorBackground()
        {
            return colorBackground;
        }

        public virtual int GetObstaclesBackground()
        {
            return obstaclesBackground;
        }

        public virtual void SetColorBackground(string colorName)
        {
            colorBackground = colorName;
        }

        public virtual void SetObstaclesBackground(int amount)
        {
            obstaclesBackground = amount;
        }
    
    }
}
