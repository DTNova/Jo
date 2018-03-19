using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitaire
{
    using System.Diagnostics;
    using Bibliotheque;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            JeuxLettre jeux = new JeuxLettre();

            // 0:V
            // 1:B
            // 2:R

            // VRRB
            Combinaison code = new Combinaison(4);
            code.SetBoule(jeux.GetBoule(0), 0);
            code.SetBoule(jeux.GetBoule(2), 1);
            code.SetBoule(jeux.GetBoule(2), 2);
            code.SetBoule(jeux.GetBoule(1), 3);

            // VBBR : 1 noir 2 blancs
            Combinaison proposition = new Combinaison(4);
            proposition.SetBoule(jeux.GetBoule(0), 0);
            proposition.SetBoule(jeux.GetBoule(1), 1);
            proposition.SetBoule(jeux.GetBoule(1), 2);
            proposition.SetBoule(jeux.GetBoule(2), 3);

            Debug.WriteLine(code.Description());
            Debug.WriteLine(proposition.Description());

            code.Comparaison(proposition, jeux);

        }

        [TestMethod]
        public void TestMethod3()
        {
            JeuxLettre jeux = new JeuxLettre();
            Combinaison proposition;
            ResultatCompare compare;

            // RLJJ
            Combinaison code = jeux.CreateCombinaisonFromString("RLJJ");
            Debug.WriteLine(code.Description());

            // LLLL : 1 noir 0 blancs
            proposition = jeux.CreateCombinaisonFromString("LLLL");

            compare = code.Comparaison(proposition, jeux);
            Assert.AreEqual(compare.NbFicheNoir, 1);
            Assert.AreEqual(compare.NbFicheBlanche, 0);

            // LNNN : 0 noir 1 blancs
            proposition = jeux.CreateCombinaisonFromString("LNNN");

            compare = code.Comparaison(proposition, jeux);
            Assert.AreEqual(compare.NbFicheNoir, 0);
            Assert.AreEqual(compare.NbFicheBlanche, 1);

            // RLRR : 2 noir 0 blancs
            proposition = jeux.CreateCombinaisonFromString("RLRR");

            compare = code.Comparaison(proposition, jeux);
            Assert.AreEqual(compare.NbFicheNoir, 2);
            Assert.AreEqual(compare.NbFicheBlanche, 0);

            // RLVV : 2 noir 0 blancs
            proposition = jeux.CreateCombinaisonFromString("RLVV");

            compare = code.Comparaison(proposition, jeux);
            Assert.AreEqual(compare.NbFicheNoir, 2);
            Assert.AreEqual(compare.NbFicheBlanche, 0);

            // RLBB : 2 noir 0 blancs
            proposition = jeux.CreateCombinaisonFromString("RLBB");

            compare = code.Comparaison(proposition, jeux);
            Assert.AreEqual(compare.NbFicheNoir, 2);
            Assert.AreEqual(compare.NbFicheBlanche, 0);

            // RLJJ : 2 noir 0 blancs
            proposition = jeux.CreateCombinaisonFromString("RLJJ");

            compare = code.Comparaison(proposition, jeux);
            Assert.AreEqual(compare.NbFicheNoir, 4);
            Assert.AreEqual(compare.NbFicheBlanche, 0);
        }

        [TestMethod]
        public void CombinaisonAleatoire()
        {
            JeuxLettre jl = new JeuxLettre();

            for (int i = 0; i < 10; i++)
                Trace.WriteLine(jl.CombinaisonAleatoire());
        }
    }
}
