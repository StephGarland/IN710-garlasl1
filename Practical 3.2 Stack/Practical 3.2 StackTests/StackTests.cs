using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practical_3._2_Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3._2_Stack.Tests
{
    [TestClass()]
    public class StackTests
    {
        [TestMethod()]
        public void StackTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PushTest_AddOne()
        {
            Stack stack = new Stack();
            string newString = "test";

            stack.Push(newString);

            //tests that newString has been correctly added
            Assert.AreEqual(newString, stack.Peek());
            //tests that one string has been added to an empty stack
            Assert.AreEqual(1, stack.Count());
        }

        [TestMethod()]
        public void PushTest_AddMultiple()
        {
            Stack stack = new Stack();
            string firstString = "I'm first";
            string secondString = "I'm second";

            stack.Push(firstString);
            stack.Push(secondString);

            //tests that strings were pushed in the expected order
            Assert.AreEqual(secondString, stack.Peek());
        }

        //pop called on empty stack
        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void PopTest_EmptyStack()
        {
            Stack stack = new Stack();
            stack.Pop();
        }

        //peek called on empty stack
        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void PeekTest_EmptyStack()
        {
            Stack stack = new Stack();
            stack.Peek();
        }

        [TestMethod()]
        public void PeekTest_ShowLastOfMultiple()
        {
            Stack stack = new Stack();
            string firstString = "I'm first";
            string secondString = "I'm second";

            stack.Push(firstString);
            stack.Push(secondString);

            //tests that peek is returning the last added
            Assert.AreEqual(secondString, stack.Peek());
            //tests that it did not delete anything
            Assert.AreEqual(2, stack.Count());
        }

        [TestMethod()]
        public void CountTest_CountMultiple()
        {
            Stack stack = new Stack();
            string firstString = "I'm first";
            string secondString = "I'm second";

            stack.Push(firstString);
            stack.Push(secondString);

            //tests that the count is counting all added strings
            Assert.AreEqual(2, stack.Count());
        }

        [TestMethod()]
        public void CountTest_CountEmpty()
        {
            Stack stack = new Stack();

            //tests that the count returns 0
            Assert.AreEqual(0, stack.Count());
        }

        [TestMethod()]
        public void CountTest_CountAfterPop()
        {
            Stack stack = new Stack();
            string firstString = "I'm first";
            string secondString = "I'm second";

            stack.Push(firstString);
            stack.Push(secondString);

            stack.Pop();

            //tests that the count is counting only non-popped strings
            Assert.AreEqual(1, stack.Count());
        }

        [TestMethod()]
        [ExpectedException(typeof(OutOfMemoryException))]
        public void CountTest_CountStackLargerThanInt()
        {
            Stack stack = new Stack();
            for (int i = 0; i < int.MaxValue; i++)
            {
                stack.Push("");
            }
            stack.Push("");
        }

        //is empty called on a newly created stack
        [TestMethod()]
        public void isEmptyTest_NewStack()
        {
            Stack stack = new Stack();
            Assert.IsTrue(stack.isEmpty());
        }

        //is empty called on a stack that used to have items, but from which all items have been popped
        [TestMethod()]
        public void isEmptyTest_OncePopulatedNowEmpty()
        {
            Stack stack = new Stack();
            string firstString = "I'm first";
            string secondString = "I'm second";

            stack.Push(firstString);
            stack.Push(secondString);
            stack.Pop();
            stack.Pop();

            Assert.IsTrue(stack.isEmpty());
        }
    }
}