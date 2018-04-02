using NUnit.Framework;
using System;
using BoekenWinkel;

namespace BoekenWinkelUnitTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {

            BoekenWinkel.BoekenWinkel bo = BoekenWinkelConsole.AddData.GetData();

            Assert.NotNull(bo.OpeningsTijden,"Openingstijden zijn niet toegevoegd......");
            Assert.NotNull(bo.Voorraad, "Er is geen voorraad toegevoegd");
            Assert.NotNull(bo.ContactInformatie, "Er is geen contactinformatie toegevoegd..");

            try
            {
                Tijdschrift tijd = (Tijdschrift)bo.ZoekProduct("67672478829107");

                Assert.NotNull(tijd,"Geen tijdschrift gevonden op dat nummer");

                bo.VerwijderProduct("67672478829107");

                Assert.Null(bo.ZoekProduct("67672478829107"),"Het boek is niet verwijderd.");

            }catch(InvalidCastException ex){



            }
        }
    }
}
