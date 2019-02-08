using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmLibrary;

namespace TestFilm
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Connection_A_La_BDD_Ok()
        {
            bool result = DataAccess.TestConnexionBDD(DataAccess.CHEMINBDD);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Connection_A_La_BDD_NOk()
        {
            bool result = DataAccess.TestConnexionBDD("TATA");
            Assert.AreEqual(false, result);
        }
    }
}
