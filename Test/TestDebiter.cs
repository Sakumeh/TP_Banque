using NUnit.Framework;
using TP_Banque;

namespace TestUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {     
        }


        [Test]
        public void Test1()
        {
            double solde = 1000;
            double debit = 10;
            double attendu = 990;
            double decouvertAut = 100;

            Compte C1 = new Compte("Heusslaga", 92, solde, decouvertAut);

            C1.debiter(debit);

            double actuel = C1.getSolde();
            Assert.AreEqual(attendu, actuel, 001, "Account not debited correctly");
        }
    }
}
