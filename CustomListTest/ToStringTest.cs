using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void ToString_ConvertingDesiredValueToString_CheckingIfValueReturnedIsAString()
        {
            //arrange
            CustomList<int> shawnList = new CustomList<int>();
            string actual;
            string expected;
            //act
            shawnList.Add(5);
            shawnList.ToString(5);
            actual = shawnList.ToString(5);
            expected = "5";
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ConvertingDesiredValueToString_CheckingIfValueNotReturnedIsAString()
        {
            //arrange
            CustomList<int> shawnList = new CustomList<int>();
            int actual;
            int expected;
            //act
            shawnList.Add(5);
            shawnList.Add(5);
            shawnList.ToString(5);
            actual = shawnList[1];
            expected = 5;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ConvertingDesiredValueToString_CheckingIfSingleOfMultipleValueReturnedIsAString()
        {
            //arrange
            CustomList<int> shawnList = new CustomList<int>();
            int actual;
            int expected;
            //act
            shawnList.Add(5);
            shawnList.Add(5);
            shawnList.ToString(shawnList[0]);
            actual = shawnList.ToString(shawnList[1]);
            expected = 5;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ConvertingDesiredValueToString_CheckingIfStringValueIsReturnedIsAString()
        {
            //arrange
            CustomList<string> shawnList = new CustomList<string>();
            string actual;
            string expected;
            //act
            shawnList.Add("5");
            shawnList.ToString("5");
            actual = shawnList.ToString("5");
            expected = "5";
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TToString_ConvertingDesiredValueToString_CheckingIfDefaultValueReturnedIsAString()
        {
            //arrange
            CustomList<int> shawnList = new CustomList<int>();
            string actual;
            string expected;
            //act
            shawnList.Add(5);
            shawnList.ToString(shawnList[2]);
            actual = shawnList.ToString(shawnList[2]);
            expected = "0";
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
