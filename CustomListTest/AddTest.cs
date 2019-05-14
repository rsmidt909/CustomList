using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void Add_AddingItemToArrayList_DoesIntGetAdded()
        {

            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;
            int expected;
            int actual;


            //Act
            shawnList.Add(value);
            actual = shawnList[0];
            expected = value;



            //Assert
            Assert.AreEqual(expected, actual);




        }
        [TestMethod]
        public void Add_AddingItemsToArayList_DoesIndexOneStayCorrect()
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
            actual = shawnList[0];
            expected = value;

            //Assert
            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void Add_AddingItemsToArayList_DoesIndexTwoStayCorrect()
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
            actual = shawnList[1];
            expected = value2;

            //Assert
            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void Add_AddingItemsToArayList_DoesAddtionalIndexsgetMade()
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
            actual = shawnList[4];
            expected = value5;

            //Assert
            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void Add_AddingStringItemsToArrayList_CheckingToSeeIfStringWasAdded()
        {
            //Arrange
            CustomList<string> shawnList = new CustomList<string>();
            string words = "Hello";
            string actual;
            string expected;


            //act
            shawnList.Add(words);
            expected = "Hello";
            actual = shawnList[0];


            //assert

            Assert.AreEqual(expected, actual);

        }







    }
}
