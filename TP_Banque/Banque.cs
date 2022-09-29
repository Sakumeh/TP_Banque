using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Banque
{
    public class Banque
    {
        private List<Compte> LesComptes;

        public Banque()
        {
            this.LesComptes = new List<Compte>();
        }


        public void AjouteCompte(Compte c1)
        {
            this.LesComptes.Add(c1);
        }

        public void AjouteCompte(string nom, int idCompte, int solde, int Decouvert)
        {
            Compte c1 = new Compte(nom, idCompte, solde, Decouvert);
            this.LesComptes.Add(c1);
        }


        public Compte compteMax()
        {
            double soldeTemporaire = 0;
            int indexTemporaire = 0;

            for (int i = 0; i < LesComptes.Count; i++)
            {
                if (soldeTemporaire < LesComptes[i].getSolde())
                {
                    soldeTemporaire = LesComptes[i].getSolde();
                    indexTemporaire = i;
                }
            }
            return LesComptes[indexTemporaire];
        }
    }
}
