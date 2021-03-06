﻿using System;
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
            int value = 15;
            int expected;
            int actual;


            //Act
            shawnList.Add(value);
            shawnList.Remove(value);
            actual = shawnList[0];
            expected = default;

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
            shawnList.Add(value);
            shawnList.Add(value2);
            shawnList.Remove(26);
            actual = shawnList[0];
            expected = 30;


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
            shawnList.Add(value);
            shawnList.Add(value2);
            shawnList.Remove(30);
            actual = shawnList[0];
            expected = 26;

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
            shawnList.Add(value);
            shawnList.Add(value2);
            shawnList.Add(value3);
            shawnList.Add(value4);
            shawnList.Add(value5);
            shawnList.Remove(shawnList[0]);
            actual = shawnList[0];
            expected = 30;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_CheckingIfDesiredVariableWasRemoved_CheckingIfAbleToRemoveString()
        {
            //arrange
            CustomList<string> shawnList = new CustomList<string>();
            string words;
            string actual;
            string expected;

            //act
            words = "Hello";
            shawnList.Add(words);
            shawnList.Remove("Hello");
            actual = shawnList[0];
            expected = null;


            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_RemovingItemFromArray_RemovingOneItemWithMultipleCopiesOfSameValue()
        {
            //arrange
            CustomList<int> shawnList = new CustomList<int>();
            
            int expected;
            int actual;

            //act
            
            shawnList.Add(5);
            shawnList.Add(5);
            shawnList.Add(5);
            shawnList.Remove(5);
            expected = default;
            actual = shawnList[2];


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovingItemFromArray_RemovingOneItemWithMultipleCopiesOfSameValueCheckingZeroIndex()
        {
            //arrange
            CustomList<int> shawnList = new CustomList<int>();
            
            int expected;
            int actual;

            //act
           
            shawnList.Add(5);
            shawnList.Add(5);
            shawnList.Add(5);
            shawnList.Remove(5);
            expected = 5;
            actual = shawnList[0];


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovingItemFromArray_RemovingOneItemWithMultipleCopiesOfSameValueCheckingFirstIndex()
        {
            //arrange
            CustomList<int> shawnList = new CustomList<int>();
            
            int expected;
            int actual;

            //act
            
            shawnList.Add(5);
            shawnList.Add(5);
            shawnList.Add(5);
            shawnList.Remove(5);
            expected = 5;
            actual = shawnList[1];


            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
