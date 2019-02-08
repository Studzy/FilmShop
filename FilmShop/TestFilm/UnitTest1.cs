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

        [TestMethod]
        public void NomPersonne_est_Ok()
        {
            var personne = new Personnes();
            personne.NomPersonne = "Dupond";
            Assert.AreEqual("Dupond", personne.NomPersonne);
        }
        [TestMethod]
        public void NomPersonne_est_NOk()
        {
            var personne = new Personnes();
            var exception = Assert.ThrowsException<ArgumentException>(
                () => personne.NomPersonne = "");
        }
        [TestMethod]
        public void PrenomPersonne_est_Ok()
        {
            var personne = new Personnes();
            personne.PrenomPersonne = "Jean";
            Assert.AreEqual("Jean", personne.PrenomPersonne);
        }
        [TestMethod]
        public void PrenomPersonne_est_NOk()
        {
            var personne = new Personnes();
            var exception = Assert.ThrowsException<ArgumentException>(
                () => personne.PrenomPersonne = "");
        }
        [TestMethod]
        public void Ville_est_Ok()
        {
            var personne = new Personnes();
            personne.VillePersonne = "Colmar";
            Assert.AreEqual("Colmar", personne.VillePersonne);
        }
        [TestMethod]

        public void Ville_est_NOk()
        {
            var personne = new Personnes();
            var exception = Assert.ThrowsException<ArgumentException>(
                () => personne.VillePersonne = "");
        }

        [TestMethod]
        public void CP_est_Ok()
        {
            var personne = new Personnes();
            personne.CodePostal = "68000";
            Assert.AreEqual("68000", personne.CodePostal);
        }
        [TestMethod]
        public void CP_est_NOk()
        {
            var personne = new Personnes();
            var exception = Assert.ThrowsException<ArgumentException>(
                () => personne.CodePostal = "814256");
        }

    }
}
