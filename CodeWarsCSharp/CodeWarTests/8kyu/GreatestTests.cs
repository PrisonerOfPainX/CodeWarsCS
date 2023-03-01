using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    static class ProgramTests
    {
        [Test]
        public static void BasicTests()
        {
            Assert.AreEqual("Nenhum é maior", 34.Maior(34));
        }
    }
}
