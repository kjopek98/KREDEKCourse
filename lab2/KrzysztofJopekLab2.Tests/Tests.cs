using KrzysztofJopekLab2ZadanieDomowe;
using System;
using Xunit;

namespace KrzysztofJopekLab2.Tests
{
    public class Tests
    {
        [Fact]
        public void CalculateHp()
        {
            Dealer dealer = new Dealer(100, "Janusz");

            Assert.Equal(100, dealer.healthPoints);
        }

        [Fact]
        public void CalculateHpAfterFire()
        {

            Worker dealer = new Dealer(100, "Janusz");
            Fire fire = new Fire(50);

            fire.Damage(dealer);

            Assert.InRange(dealer.healthPoints, 49, 100);
        }

        [Fact] 
        public void CheckInvasionMessage()
        {
            Disaster invasion = new Invasion(100);

            var message = invasion.StartDisaster();

            Assert.StartsWith("Najazd barbarzyńców!", message);
        }

        [Fact]
        public void CheckSoldierName()
        {
            Worker soldier = new Soldier(100, "Michał");

            var message = soldier.StartWork();

            Assert.Contains("Żołnierz Michał ", message);
        }

    }
}
