using CodeSkill_MissingNumber;
using NUnit.Framework;
using System;

namespace CodeSkill_11._12._2017.Tests
{
    [TestFixture]
    public class MissingNumberFinder
    {
        [Test]
        public void FirstMissingNumber_WithMissingNumbers_UpByOne()
        {
            var w = new int[] {-4, -3, -1, 2, 4 };
            var a = new CodeSkill_MissingNumber.MissingNumberFinder(w);
            Assert.That(a.FirstMissingNumber, Is.EqualTo(-2));
        }

        [Test]
        public void FirstMissingNumber_WithAllNumbers_UpByOne()
        {
            var w = new int[] {-4, -3, -2, -1, 0, 1, 2, 3, 4 };
            var a = new CodeSkill_MissingNumber.MissingNumberFinder(w);
            Assert.That(a.FirstMissingNumber, Is.EqualTo(5));
        }

        [Test]
        public void FirstMissingNumber_WithEmptyArray_ThrowException()
        {
            var w = new int[] {};
            var a = new CodeSkill_MissingNumber.MissingNumberFinder(w);
            Assert.Throws<Exception>(() => a.FirstMissingNumber(), "Collection is empty, unspecified beginning of the collection");
        }
    }
}
