using NUnit.Framework;

namespace NavyPqs.TestFixture.DomainTests.ModelTests
{
    public class SailorTests
    {
        private TestHelpers helper;

        [SetUp]
        public void Setup()
        {
            helper = new TestHelpers();
        }

        [Test]
        public void CreatesWithTwoAlphaPqs()
        {
            var sailor = helper.Sailors[0];
            sailor.Pqses.Add(new Domain.Models.Cwo.TwoAlpha());
            var actual = sailor.ToJson();

            Assert.AreEqual(helper.Sailor0WithCwo2A, actual);
        }

        [Test]
        public void CreatesWithTwoBravoPqs()
        {
            var sailor = helper.Sailors[1];
            sailor.Pqses.Add(new Domain.Models.Cwo.TwoBravo());
            var actual = sailor.ToJson();

            Assert.AreEqual(helper.Sailor1WithCwo2B, actual);
        }

        [Test]
        public void CreatesWithBothCwoPqs()
        {
            var sailor = helper.Sailors[2];
            sailor.Pqses.Add(new Domain.Models.Cwo.TwoAlpha());
            sailor.Pqses.Add(new Domain.Models.Cwo.TwoBravo());
            var actual = sailor.ToJson();

            Assert.AreEqual(helper.Sailor2WithBothCwo, actual);
        }
    }
}
