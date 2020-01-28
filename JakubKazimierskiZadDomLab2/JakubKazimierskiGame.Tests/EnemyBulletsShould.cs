using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JakubKazimierskiGame;
using Xunit;

namespace JakubKazimierskiGame.Tests
{
  public  class EnemyBulletsShould
    {

        /// <summary>
        /// Check if constructor and get moethod wors properly
        /// </summary>
        /// <param name="expectedAmount"></param>
        [Theory]
        [InlineData(8)]
        [InlineData(7)]
        [InlineData(6)]
        [InlineData(5)]
        [InlineData(4)]
        public void EnemyBulletsShouldGet(int expectedAmount)
        {
            EnemyBulletsFromDifficultyMode enemyBulletsFromDifficultyMode = new EnemyBulletsFromDifficultyMode(expectedAmount);//Arrange expected values in constructor

            int getAmount = enemyBulletsFromDifficultyMode.GetBullets();//Act save actual values of bullets

            Assert.Equal(getAmount, expectedAmount);//Assert if values are equal
        
        }

        /// <summary>
        /// Check if constructor get, and set method works propery
        /// </summary>
        /// <param name="expectedAmount"></param>
        [Theory]
        [InlineData(8)]
        [InlineData(7)]
        [InlineData(6)]
        [InlineData(5)]
        [InlineData(4)]
        public void EnemyBulletsShouldSet(int expectedAmount)
        {
            EnemyBulletsFromDifficultyMode enemyBulletsFromDifficultyMode = new EnemyBulletsFromDifficultyMode(1);//Arrange default value in constructor

            enemyBulletsFromDifficultyMode.SetBullets(expectedAmount);

            int getAmount = enemyBulletsFromDifficultyMode.GetBullets();//Act save actual values of bullets

            Assert.Equal(getAmount, expectedAmount);//Assert if values are equal

        }
    }
}
