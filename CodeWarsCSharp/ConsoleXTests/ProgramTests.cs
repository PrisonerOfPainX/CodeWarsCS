using ConsoleX;
using NUnit.Framework;

namespace ConsoleXTests
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
