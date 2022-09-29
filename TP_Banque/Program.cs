using System;

namespace TP_Banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte c1 = new Compte("Toto", 12345, 1000, -500);
            Compte c2 = new Compte("titi", 45657, 2000, -1000);
            c1.crediter(2000);
            c1.debiter(3600);


            if (c1.superieur(c2))
                Console.WriteLine("C1 est supérieur à C2");
            else
                Console.WriteLine("C1 est inférieur à C2");
            Console.WriteLine(c1.ToString());



            Banque b = new Banque();
            b.AjouteCompte(c1);
            b.AjouteCompte(c2);
            b.AjouteCompte("dutronc", 1245, 4500, -500);
            //Console.WriteLine(b.compteMax().ToString());
            Console.ReadKey();
        }
    }
}
