using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JakubKazimierskiGame;
using Xunit;

namespace JakubKazimierskiGame.Tests
{
    public class BulletsShould
    {
        /// <summary>
        /// Check if constructor, and gget method works properly
        /// </summary>
        /// <param name="amountExpected"></param>
        [Theory]
        [InlineData(8)]
        [InlineData(7)]
        [InlineData(6)]
        [InlineData(5)]
        [InlineData(4)]
        public void BulletsShouldGet(int amountExpected)
        {
            BulletsFromDifficultyMode bulletsFromDifficulty = new BulletsFromDifficultyMode(amountExpected);//Arrange values

            int getValues = bulletsFromDifficulty.GetBulletsAmount();//Act get bullets amount

            Assert.Equal(getValues, amountExpected); //Assert if values are equal

        }

        /// <summary>
        /// Check if constructor and get andset method works properly
        /// </summary>
        /// <param name="amountExpected"></param>
        [Theory]
        [InlineData(8)]
        [InlineData(7)]
        [InlineData(6)]
        [InlineData(5)]
        [InlineData(4)]
        public void BulletsShouldSet(int amountExpected)
        {
            BulletsFromDifficultyMode bulletsFromDifficulty = new BulletsFromDifficultyMode(2);//Arrange default value

            bulletsFromDifficulty.SetBulletsAmount(amountExpected);

            int getValues = bulletsFromDifficulty.GetBulletsAmount();//Act get bullets amount

            Assert.Equal(getValues, amountExpected); //Assert if values are equal

        }

    }
}
