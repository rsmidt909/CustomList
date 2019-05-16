using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CountTest
    {
        [TestMethod]
        public void Count_CountsTheVariablesInArray_GivesCorrectNumberAfterAdding()
        {

            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;
            int expected;
            int actual;

            //Act
            shawnList.Add(value);
            shawnList.Count();
            actual = shawnList.Count();
            expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Count_CountsTheVariablesInArray_GivesCorrectNumberWhileEmpty()
        {

            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int expected;
            int actual;


            //Act
            shawnList.Count();
            actual = shawnList.Count();
            expected = 0;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Count_CountsTheVariablesInArray_GivesCorrectNumberAfterRemoving()
        {

            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;
            int expected;
            int actual;

            //Act
            shawnList.Add(value);
            shawnList.Remove(shawnList[0]);
            shawnList.Count();
            actual = shawnList.Count();
            expected = 0;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Count_CountsTheVariablesInArray_GivesCorrectNumberAfterAddingTwoAndRemovingOne()
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
            shawnList.Count();
            actual = shawnList.Count();
            expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Count_CountsTheVariablesInArray_CountReturnsCorrectInteger()
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
            shawnList.Count();
            actual = shawnList.Count();
            expected = 5;


            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Count_CheckigTheAmountOfVariablesInArray_CheckingCountInStringArray()
        {
            //arrange
            CustomList<string> shawnList = new CustomList<string>();
            string words;
            int actual;
            int expected;

            //act
            words = "Hello";
            shawnList.Add(words);
            shawnList.Count();
            actual = shawnList.Count();
            expected = 1;


            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
