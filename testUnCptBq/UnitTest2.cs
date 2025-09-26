using System;
using System.Linq;
using System.Security.Cryptography;
using libCptBq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testUnCptBq
{
    [TestClass]
    public class TestBanque
    {
        [TestMethod]
        public void ClasseBanqueExiste()
        {
            //Arranger
            Type banqueType = typeof(Banque);

            //Auditer
            Assert.IsNotNull(banqueType, "La classe Banque n'existe pas.");
        }

        [TestMethod]
        public void AjouterCompteFonctionne()
        {
            //Arranger
            Banque b = new Banque();
            Compte c1 = new Compte(12345, "toto", 1000, -500);

            //Agir
            b.AjouterCompte(c1);
            b.AjouterCompte(4567, "titi", 2000, -1000);

            //Auditer
            Assert.IsNotNull(b.MesComptes.ElementAt(0), "La méthode n'a pas pu ajouter un objet compte existant");
            Assert.IsNotNull(b.MesComptes.ElementAt(1), "La méthode n'a pas pu créer et ajouter un objet compte.");
        }

        [TestMethod]
        public void ToString_ReturnsCorrectFormat()
        {
            //Arranger
            Banque b = new Banque();
            b.AjouterCompte(12345, "toto", 1000, -500);
            b.AjouterCompte(12654, "tintin", 5000, -500);
            string attendu = "Liste des comptes :\n" +
                             "numero: 12345 nom: toto solde: 1000 decouvert autorisé: -500\n" +
                             "numero: 12654 nom: tintin solde: 5000 decouvert autorisé: -500\n";

            //Agir
            string resultat = b.ToString();

            //Auditer
            Assert.AreEqual(attendu, resultat, "La méthode ToString ne retourne pas le format attendu.");
        }

        [TestMethod]
        public void RendCompte_RetourneLeCompte()
        {
            //Arranger
            Banque b = new Banque();
            b.AjouterCompte(12345, "toto", 1000, -500);
            string attendu = "numero: 12345 nom: toto solde: 1000 decouvert autorisé: -500";

            //Agir
            string resultat = b.RendCompte(12345).ToString();
            
            //Auditer
            Assert.AreEqual(attendu, resultat, "La méthode RendCompte ne retourne pas le compte attendu.");
            Assert.IsNull(b.RendCompte(1), "La méthode RendCompte ne retourne pas le format attendu.");
        }
    }
}
