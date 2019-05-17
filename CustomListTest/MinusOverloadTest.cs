using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class MinusOverloadTest
    {
        [TestMethod]
        public void MinusOperatorOverload_OperatorOverload_DoItemsGetMerged()
        {
            //Arrange
            CustomList<int> List = new CustomList<int>();
            CustomList<int> List2 = new CustomList<int>();
            string expected;
            string actual;


            //Act
            List.Add(2);
            List.Add(4);
            List.Add(6);
            List2.Add(4);
            List2.Add(6);
            CustomList<int> List3 = List - List2;
            actual = List3.ToString();
            expected = ("2");

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void MinusOperatorOverload_OperatorOverload_DoItemsGetMergedWithLargerAmountsOfSameNumber()
        {
            //Arrange
            CustomList<int> List = new CustomList<int>();
            CustomList<int> List2 = new CustomList<int>();
            string expected;
            string actual;


            //Act
            List.Add(2);
            List.Add(4);
            List.Add(6);
            List.Add(6);
            List.Add(6);
            List2.Add(4);
            List2.Add(6);
            CustomList<int> List3 = List - List2;
            actual = List3.ToString();
            expected = ("2");

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void MinusOperatorOverload_OperatorOverload_DoItemsGetMergedWithLargerAmountsOfSameNumberOnTheSubtractorSide()
        {
            //Arrange
            CustomList<int> List = new CustomList<int>();
            CustomList<int> List2 = new CustomList<int>();
            string expected;
            string actual;


            //Act
            List.Add(2);
            List.Add(4);
            List.Add(6);
            List2.Add(6);
            List2.Add(6);
            List2.Add(4);
            List2.Add(6);
            CustomList<int> List3 = List - List2;
            actual = List3.ToString();
            expected = ("2");

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
