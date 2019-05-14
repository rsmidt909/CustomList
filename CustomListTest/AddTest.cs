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



            //Act
            shawnList.Add(value);




            //Assert
            Assert.AreEqual(value, shawnList[0]);




        }
        [TestMethod]
        public void Add_AddingItemsToArayList_DoesIndexOneStayCorrect()
        {
            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;
            int value2 = 30;



            //Act
            shawnList.Add(value);
            shawnList.Add(value2);


            //Assert
            Assert.AreEqual(value, shawnList[0]);



        }
        [TestMethod]
        public void Add_AddingItemsToArayList_DoesIndexTwoStayCorrect()
        {
            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;
            int value2 = 30;



            //Act
            shawnList.Add(value);
            shawnList.Add(value2);


            //Assert
            Assert.AreEqual(value2, shawnList[1]);



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



            //Act
            shawnList.Add(value);
            shawnList.Add(value2);
            shawnList.Add(value3);
            shawnList.Add(value4);
            shawnList.Add(value5);


            //Assert
            Assert.AreEqual(value5, shawnList[4]);



        }
        [TestMethod]
        public void Add_AddingItemsToArrayList_







    }
}
