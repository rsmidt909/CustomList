using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CapacityTest
    {
        [TestMethod]
        public void Capacity_SetsTheAmountofUsableSpacesInsideArray_ChecksCapacityOfEmptyArray()
        {
            //arrange
            CustomList<int> shawnList = new CustomList<int>();
            int expected;
            int actual;



            //act
            shawnList.Capacity();
            actual = shawnList.Capacity();
            expected = 4;


            //assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Capacity_SetsTheAmountofUsableSpacesInsideArray_ChecksCapacityOf1ItemInArray()
        {
            //arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;
            int expected;
            int actual;


            //act

            shawnList.Add(value);
            shawnList.Capacity();
            actual = shawnList.Capacity();
            expected = 4;

            //assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Capacity_SetsTheAmountofUsableSpacesInsideArray_ChecksCapacityOf4ItemInArray()
        {
            //arrange
            CustomList<int> shawnList = new CustomList<int>();
            int value = 26;
            int value2 = 30;
            int value3 = 34;
            int value4 = 38;
            int expected;
            int actual;



            //act
            shawnList.Add(value);
            shawnList.Add(value2);
            shawnList.Add(value3);
            shawnList.Add(value4);
            shawnList.Capacity();
            actual = shawnList.Capacity();
            expected = 4;

            //assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Capacity_SetsTheAmountofUsableSpacesInsideArray_ChecksCapacityOf5ItemInArray()
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
            shawnList.Capacity();
            actual = shawnList.Capacity();
            expected = 8;

            //assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Capacity_SetsTheAmountofUsableSpacesInsideArray_ChecksCapacityOf4ItemInArrayAfterRemoving1()
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
            shawnList.Remove(value5);
            shawnList.Capacity();
            actual = shawnList.Capacity();
            expected = 8;

            //assert
            Assert.AreEqual(expected, actual);


        }
    }
}
