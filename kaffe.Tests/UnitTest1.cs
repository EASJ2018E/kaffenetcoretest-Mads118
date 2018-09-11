using Microsoft.VisualStudio.TestTools.UnitTesting;
using KaffeNetCore.kaffe;
using System;

namespace kaffe.Tests
{
    [TestClass]
    public class UnitTest1
    {
        //Cortado
        [TestMethod]
        public void TestCortadoMlMælk()
        {
            var cortadoKaffe = new Cortado();

            int mlMælk = cortadoKaffe.MlMælk();

            Assert.AreEqual(25, mlMælk);
        }

        [TestMethod]
        public void TestCortadoPris()
        {
            var cortadoKaffe = new Cortado();

            int pris = cortadoKaffe.Pris();

            Assert.AreEqual(25, pris);
        }

        //FlatWhite

        [TestMethod]
        public void TestFlatWhiteMlMælk()
        {
            var flatWhiteKaffe = new FlatWhite();

            int mlMælk = flatWhiteKaffe.MlMælk();

            Assert.AreEqual(160, mlMælk);
        }

        [TestMethod]
        public void TestFlatWhitePris()
        {
            var flatWhiteKaffe = new FlatWhite();

            int pris = flatWhiteKaffe.Pris();

            Assert.AreEqual(45, pris);
        }

        [TestMethod]
        public void TestFlatWhiteStyrke()
        {
            var flatWhiteKaffe = new FlatWhite();

            string styrke = flatWhiteKaffe.Styrke();

            Assert.AreEqual("Mild", styrke);
        }

        //Sort Kaffe
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSortKaffePris()
        {
            var sortKaffe = new SortKaffe(20);

            int pris = sortKaffe.Pris();

            Assert.Fail();
        }

        //Latte
        [TestMethod]
        public void TestLatteMlMælk()
        {
            var latteKaffe = new Latte();

            int mlMælk = latteKaffe.MlMælk();

            Assert.AreEqual(120, mlMælk);
        }

        [TestMethod]
        public void TestLattePris()
        {
            var latteKaffe = new Latte();

            int pris = latteKaffe.Pris();

            Assert.AreEqual(40, pris);
        }
    }
}
