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


            //Act
            shawnList.Add(value);
            shawnList.Count();
            //Assert
            Assert.AreEqual(1, shawnList.Count());

        }

        [TestMethod]
        public void Count_CountsTheVariablesInArray_GivesCorrectNumberWhileEmpty()
        {

            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            


            //Act
            
            shawnList.Count();
            //Assert
            Assert.AreEqual(0, shawnList.Count());

        }

        [TestMethod]
        public void Count_CountsTheVariablesInArray_GivesCorrectNumberAfterRemoving()
        {

            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;


            //Act
            shawnList.Add(value);
            shawnList.Remove(shawnList[0]);
            shawnList.Count();
            //Assert
            Assert.AreEqual(0, shawnList.Count());

        }

        [TestMethod]
        public void Count_CountsTheVariablesInArray_GivesCorrectNumberAfterAddingTwoAndRemovingOne()
        {

            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;
            int value2 = 30;


            //Act
            shawnList.Add(value);
            shawnList.Add(value2);
            shawnList.Remove(shawnList[1]);
            shawnList.Count();
            //Assert
            Assert.AreEqual(1, shawnList.Count());

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



            //act
            shawnList.Add(value);
            shawnList.Add(value2);
            shawnList.Add(value3);
            shawnList.Add(value4);
            shawnList.Add(value5);
            shawnList.Count();


            //Assert
            Assert.AreEqual(5, shawnList.Count());
        }
    }
}
