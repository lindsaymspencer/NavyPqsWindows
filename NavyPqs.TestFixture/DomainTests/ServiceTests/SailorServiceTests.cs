using Moq;
using NavyPqs.Domain.Interfaces;
using NavyPqs.Domain.Services;
using NUnit.Framework;
using System;

namespace NavyPqs.TestFixture.DomainTests.ServiceTests
{
    [TestFixture]
    public class SailorServiceTests
    {
        private Mock<ISailorRepository> mockSailorRepository;
        private SailorService sailorService;
        private TestHelpers helper;

        [SetUp]
        public void Setup()
        {
            mockSailorRepository = new Mock<ISailorRepository>();
            sailorService = new SailorService(mockSailorRepository.Object);
            helper = new TestHelpers();
        }

        [Test]
        public void ShouldCallGetSailor()
        {
            sailorService.GetSailor(0);
            mockSailorRepository.Verify(m => m.GetSailor(0), Times.Once);
        }

        [Test]
        public void ShouldCallGetSailors()
        {
            sailorService.GetSailors();
            mockSailorRepository.Verify(m => m.GetSailors());
        }

        [Test]
        public void ShouldCallCreateSailor()
        {
            const string rank = "SEA";
            const string firstName = "John";
            const string lastName = "Doe";
            sailorService.CreateSailor(rank, firstName, lastName);
            mockSailorRepository.Verify(m => m.CreateSailor(rank, firstName, lastName), Times.Once);
        }

        [Test]
        public void ShouldCallEditSailor()
        {
            var sailor = helper.Sailors[0];
            sailorService.EditSailor(9, sailor);
            mockSailorRepository.Verify(m => m.EditSailor(9, sailor), Times.Once);
        }

        [Test]
        public void ShouldCallDeleteSailor()
        {
            sailorService.DeleteSailor(29);
            mockSailorRepository.Verify(m => m.DeleteSailor(29), Times.Once);
        }

        [Test]
        public void ShouldAddCwo2APqs()
        {
            mockSailorRepository.Setup(m => m.GetSailor(0)).Returns(helper.Sailors[0]);

            var sailor = helper.Sailors[0];
            sailorService.AddPqsTo(sailor.Id, "CWO-2A");
            var actual = sailor.ToJson();

            Assert.AreEqual(helper.Sailor0WithCwo2A, actual);
        }

        [Test]
        public void ShouldAddCwo2BPqs()
        {
            mockSailorRepository.Setup(m => m.GetSailor(1)).Returns(helper.Sailors[1]);

            var sailor = helper.Sailors[1];
            sailorService.AddPqsTo(sailor.Id, "CWO-2B");
            var actual = sailor.ToJson();

            Assert.AreEqual(helper.Sailor1WithCwo2B, actual);
        }

        [Test]
        public void ShouldAddBothCwoPqs()
        {
            mockSailorRepository.Setup(m => m.GetSailor(2)).Returns(helper.Sailors[2]);

            var sailor = helper.Sailors[2];
            sailorService.AddPqsTo(sailor.Id, "CWO-2A");
            sailorService.AddPqsTo(sailor.Id, "CWO-2B");
            var actual = sailor.ToJson();

            Assert.AreEqual(helper.Sailor2WithBothCwo, actual);
        }

        [Test]
        public void ShouldThrowExceptionForUnknownPqs()
        {
            mockSailorRepository.Setup(m => m.GetSailor(2)).Returns(helper.Sailors[2]);

            var sailor = helper.Sailors[2];
            

            var result = Assert.Throws<ArgumentException>(() => sailorService.AddPqsTo(sailor.Id, "Foo"));
            Assert.AreEqual("Unknown PQS: Foo", result.Message);
        }


        [Test]
        public void ShouldThrowExceptionIfConstructedWithNoRepository()
        {
            var result = Assert.Throws<ArgumentNullException>(() => new SailorService(null));
            Assert.AreEqual("Value cannot be null. (Parameter 'repository')", result.Message);
        }
    }
}
