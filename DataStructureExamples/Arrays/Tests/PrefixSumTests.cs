using NUnit.Framework;

namespace DataStructureExamples.Arrays.Tests
{
    [TestFixture]
    public class SubarraySumEqualsKTests
    {

        [Test]
        public void Test0()
        {
            int[] num = { 1, -1, 0 };
            var k = 0;
            var output = 3;

            var SubarraySumEqualsK = new SubarraySumEqualsK();
            var actual = SubarraySumEqualsK.SubarraySum(num, k);

            Assert.AreEqual(output, actual);
        }

        [Test]
        public void Test1()
        {
            int[] num = { 1, 1, 1 };
            var K = 2;
            var output = 2;

            var SubarraySumEqualsK = new SubarraySumEqualsK();
            var actual = SubarraySumEqualsK.SubarraySum(num, K);

            Assert.AreEqual(output, actual);
        }

        [Test]
        public void Test2()
        {
            int[] num = { 1, 2, 3 };
            var K = 3;
            var output = 2;

            var SubarraySumEqualsK = new SubarraySumEqualsK();
            var actual = SubarraySumEqualsK.SubarraySum(num, K);

            Assert.AreEqual(output, actual);
        }

        [Test]
        public void Test3()
        {
            int[] num = { 1, -2, 2, 2,-2, 2 };
            var K = 3;
            var output = 2;

            var SubarraySumEqualsK = new SubarraySumEqualsK();
            var actual = SubarraySumEqualsK.SubarraySum(num, K);

            Assert.AreEqual(output, actual);
        }

        [Test]
        public void Test4()
        {
            int[] num = { -1, -1, 1 };
            var K = 0;
            var output = 1;

            var SubarraySumEqualsK = new SubarraySumEqualsK();
            var actual = SubarraySumEqualsK.SubarraySum(num, K);

            Assert.AreEqual(output, actual);
        }
    }
}
