using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JakubKazimierskiGame;
using Xunit;

namespace JakubKazimierskiGame.Tests
{
   public class EnemySpeedShould
    {
        /// <summary>
        /// Check if constructor, and method get wors properly
        /// </summary>
        /// <param name="expectedValue"></param>
        [Theory]
        [InlineData(8)]
        [InlineData(7)]
        [InlineData(6)]
        [InlineData(5)]
        [InlineData(4)]
        public void EnemySpeedShouldGet(int expectedValue)
        {
            EnemySpeedFromDifficultyMode enemySpeedFromDifficultyMode = new EnemySpeedFromDifficultyMode(expectedValue);//Arrange expected values in costructor

            int getValue = enemySpeedFromDifficultyMode.GetSpeed();//Act save actual value

            Assert.Equal(getValue, expectedValue);//Assert check if values are equal
        }

        /// <summary>
        /// Check if constructor anp get and set method worls properly
        /// </summary>
        /// <param name="expectedValue"></param>
        [Theory]
        [InlineData(8)]
        [InlineData(7)]
        [InlineData(6)]
        [InlineData(5)]
        [InlineData(4)]
        public void EnemySpeedShouldSet(int expectedValue)
        {
            EnemySpeedFromDifficultyMode enemySpeedFromDifficultyMode = new EnemySpeedFromDifficultyMode(1);//Arrange default value in costructor

            enemySpeedFromDifficultyMode.SetSpeed(expectedValue);//Act set expected value

            int getValue = enemySpeedFromDifficultyMode.GetSpeed();//Act save actual value

            Assert.Equal(getValue, expectedValue);//Assert check if values are equal
        }
    }
}
