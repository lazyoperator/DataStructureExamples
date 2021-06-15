using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureExamples.Arrays.Tests
{
    [TestFixture]
    public class MergeIntervalsTests
    {
        [Ignore("Fix this")]
        [Test]
        public void Test0()
        {
            int[,] intervals = new int[,] { { 1, 3 }, { 2, 6 }, { 8, 10 }, { 15, 18 } };
            int[,] output = { { 1, 6 }, { 8, 10 }, { 15, 18 } };

            var mergeIntervals = new MergeIntervals();
            var actual = mergeIntervals.Run(intervals);

            Assert.AreEqual(output, actual);
        }


        [Test]
        public void Test1()
        {
            int[,] intervals = new int[,] { { 2, 6 }, { 1, 3 }, { 8, 10 }, { 15, 18 } };
            int[,] output = { { 1, 6 }, { 8, 10 }, { 15, 18 } };

            var mergeIntervals = new MergeIntervals();
            var actual = mergeIntervals.RunSorted(intervals);

            Assert.AreEqual(output, actual);
        }

        [Test]
        public void Test2()
        {
            int[,] intervals = new int[,] { { 2, 6 }, { 1, 3 }, { 8, 10 }, { 10, 18 } };
            int[,] output = { { 1, 6 }, { 8, 18 } };

            var mergeIntervals = new MergeIntervals();
            var actual = mergeIntervals.RunSorted(intervals);

            Assert.AreEqual(output, actual);
        }

        [Ignore("Fix this")]
        [Test]
        public void Test3()
        {
            int[,] intervals = new int[,] { { 2, 6 }, { 1, 3 }, { 6, 10 }, { 15, 18 } };
            int[,] output = { { 1, 10 }, { 15, 18 } };

            var mergeIntervals = new MergeIntervals();
            var actual = mergeIntervals.RunSorted(intervals);

            Assert.AreEqual(output, actual);
        }
    }
}
