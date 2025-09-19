using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCptBq
{
    public class Banque
    {
        private List<Compte> mesComptes;

        public List<Compte> MesComptes
        {
            get { return mesComptes; }
            set { mesComptes = value; }
        }

        public Banque()
        {
            mesComptes = new List<Compte>();
        }

        public void AjouterCompte(int numero, string nom, decimal solde, decimal decouvertAutorise)
        {
            Compte c = new Compte(numero, nom, solde, decouvertAutorise);
            mesComptes.Add(c);
        }

        public void AjouterCompte(Compte c)
        {
            mesComptes.Add(c);
        }

        public override string ToString()
        {   
            return "Liste des comptes: WOW!";
        }
    }
}
