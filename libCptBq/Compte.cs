﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libCptBq
{
    /// <summary>
    /// Classe Compte
    /// </summary>
    public class Compte
    {
        private int numero;
        private string nom;
        private decimal solde;
        private decimal decouvertAutorise; // valeur négative

        /// <summary>
        /// Propriétés implémentées automatiquement
        /// </summary>
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        } 
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public decimal Solde
        {
            get { return solde; }
            set { solde = value; }
        }
        public decimal DecouvertAutorise
        {
            get { return decouvertAutorise; }
            set { decouvertAutorise = value; }
        }

        /// <summary>
        /// Constructeur à 4 arguments
        /// </summary>
        /// <param name="numero">le numéro</param>
        /// <param name="nom">le nom</param>
        /// <param name="solde">le solde</param>
        /// <param name="decouvertAutorise">le découvert autorisé</param>
        public Compte(int numero, string nom, decimal solde, decimal decouvertAutorise)
        {
            this.numero = numero;
            this.nom = nom;
            this.solde = solde;
            this.decouvertAutorise = decouvertAutorise;
        }

        /// <summary>
        /// Constructeur de compte par défaut
        /// </summary>
        public Compte()
        {
            this.numero = 0;
            this.nom = "";
            this.solde = 0;
            this.decouvertAutorise = 0;
        }
        /// <summary>
        /// Réecriture de la méthode ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"numero: {Numero} nom: {Nom} solde: {Solde} decouvert autorisé: {DecouvertAutorise}";
        }

        /// <summary>
        /// Crédite le compte du montant spécifié
        /// </summary>
        /// <param name="montant">Le montant à créditer</param>
        public void Crediter(decimal montant)
        {
            if (montant >= 0)
            {
                Solde += montant;
            }
            return;
        }

        /// <summary>
        /// Débite le compte du montant spécifié si le solde le permet
        /// </summary>
        /// <param name="montant">Le montant à débiter</param>
        /// <returns>True si le débit a été effectué, False sinon</returns>
        public bool Debiter(decimal montant)
        {
            if (Solde >= montant)
            {
                Solde -= montant;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Transférer un montant vers un autre compte
        /// </summary>
        /// <param name="montant"></param>
        /// <param name="compteDestination"></param>
        /// <returns></returns>
        public bool Transferer(decimal n, Compte c)
        {
            if (Solde >= n && n > 0)
            {
                Solde -= n;
                c.Solde += n;
                return true;
            }
            return false; 
        }

        /// <summary>
        /// Savoir si le solde est supérieur à celui d'un autre compte
        /// </summary>
        /// <param name="compteDestination"></param>
        /// <returns></returns>
        public bool Superieur(Compte c)
        {
            if (Solde > c.Solde)
            {
                return true;
            }
            return false;
        }

    }
}
