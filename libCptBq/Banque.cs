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
            string str = "Liste des comptes :\n";
            foreach (Compte compte in mesComptes)
            {
                str += compte.ToString() + "\n";
            }
            return str;
        }
        
        public Compte RendCompte(int numero)
        {
            //Boucle parcourant la liste des comptes et comparant le numéro de chaque compte avec le numéro fourni en paramètre.
            foreach (Compte compte in mesComptes)
            {
                if (compte.Numero == numero)
                {
                    return compte;
                }
            }
            return null;
        }
    }
}
