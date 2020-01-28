using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JakubKazimierskiGame;
using Xunit;

namespace JakubKazimierskiGame.Tests
{
   public class PlayerHealtShould
    {
        /// <summary>
        /// check if constructor, and get  method works properly
        /// </summary>
        /// <param name="expectedLife"></param>
        /// <param name="expectedShield"></param>
        [Theory]
        [InlineData(11, 8)]
        [InlineData(3, 7)]
        [InlineData(5, 6)]
        [InlineData(33, 5)]
        [InlineData(12, 4)]
        public void PlayerHelathShouldGet(int expectedLife, int expectedShield)
        {
            HealthFromDifficultyMode healthFromDifficultyMode = new HealthFromDifficultyMode(expectedLife, expectedShield);//Arrange expected values in construcotr

            int getLife = healthFromDifficultyMode.GetLifeAmount();//Act save life amount
            int getShield = healthFromDifficultyMode.GetShieldAmount();//Act get actual shield amount

            Assert.Equal(getLife, expectedLife);//Assert check if values are equal
            Assert.Equal(getShield, expectedShield);//Assert check if values are equal

        }
        /// <summary>
        /// Check if constructor and get and set method wors properly
        /// </summary>
        /// <param name="expectedLife"></param>
        /// <param name="expectedShield"></param>
        [Theory]
        [InlineData(11, 8)]
        [InlineData(3, 7)]
        [InlineData(5, 6)]
        [InlineData(33, 5)]
        [InlineData(12, 4)]
        public void PlayerHelathShouldSet(int expectedLife, int expectedShield)
        {
            HealthFromDifficultyMode healthFromDifficultyMode = new HealthFromDifficultyMode(1, 1);//Arrange default values in construcotr

            healthFromDifficultyMode.SetLifeAmount(expectedLife);
            healthFromDifficultyMode.SetShieldAmount(expectedShield);

            int getLife = healthFromDifficultyMode.GetLifeAmount();//Act save life amount
            int getShield = healthFromDifficultyMode.GetShieldAmount();//Act get actual shield amount

            Assert.Equal(getLife, expectedLife);//Assert check if values are equal
            Assert.Equal(getShield, expectedShield);//Assert check if values are equal

        }
    }
}
