using NavyPqs.Domain.Models;
using NavyPqs.Domain.Models.Cwo;
using NUnit.Framework;
using System;

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

        [TestFixture]
        public class UpdatePqsTests
        {
            private readonly TestHelpers helper = new ();

            [Test]
            public void ShouldReturnUpdatedPqs()
            {
                var currentPqs = new TwoAlpha();
                var newPqs = new TwoAlpha();
                for(var i = 0; i < newPqs.Sections[4].Signed.Length; i++)           
                {
                    newPqs.Sections[4].Signed[i] = true;
                }

                var expected = new TwoAlpha();
                expected.Sections[4] = newPqs.Sections[4];

                var actual = Pqs.UpdatePqs(currentPqs, newPqs);

                Assert.AreEqual(helper.ToJson(expected), helper.ToJson(actual));
            }

            [Test]
            public void ShouldReturnCurrentIfNewIsNull()
            {
                var currentPqs = new TwoAlpha();
                currentPqs.Sections[0].Signed[0] = true;
                currentPqs.Sections[0].Signed[1] = true;
                currentPqs.Sections[0].Signed[2] = true;

                var actual = Pqs.UpdatePqs(currentPqs, null);

                Assert.AreEqual(helper.ToJson(currentPqs), helper.ToJson(actual));
            }

            [Test]
            public void ShouldThrowErrorForDifferingPqses()
            {
                var currentPqs = new TwoAlpha();
                var newPqs = new TwoBravo();

                var ex = Assert.Throws<ArgumentException>(() => Pqs.UpdatePqs(currentPqs, newPqs));
                var message = "Pqs.UpdatePqs tried to update two PQSes that were not the same: Current: CWO 2A CWO 2A, New: CWO 2B CWO 2B.";
                Assert.That(ex.Message, Is.EqualTo(message));
            }

            [Test]
            public void ShouldThrowErrorForDifferingSectionNames()
            {
                var currentPqs = new TwoAlpha();
                var newPqs = new TwoAlpha();
                newPqs.Sections[0].Name = "Foo";

                var ex = Assert.Throws<ArgumentException>(() => Pqs.UpdatePqs(currentPqs, newPqs));
                Assert.That(ex.Message, Is.EqualTo("Section.UpdateSigned tried to update two sections that were not the same: Current: 101 Safety Precautions, New: 101 Foo."));
            }

            [Test]
            public void ShouldThrowErrorForDifferingSectionNumbers()
            {
                var currentPqs = new TwoAlpha();
                var newPqs = new TwoAlpha();
                newPqs.Sections[0].Number = "12345";

                var ex = Assert.Throws<ArgumentException>(() => Pqs.UpdatePqs(currentPqs, newPqs));
                Assert.That(ex.Message, Is.EqualTo("Section.UpdateSigned tried to update two sections that were not the same: Current: 101 Safety Precautions, New: 12345 Safety Precautions."));
            }
        }
    }
}
