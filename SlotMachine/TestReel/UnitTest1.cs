using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlotMachineModel;

namespace TestReel
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SpinCheckSymbolsAreInRange()
        {
            Reel testReel = new Reel();

            testReel.spin();
            int symbol = testReel.getCurrentSymbol();
            Assert.IsTrue(1 <= symbol && symbol <= 10);
        }

        [TestMethod]
        public void ConstructorCheckStartingSymbol()
        {
            Reel testReel = new Reel();

            int symbol = testReel.getCurrentSymbol();
            Assert.AreEqual(symbol, 1);
        }

        [TestMethod]
        public void ConstructorCheckAbove()
        {
            Reel testReel = new Reel();

            int symbol = testReel.getAboveSymbol();
            Assert.AreEqual(symbol, 2);
        }

        [TestMethod]
        public void ConstructorCheckBelow()
        {
            Reel testReel = new Reel();

            int symbol = testReel.getBelowSymbol();
            Assert.AreEqual(symbol, 10);
        }
    }
}
