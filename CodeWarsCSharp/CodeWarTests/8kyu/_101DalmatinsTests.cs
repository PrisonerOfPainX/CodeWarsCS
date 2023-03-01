using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    class DalmatinsTests
    {
        [Test]
        public void BasicTest()
        {
            StringAssert.AreEqualIgnoringCase("More than a handful!", Dalmatins.HowManyDalmatians(26));
            StringAssert.AreEqualIgnoringCase("Hardly any", Dalmatins.HowManyDalmatians(8));
            StringAssert.AreEqualIgnoringCase("More than a handful!", Dalmatins.HowManyDalmatians(14));
            StringAssert.AreEqualIgnoringCase("Woah that's a lot of dogs!", Dalmatins.HowManyDalmatians(80));
            StringAssert.AreEqualIgnoringCase("Woah that's a lot of dogs!", Dalmatins.HowManyDalmatians(100));
            StringAssert.AreEqualIgnoringCase("More than a handful!", Dalmatins.HowManyDalmatians(50));
            StringAssert.AreEqualIgnoringCase("Hardly any", Dalmatins.HowManyDalmatians(10));
            StringAssert.AreEqualIgnoringCase("101 DALMATIONS!!!", Dalmatins.HowManyDalmatians(101));
        }
    }
}
