using NavyPqs.Data;
using NavyPqs.Domain.Models;
using NUnit.Framework;
using NavyPqs.Ui.Models;

namespace NavyPqs.TestFixture.UiTests.ModelTests
{
    [TestFixture]
    public class CreateSailorVmFromTests
    {
        private readonly TestHelpers helper = new TestHelpers();
        private SailorRepository repository;

        [SetUp]
        public void Setup()
        {
            repository = new SailorRepository();
        }

        [Test]
        public void ShouldCreateASailorVm()
        {
            helper.InstanceSailors(repository, 2);
            Sailor expected = repository.GetSailor(0);

            var actual = SailorViewModel.CreateFrom(expected);

            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.Rank, actual.Rank);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
