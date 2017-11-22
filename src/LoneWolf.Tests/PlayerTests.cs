using System;
using Xunit;

namespace LoneWolf.Tests
{
    public class PlayerTests
    {
        [Fact]
        public void WhenNewPlayerNameDoesNotContainLetters_TheThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Player(""));
        }

        [Fact]
        public void WhenNewPlayer_ThenHealthShouldBe100()
        {
            var sut = new Player("Player");
            Assert.Equal(100, sut.HealthPoints);
        }

        [Fact]
        public void WhenPlayerReceivesDamage_TheReduceTheHealth()
        {
            var sut = new Player("Player");
            sut.ReceiveDamagePoints(50);

            Assert.Equal(50, sut.HealthPoints);
        }
    }
}
