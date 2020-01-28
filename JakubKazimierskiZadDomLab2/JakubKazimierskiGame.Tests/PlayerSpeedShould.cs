using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JakubKazimierskiGame;
using Xunit;

namespace JakubKazimierskiGame.Tests
{
    public class PlayerSpeedShould
    {
        /// <summary>
        /// check if construcotr, and get method works properly
        /// </summary>
        /// <param name="expectedValue"></param>
        [Theory]
        [InlineData(8)]
        [InlineData(7)]
        [InlineData(6)]
        [InlineData(5)]
        [InlineData(4)]
        public void PlayerSpeedShouldGet(int expectedValue)
        {
            SpeedFromDifficultyMode speedFromDifficultyMode = new SpeedFromDifficultyMode(expectedValue);//Arrange expected value in constructor

            int getSpeed = speedFromDifficultyMode.GetSpeedLevel();//Act get actual speed lvl

            Assert.Equal(getSpeed, expectedValue);//Assert check if values are equal
        }


        /// <summary>
        /// check if constructor and get and set method works properly
        /// </summary>
        /// <param name="expectedValue"></param>
        [Theory]
        [InlineData(8)]
        [InlineData(7)]
        [InlineData(6)]
        [InlineData(5)]
        [InlineData(4)]
        public void PlayerSpeedShouldSet(int expectedValue)
        {
            SpeedFromDifficultyMode speedFromDifficultyMode = new SpeedFromDifficultyMode(1);//Arrange default value in constructor

            speedFromDifficultyMode.SetSpeedLevel(expectedValue);//Act set expected value

            int getSpeed = speedFromDifficultyMode.GetSpeedLevel();//Act get actual speed lvl

            Assert.Equal(getSpeed, expectedValue);//Assert check if values are equal
        }
    }
}
