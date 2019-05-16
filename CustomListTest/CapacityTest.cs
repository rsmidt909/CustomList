using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CapacityTest
    {
        [TestMethod]
        public void Capacity_CountsTheCapacityOfTheArray_GivesCorrectNumberAfterAdding()
        {

            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;
            int expected;
            int actual;

            //Act
            shawnList.Add(value);
            actual = shawnList.Capacity;
            expected = 4;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Capacity_CountsTheCapacityOfTheArray_GivesCorrectNumberWithNothingInArray()
        {

            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int expected;
            int actual;


            //Act
            actual = shawnList.Capacity;
            expected = 4;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Capacity_CountsTheCapacityOfTheArray_GivesCorrectNumberAfterRemovingSomething()
        {

            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;
            int expected;
            int actual;

            //Act
            shawnList.Add(value);
            shawnList.Remove(shawnList[0]);

            actual = shawnList.Capacity;
            expected = 4;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Capacity_CountsTheCapacityOfTheArray_GivesCorrectNumberAfterAddingTwoThingsAndRemovingOne()
        {

            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;
            int value2 = 30;
            int expected;
            int actual;

            //Act
            shawnList.Add(value);
            shawnList.Add(value2);
            shawnList.Remove(shawnList[1]);
            actual = shawnList.Capacity;
            expected = 4;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Capacity_CountsTheCapacityOfTheArray_GivesCorrectNumberAfterAddingLargeAmount()
        {
            //arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;
            int value2 = 30;
            int value3 = 34;
            int value4 = 38;
            int value5 = 42;
            int expected;
            int actual;


            //act
            shawnList.Add(value);
            shawnList.Add(value2);
            shawnList.Add(value3);
            shawnList.Add(value4);
            shawnList.Add(value5);
            shawnList.Add(5);
            shawnList.Add(5);
            shawnList.Add(5);
            shawnList.Add(5);
            shawnList.Add(5);
            shawnList.Add(5);
            shawnList.Add(5);
            actual = shawnList.Capacity;
            expected = 16;


            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Capacity_CountsTheCapacityOfTheArray_GivesCorrectNumberAfterAddingString()
        {
            //arrange
            CustomList<string> shawnList = new CustomList<string>();
            string words;
            int actual;
            int expected;

            //act
            words = "Hello";
            shawnList.Add(words);
            actual = shawnList.Capacity;
            expected = 4;


            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
