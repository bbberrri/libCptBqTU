using System;
using System.Linq;
using libCptBq;

internal class Program
{
    private static void Main(string[] args)
    {
        Banque b = new Banque();
        Compte c1 = new Compte(12345, "toto", 1000, -500);
        Compte c2 = new Compte(12654, "tintin", 5000, -500);
        
        b.AjouterCompte(c1);
        b.AjouterCompte(c2);
        Console.WriteLine(b);
        Console.WriteLine(b.RendCompte(324));
        Console.WriteLine(b.RendCompte(12345));
    }
}