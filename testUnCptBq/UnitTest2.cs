using System;
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
            b.AjouterCompte(12654, "tintin", 5000, -500);

            //Auditer

        }
    }
}
