using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libCptBq;

namespace consCptBq
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte compte = new Compte
            {
                Numero = 123456,
                Nom = "toto",
                Solde = 1000.50m,
                DecouvertAutorise = -500.00m
            };
            Console.WriteLine(compte.ToString());
        }
    }
}
