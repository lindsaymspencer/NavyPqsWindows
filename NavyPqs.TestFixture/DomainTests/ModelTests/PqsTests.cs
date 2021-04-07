using NavyPqs.Domain.Models;
using NUnit.Framework;

namespace NavyPqs.TestFixture.DomainTests.ModelTests
{
    [TestFixture]
    public class PqsTests
    {
        [Test]
        public void ShouldGetAvailablePqses()
        {
            var expected = new[] { "CWO-2A", "CWO-2B" };
            var actual = Pqs.GetAvailable();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
