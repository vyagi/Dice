using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DieLogic;
namespace DieTests
{
    [TestClass]
    public class DieTests
    {
        [TestMethod]
        public void CanCreateAndRollADie()
        {
            var d = new Die();
            d.Roll();
            var result = d.Show();
            Assert.IsTrue(result > 0);
            Assert.IsTrue(result < 7);
        }

        [TestMethod]
        public void CanCreateAndRollDice()
        {
            var dice = new Dice(4);
            dice.Roll();
            var result = dice.Show();
            Assert.IsInstanceOfType(result, typeof(int[]));
            Assert.AreEqual(4, result.Length);
            //Fluent assertions result.Should().BeTrue();
        }
    }
}
