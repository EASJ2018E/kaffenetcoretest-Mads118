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
        public void TestCortadoMlM�lk()
        {
            var cortadoKaffe = new Cortado();

            int mlM�lk = cortadoKaffe.MlM�lk();

            Assert.AreEqual(25, mlM�lk);
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
        public void TestFlatWhiteMlM�lk()
        {
            var flatWhiteKaffe = new FlatWhite();

            int mlM�lk = flatWhiteKaffe.MlM�lk();

            Assert.AreEqual(160, mlM�lk);
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
        public void TestLatteMlM�lk()
        {
            var latteKaffe = new Latte();

            int mlM�lk = latteKaffe.MlM�lk();

            Assert.AreEqual(120, mlM�lk);
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
