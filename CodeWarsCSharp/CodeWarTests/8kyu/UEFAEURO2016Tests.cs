using CodeWars;
using NUnit.Framework;


namespace CodeWarsTests
{
    [TestFixture]
    class UefaEuroTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("At match Germany - Ukraine, Germany won!", UefaEuro.UefaEuro2016(new[] { "Germany", "Ukraine" }, new[] { 2, 0 }));
            Assert.AreEqual("At match Belgium - Italy, Italy won!", UefaEuro.UefaEuro2016(new[] { "Belgium", "Italy" }, new[] { 0, 2 }));
            Assert.AreEqual("At match Portugal - Iceland, teams played draw.", UefaEuro.UefaEuro2016(new[] { "Portugal", "Iceland" }, new[] { 1, 1 }));
        }
    }
}
