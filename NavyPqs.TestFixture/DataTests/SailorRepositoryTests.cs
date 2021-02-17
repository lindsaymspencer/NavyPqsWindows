using NavyPqs.Data;
using NUnit.Framework;
using System.Linq;

namespace NavyPqs.TestFixture.DataTests
{
    [TestFixture]
    public class SailorRepositoryTests
    {
        [TestFixture]
        public class CreateSailorTests
        {
            private readonly TestHelpers helper = new TestHelpers();
            private SailorRepository repository;

            [SetUp]
            public void Setup()
            {
                repository = new SailorRepository();
            }

            [Test]
            public void ShouldCreateSailor()
            {
                var response = repository.CreateSailor(helper.Sailors[0].Rank, helper.Sailors[0].FirstName, helper.Sailors[0].LastName);
                Assert.IsTrue(response);

                var sailors = repository.GetSailors();

                Assert.AreEqual(1, sailors.Count);
                Assert.IsTrue(helper.IsSailorEqualExcludingId(helper.Sailors[0], sailors[0]));

                response = repository.CreateSailor(helper.Sailors[1].Rank, helper.Sailors[1].FirstName, helper.Sailors[1].LastName);
                Assert.IsTrue(response);

                sailors = repository.GetSailors();

                Assert.AreEqual(2, sailors.Count);
                Assert.IsTrue(helper.IsSailorEqualExcludingId(helper.Sailors[0], sailors[0]));
                Assert.IsTrue(helper.IsSailorEqualExcludingId(helper.Sailors[1], sailors[1]));
            }

            [Test]
            public void ShouldHandleNullValues()
            {
                var response = repository.CreateSailor(null, null, null);
                Assert.IsTrue(response);

                var sailors = repository.GetSailors();
                Assert.AreEqual(1, sailors.Count);
                Assert.IsNull(sailors[0].Rank);
                Assert.IsNull(sailors[0].FirstName);
                Assert.IsNull(sailors[0].LastName);
            }
        }

        [TestFixture]
        public class DeleteSailorTests
        {
            private readonly TestHelpers helper = new TestHelpers();
            private SailorRepository repository;

            [SetUp]
            public void Setup()
            {
                repository = new SailorRepository();
            }

            [Test]
            public void ShouldDeleteSailor()
            {
                helper.InstanceSailors(repository, 2);
                var expected = repository.GetSailors();
                Assert.AreEqual(2, expected.Count);

                repository.DeleteSailor(0);

                expected = repository.GetSailors();

                Assert.AreEqual(1, expected.Count);
                Assert.AreEqual(helper.Sailors[1].Rank, expected[0].Rank);
                Assert.AreEqual(helper.Sailors[1].FirstName, expected[0].FirstName);
                Assert.AreEqual(helper.Sailors[1].LastName, expected[0].LastName);
            }

            [Test]
            public void ShouldHandleOutOfBoundsDeletion()
            {
                helper.InstanceSailors(repository, 2);
                var expected = repository.GetSailors();
                Assert.AreEqual(2, expected.Count);
                
                bool response = repository.DeleteSailor(4);
                Assert.IsFalse(response);

                response = repository.DeleteSailor(-6);
                Assert.IsFalse(response);
            }
        }

        [TestFixture]
        public class EditSailorTests
        {
            private readonly TestHelpers helper = new TestHelpers();
            private SailorRepository repository;

            [SetUp]
            public void Setup()
            {
                repository = new SailorRepository();
            }

            [Test]
            public void ShouldEditSailor()
            {
                helper.InstanceSailors(repository, 2);

                var editedSailor = helper.Sailors[2];
                editedSailor.Id = 0;

                var response = repository.EditSailor(0, editedSailor);
                Assert.IsTrue(response);

                var actual = repository.GetSailors();
                Assert.AreEqual(2, actual.Count);
                Assert.AreEqual(0, actual[0].Id);
                Assert.AreEqual(helper.Sailors[2].Rank, actual[0].Rank);
                Assert.AreEqual(helper.Sailors[2].FirstName, actual[0].FirstName);
                Assert.AreEqual(helper.Sailors[2].LastName, actual[0].LastName);
            }

            [Test]
            public void ShouldHandleOutOfBoundsEdit()
            {
                helper.InstanceSailors(repository, 2);

                bool response = repository.EditSailor(7, helper.Sailors[3]);
                Assert.IsFalse(response);

                var sailors = repository.GetSailors();
                var actual = sailors.Where(x => x.FirstName == helper.Sailors[3].FirstName);
                Assert.IsEmpty(actual);
            }

            [Test]
            public void ShouldHandleEditWithNonMatchingIds()
            {
                helper.InstanceSailors(repository, 2);

                bool response = repository.EditSailor(1, helper.Sailors[3]);
                Assert.IsFalse(response);

                var sailors = repository.GetSailors();
                var actual = sailors.Where(x => x.FirstName == helper.Sailors[3].FirstName);
                Assert.IsEmpty(actual);

                var sailor = repository.GetSailor(1);
                Assert.AreEqual(helper.Sailors[1].Id, sailor.Id);
                Assert.AreEqual(helper.Sailors[1].FirstName, sailor.FirstName);
                Assert.AreEqual(helper.Sailors[1].LastName, sailor.LastName);
                Assert.AreEqual(helper.Sailors[1].Rank, sailor.Rank);
            }

            [Test]
            public void ShouldHandleEditWithNonIncludedSailor()
            {
                helper.InstanceSailors(repository, 2);

                bool response = repository.EditSailor(3, helper.Sailors[3]);
                Assert.IsFalse(response);

                var sailors = repository.GetSailors();
                var actual = sailors.Where(x => x.FirstName == helper.Sailors[3].FirstName);
                Assert.IsEmpty(actual);
            }
        }
    }
}
