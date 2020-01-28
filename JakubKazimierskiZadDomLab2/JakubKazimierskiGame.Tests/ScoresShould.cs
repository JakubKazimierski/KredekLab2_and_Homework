using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JakubKazimierskiGame;
using Xunit;

namespace JakubKazimierskiGame.Tests
{
    public class ScoresShould
    {

        /// <summary>
        /// Check if constructor works properly and method getSore works properly also
        /// </summary>
        /// <param name="expectedScore"></param>
        [Theory]
        [InlineData(8)]
        [InlineData(7)]
        [InlineData(6)]
        [InlineData(5)]
        [InlineData(4)]
        public void BestScoreShould(int expectedScore)
        {
            BestScore scoreBest = new BestScore(expectedScore); //Arrange

            int valueOfSore = scoreBest.GetScore();

            Assert.Equal(valueOfSore, expectedScore);

        }

        /// <summary>
        /// Check if constructor works properly, and method set and get
        /// </summary>
        /// <param name="expectedScore"></param>
        [Theory]
        [InlineData(8)]
        [InlineData(7)]
        [InlineData(6)]
        [InlineData(5)]
        [InlineData(4)]
        public void BestScoreShouldSet(int expectedScore)
        {
            BestScore scoreBest = new BestScore(2); //Arrange default value of score

            scoreBest.SetScore(expectedScore);//Act, change deafult value

            int valueOfSore = scoreBest.GetScore();//Act save changed value

            Assert.Equal(valueOfSore, expectedScore);//Assert Compare values

        }
    }
}
