using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JakubKazimierskiGame;
using Xunit;

namespace JakubKazimierskiGame.Tests
{
   public class EnemyAmountShould
    {

        /// <summary>
        /// Check if constructor and get method works properly
        /// </summary>
        /// <param name="expectedAmount"></param>
        [Theory]
        [InlineData(8)]
        [InlineData(7)]
        [InlineData(6)]
        [InlineData(5)]
        [InlineData(4)]
        public void EnemyAmountShouldGet(int expectedAmount)
        {
            EnemyAmountFromDifficultyMode enemyAmountFromDifficulty = new EnemyAmountFromDifficultyMode(expectedAmount);//Arrange values

            int getValue = enemyAmountFromDifficulty.GetAmount();//Act get actual value

            Assert.Equal(getValue, expectedAmount);//Assert if return value is expected value

        }

        [Theory]
        [InlineData(8)]
        [InlineData(7)]
        [InlineData(6)]
        [InlineData(5)]
        [InlineData(4)]
        public void EnemyAmountShouldSet(int expectedAmount)
        {
            EnemyAmountFromDifficultyMode enemyAmountFromDifficulty = new EnemyAmountFromDifficultyMode(1);//Arrange default value

            enemyAmountFromDifficulty.SetAmount(expectedAmount);//Act set expected amount

            int getValue = enemyAmountFromDifficulty.GetAmount();//Act get actual value

            Assert.Equal(getValue, expectedAmount);//Assert if return value is expected value

        }
    }
}
