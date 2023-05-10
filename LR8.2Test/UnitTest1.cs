using LR8._2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LR8._2Test
{
    [TestClass]
    public class TaskAdditionalTest
    {
        TaskAdditional tad = new TaskAdditional();
        [TestMethod]
        public void TheValueOfTheSineAndCosineTest1()
        {
            Assert.AreEqual((1.0/2).ToString(), tad.TheValueOfTheSineAndCosine(30, 0).ToString());
        }
        [TestMethod]
        public void TheValueOfTheSineAndCosineTest2()
        {
            Assert.AreEqual((Math.Sqrt(3)/2).ToString(), tad.TheValueOfTheSineAndCosine(30, 1).ToString());
        }
        [TestMethod]
        public void TheValueOfTheSineAndCosineTest3()
        {
            Assert.AreEqual((1/Math.Sqrt(3)).ToString(), tad.TheValueOfTheSineAndCosine(30, 2).ToString());
        }
        [TestMethod]
        public void TheValueOfTheSineAndCosineTest4()
        {
            Assert.AreEqual(Math.Sqrt(3).ToString(), tad.TheValueOfTheSineAndCosine(30, 3).ToString());
        }
        
        [TestMethod]
        public void TheValueOfTheSineAndCosineTest6()
        {
            Assert.AreEqual(Math.Sqrt(3).ToString(), tad.TheValueOfTheSineAndCosine(60, 2).ToString());
        }
    }
}
