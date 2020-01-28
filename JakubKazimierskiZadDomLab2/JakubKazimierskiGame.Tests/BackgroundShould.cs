using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JakubKazimierskiGame;
using Xunit;

namespace JakubKazimierskiGame.Tests
{
   public class BackgroundShould
    {

        /// <summary>
        /// Check if constructor works properly, and method get works properly
        /// </summary>
        /// <param name="expectedColorName"></param>
        /// <param name="expectedAmountObstacles"></param>
        [Theory]
        [InlineData("Black", 8)]
        [InlineData("Blue ", 7)]
        [InlineData("Green ", 6)]
        [InlineData("Red", 5)]
        [InlineData("Gray", 4)]
        public void BackgroundDifficultyModeShould(string expectedColorName, int expectedAmountObstacles)
        {
            DifficultyModeBackground modeBackground = new DifficultyModeBackground(expectedColorName, expectedAmountObstacles); //Arrrange

            string nameColor = modeBackground.GetColorBackground();//Act

            int amountObstacles = modeBackground.GetObstaclesBackground();//Act

            Assert.Equal(nameColor, expectedColorName);//Assert

            Assert.Equal(amountObstacles, expectedAmountObstacles);//Assert

        }


        /// <summary>
        /// Check if set and get method works properly
        /// </summary>
        /// <param name="expectedColorName"></param>
        /// <param name="expectedAmountObstacles"></param>
        [Theory]
        [InlineData("Black", 8)]
        [InlineData("Blue ", 7)]
        [InlineData("Green ", 6)]
        [InlineData("Red", 5)]
        [InlineData("Gray", 4)]
        public void BackgroundDifficultyModeSetShould(string expectedColorName, int expectedAmountObstacles)
        {
            DifficultyModeBackground modeBackground = new DifficultyModeBackground("Black", 3); //Arrrange default data in object

            modeBackground.SetColorBackground(expectedColorName);//Arrange changing default data in object
            modeBackground.SetObstaclesBackground(expectedAmountObstacles);//Arrange

            string nameColor = modeBackground.GetColorBackground();//Act

            int amountObstacles = modeBackground.GetObstaclesBackground();//Act

            Assert.Equal(nameColor, expectedColorName);//Assert

            Assert.Equal(amountObstacles, expectedAmountObstacles);//Assert

        }
    }
}
