using NavyPqs.Data;
using NavyPqs.Domain.Models;
using NUnit.Framework;

namespace NavyPqs.TestFixture.DataTests
{
    public class SailorRepositoryTests
    {
        [SetUp]
        public void Setup() { }
        
        [Test]
        public void ShouldAddSailor()
        {
            var repository = new SailorRepository();
            var sailor = new Sailor("LT", "Jane", "Doe");
            repository.AddSailor(sailor);

            var expected = repository.GetSailors();
            
            Assert.AreEqual(1, expected.Count);
            Assert.AreEqual(sailor, expected[0]);

            var sailor2 = new Sailor("CT1", "John", "Jay");
            repository.AddSailor(sailor2);

            expected = repository.GetSailors();
            
            Assert.AreEqual(2, expected.Count);
            Assert.AreEqual(sailor, expected[0]);
            Assert.AreEqual(sailor2, expected[1]);
        }

        [Test]
        public void ShouldDeleteSailor()
        {
            var repository = new SailorRepository();
            repository.AddSailor(new Sailor("LT", "Jane", "Doe"));
            var sailor = new Sailor("CT1", "John", "Jay");
            repository.AddSailor(sailor);
            
            var expected = repository.GetSailors();
            Assert.AreEqual(2, expected.Count);

            repository.DeleteSailor(0);
            
            expected = repository.GetSailors();

            Assert.AreEqual(1, expected.Count);
            Assert.AreEqual(sailor, expected[0]);
        }
        
        [Test]
        public void ShouldHandleOutOfBoundsDeletion()
        {
            var repository = new SailorRepository();
            repository.AddSailor(new Sailor("LT", "Jane", "Doe"));
            
            repository.DeleteSailor(4);
            
            
        }
    }
}
