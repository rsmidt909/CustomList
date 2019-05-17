using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class PlusOverloadTest
    {
        [TestMethod]
        public void PlusOverLoadOperator_OverLoadOperator_DoesMethodMergeToArrays()
        {
            //Arrange
            CustomList<int> List = new CustomList<int>();
            CustomList<int> List2 = new CustomList<int>();
            string expected;
            string actual;

            //Act
            List.Add(5);
            List.Add(7);
            List2.Add(6);
            List2.Add(8);
            CustomList<int> List3 = List + List2;
            expected = "5, 6, 7, 8";
            actual = List3.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOverLoadOperator_OverLoadOperator_DoesMethodMergeProperlyWithMoreInOneThanOther()
        {
            //Arrange
            CustomList<int> List = new CustomList<int>();
            CustomList<int> List2 = new CustomList<int>();
            string expected;
            string actual;

            //Act
            List.Add(5);
            List.Add(7);
            List.Add(9);
            List.Add(10);
            List.Add(11);
            List2.Add(6);
            List2.Add(8);
            CustomList<int> List3 = List + List2;
            expected = "5, 6, 7, 8, 9, 10, 11";
            actual = List3.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOverLoadOperator_OverLoadOperator_DoesMethodMergeProperlyZeroItemsInOneArray()
        {
            //Arrange
            CustomList<int> List = new CustomList<int>();
            CustomList<int> List2 = new CustomList<int>();
            string expected;
            string actual;

            //Act
            List.Add(5);
            List.Add(7);
            List.Add(9);
            List.Add(10);
            List.Add(11);
            List.Add(6);
            List.Add(8);
            CustomList<int> List3 = List + List2;
            expected = "5, 7, 9, 10, 11, 6, 8";
            actual = List3.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
