using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void Remove_RemovingItemFromArrayList_DoesItemGetRemoved()
        {
            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int expected;
            int actual;


            //Act
            shawnList.Remove(shawnList[0]);
            actual = shawnList[0];
            expected = 0;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_RemovingItemsFromArrayList_DoesValueOfIndex1EqualIndex0AfterIndex0IsRemoved()
        {
            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;
            int value2 = 30;
            int expected;
            int actual;

            //Act
            shawnList.Remove(shawnList[0]);
            actual = shawnList[0];
            expected = value2;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovingItemsFromArrayList_DoesValueOfIndex0StayAfterIndex1IsRemoved()
        {
            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;
            int value2 = 30;
            int expected;
            int actual;


            //Act
            shawnList.Remove(shawnList[1]);
            actual = shawnList[0];
            expected = value;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovingItemsFromArrayList_DoesCapacityStayTheSameAfterMaxIndexIsRemoved()
        {
            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;
            int value2 = 30;
            int value3 = 34;
            int value4 = 38;
            int value5 = 42;
            int expected;
            int actual;

            //Act
            shawnList.Remove(shawnList[0]);
            actual = shawnList[0];
            expected = value2;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
