using System;
using NavyPqs.Domain.Models;
using NUnit.Framework;

namespace NavyPqs.TestFixture.DomainTests.ModelTests
{
    [TestFixture]
    public class SectionTests
    {
        private readonly Section original = new Section
        {
            LineItem = new[] { "Line 1", "Line 2" },
            Name = "Section 1",
            Number = "Number 1",
            Signed = new[] { true, false, true }
        };

        [Test]
        public void ShouldCopySection()
        {
            var actual = new Section
            {
                LineItem = original.LineItem,
                Name = original.Name,
                Number = original.Number,
                Signed = new bool[3]
            };

            actual = Section.UpdateSigned(actual, original);

            CollectionAssert.AreEqual(original.LineItem, actual.LineItem);
            CollectionAssert.AreEqual(original.Signed, actual.Signed);
            Assert.AreEqual(original.Name, actual.Name);
            Assert.AreEqual(original.Number, actual.Number);
        }

        [Test]
        public void ShouldNotCopyIfCopyFromIsNull()
        {
            var ex = Assert.Throws<ArgumentException>(() => Section.UpdateSigned(original, null));
            Assert.That(ex.Message, Is.EqualTo("Section.UpdateSigned tried to update two sections" +
                    " that were not the same: Current: Number 1 Section 1, New: null section."));
        }

        [Test]
        public void ShouldNotCopyIfCopyFromNameIsDifferent()
        {
            var actual = new Section
            {
                LineItem = original.LineItem,
                Name = "Section 2",
                Number = original.Number,
                Signed = new bool[3]
            };

            var ex = Assert.Throws<ArgumentException>(() => Section.UpdateSigned(original, actual));
            Assert.That(ex.Message, Is.EqualTo("Section.UpdateSigned tried to update two sections" +
               " that were not the same: Current: Number 1 Section 1, New: Number 1 Section 2."));
        }

        [Test]
        public void ShouldNotCopyIfCopyFromNumberIsDifferent()
        {
            var actual = new Section
            {
                LineItem = original.LineItem,
                Name = original.Name,
                Number = "Number 2",
                Signed = new bool[3]
            };

            var ex = Assert.Throws<ArgumentException>(() => Section.UpdateSigned(original, actual));
            Assert.That(ex.Message, Is.EqualTo("Section.UpdateSigned tried to update two sections" +
                  " that were not the same: Current: Number 1 Section 1, New: Number 2 Section 1."));
        }

        [Test]
        public void ShouldNotCopyIfCopyFromLineIsDifferent()
        {
            var actual = new Section
            {
                LineItem = new[] { "Line 3", "Line 4" },
                Name = original.Name,
                Number = original.Number,
                Signed = new bool[3]
            };

            var ex = Assert.Throws<ArgumentException>(() => Section.UpdateSigned(original, actual));
            Assert.That(ex.Message, Is.EqualTo("Section.UpdateSigned tried to update two sections" +
                    " that were not the same: Current: Number 1 Section 1, New: Number 1 Section 1."));
        }

        [Test]
        public void ShouldNotCopyIfCopyFromLineAmountsAreDifferent()
        {
            var actual = new Section
            {
                LineItem = new[] { "Line 1", "Line 2", "Line 3" },
                Name = original.Name,
                Number = original.Number,
                Signed = new bool[3]
            };

            var ex = Assert.Throws<ArgumentException>(() => Section.UpdateSigned(original, actual));
            Assert.That(ex.Message, Is.EqualTo("Section.UpdateSigned tried to update two sections" +
                                               " that were not the same: Current: Number 1 Section 1, New: Number 1 Section 1."));
        }

        [Test]
        public void ShouldNotCopyIfCopyFromSignedAmountsAreDifferent()
        {
            var actual = new Section
            {
                LineItem = original.LineItem,
                Name = original.Name,
                Number = original.Number,
                Signed = new bool[6]
            };

            var ex = Assert.Throws<ArgumentException>(() => Section.UpdateSigned(original, actual));
            Assert.That(ex.Message, Is.EqualTo("Section.UpdateSigned tried to update two sections" +
                                               " that were not the same: Current: Number 1 Section 1, New: Number 1 Section 1."));
        }
    }
}
