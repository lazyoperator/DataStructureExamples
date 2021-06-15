using NUnit.Framework;
using System.Linq;

namespace DataStructureExamples.Arrays.Tests
{
    [TestFixture]
    public class ProductOfArrayExceptSelfTests
    {
        [Test]
        public void Test0()
        {
            int[] num = { 1, 2, 3, 4 };            
            int[] output = { 24, 12, 8, 6 };

            var productOfArrayExceptSelf = new ProductOfArrayExceptSelf();
            var actual = productOfArrayExceptSelf.HighOptimisedProduct(num);

            Assert.IsTrue(Enumerable.SequenceEqual(output, actual));
        }

        [Test]
        public void Test1()
        {
            int[] num = { -1, 1, 0, -3, 3 };
            int[] output = { 0, 0, 9, 0, 0 };

            var productOfArrayExceptSelf = new ProductOfArrayExceptSelf();
            var actual = productOfArrayExceptSelf.HighOptimisedProduct(num);

            Assert.IsTrue(Enumerable.SequenceEqual(output, actual));
        }
    }
}
