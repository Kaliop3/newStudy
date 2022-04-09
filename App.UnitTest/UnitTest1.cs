using NUnit.Framework;
using System;
using app;
using System.Collections.Generic;

namespace App.UnitTest
{
    public class CheckSort
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void TestSort()
        {
            List<int> listToSort = new List<int>()
            { 85, 9, 12, 85, 1, 3
            };

            var listSortedByFunction = new List<int>();
            listSortedByFunction = Sorter.Sort(listToSort);

            List<int> listSorted = new List<int>()
            { 1, 3, 9, 12, 85, 85
            };
            //Assert
            Assert.AreEqual(listSorted, listSortedByFunction);
           
        }
    }
}