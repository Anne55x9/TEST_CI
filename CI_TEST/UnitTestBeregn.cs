using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TEST_CI;

namespace CI_TEST
{
    [TestClass]
    public class UnitTestBeregn
    {
        [TestMethod]
        public void TestBeregn0()
        {

            bool resultat = Beregn.ErNulOgMindre(0);

            Assert.IsTrue(resultat);
        }

        [TestMethod]
        public void TestBeregnless0()
        {

            bool resultat = Beregn.ErNulOgMindre(-1);

            Assert.IsTrue(resultat);
        }

        [TestMethod]
        public void TestBeregngtr0()
        {

            bool resultat = Beregn.ErNulOgMindre(1);

            Assert.IsFalse(resultat);
        }


    }
}
