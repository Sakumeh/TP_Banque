using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Banque
{
    public class Compte
    {
        private string nom;
        private int idCompte;
        private double solde;
        private double decouvert;

        public Compte(string nom, int idCompte, double solde, double decouvert)
        {
            this.nom = nom;
            this.idCompte = idCompte;
            this.solde = solde;
            this.decouvert = decouvert;
        }

        public int getIdCompte()
        {
            return this.idCompte;
        }


        public string getNom()
        {
            return nom;
        }

        public double getSolde()
        {
            return solde;
        }

        public double getDecouvert()
        {
            return decouvert;
        }

        public bool superieur(Compte c2)
        {
            if (this.solde > c2.solde)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void crediter(double argent)
        {
            solde = solde + argent;
        }
        public void debiter(double argent)
        {
            if (solde - argent < decouvert)
            {
                Console.WriteLine("Decouvert dépassé action impossible");
            }
            else
            {
                solde = solde - argent;
            }
        }

        public void transferer(double argent, Compte c2)
        {
            solde = solde - argent;
            if (solde - argent < decouvert)
            {
                Console.WriteLine("Decouvert dépassé");
            }
            else
            {
                c2.solde = c2.solde + argent;
            }

        }

        public override string ToString()
        {
            return "Numéro du compte : " + this.idCompte + "\n" +
                "Nom : " + this.nom + "\n" +
                "Solde : " + this.solde + "\n" +
                "Découvert autorisé : " + this.decouvert;

        }
    }
}
