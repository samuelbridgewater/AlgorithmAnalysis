using Microsoft.VisualStudio.TestTools.UnitTesting;
using AAnalysis;
using System;
using System.Diagnostics;

namespace Analysis_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSequentialSearch()
        {
            var rand = new Random();

            //setup variables
            int[] array = { 32, 56, 42, 32, 5, 67, 78, 0, 19992, 4 };
            int key = rand.Next(array.Length - 1);
            Trace.WriteLine(key+"!!!!!!!!!!!!!!!!!!!!!!");

            Algorithms arrayObj = new Algorithms();

            Assert.AreEqual(Array.IndexOf(array,array[key]), arrayObj.SequentialSearch(array, array[key]));


        }

        [TestMethod]
        public void TestArrayMax()
        {
            //setup variables
            int[] array = { 32, 56, 42, 32, 5, 67, 78, 0, 19992, 4 };

            Algorithms arrayMax = new Algorithms();

            Assert.AreEqual(19992, arrayMax.ArrayMax(array));

        }
    }
}
