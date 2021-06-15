using NUnit.Framework;
using System;

namespace DataStructureExamples.Stacks.Tests
{
    [TestFixture]
    public class DynamicStackIntegerTests
    {
        [Test]
        public void PushTest()
        {
            var expected = 3;
            var stack = new DynamicStackInteger();

            stack.Push(expected);

            Assert.AreEqual(expected, stack.Peek());
        }

        [Test]
        public void PopTest()
        {
            var stack = new DynamicStackInteger();

            Assert.Throws<InvalidOperationException>(() => stack.Pop());

            stack.Push(2);
            stack.Push(4);

            Assert.AreEqual(4, stack.Pop());
            Assert.AreEqual(2, stack.Peek());

            Assert.AreEqual(2, stack.Pop());
        }

        [Test]
        public void IsEmptyTest()
        {
            var stack = new DynamicStackInteger();

            Assert.IsTrue(stack.IsEmpty());
            Assert.Throws<InvalidOperationException>(() => stack.Peek());


            stack.Push(12);
            stack.Push(15);
            stack.Pop();
            stack.Pop();

            Assert.IsTrue(stack.IsEmpty());
        }

        [Test]
        public void IsFullTest()
        {
            var stack = new DynamicStackInteger();

            Assert.IsFalse(stack.IsFull());

            stack.Push(2);
            stack.Push(4);
            stack.Push(7);
            stack.Push(9);
            stack.Push(6);

            Assert.IsTrue(stack.IsFull());
            Assert.AreEqual(6, stack.Peek());

            //Double Stack Capacity Test

            stack.Push(18);
            stack.Push(19);
            stack.Push(20);

            Assert.IsFalse(stack.IsFull());
            Assert.AreEqual(20, stack.Peek());

            Assert.AreEqual(20, stack.Pop());
            Assert.AreEqual(19, stack.Peek());
        }
    }
}