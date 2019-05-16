using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void ToStringMimic_ConvertingDesiredValueToString_CheckingIfValueReturnedIsAString()
        {
            //arrange
            CustomList<int> shawnList = new CustomList<int>();
            string actual;
            string expected;
            //act
            shawnList.Add(5);
            shawnList.Add(5);
            shawnList.Add(5);
            shawnList.ToStringMimic();
            actual = shawnList.ToStringMimic();
            expected = "5, 5, 5";
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringMimic_ConvertingDesiredValueToString_CheckingIfStringValueReturnedIsAString()
        {
            //arrange
            CustomList<string> shawnList = new CustomList<string>();
            string actual;
            string expected;
            //act
            shawnList.Add("5");
            shawnList.Add("5");
            shawnList.ToStringMimic();
            actual = shawnList.ToStringMimic();
            expected = "5, 5";
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringMimic_ConvertingDesiredValueToString_CheckingIfLargeValueListReturnedIsAString()
        {
            //arrange
            CustomList<int> shawnList = new CustomList<int>();
            string actual;
            string expected;
            //act
            shawnList.Add(5);
            shawnList.Add(6);
            shawnList.Add(7);
            shawnList.Add(8);
            shawnList.Add(9);
            shawnList.Add(10);
            shawnList.ToStringMimic();
            actual = shawnList.ToStringMimic();
            expected = "5, 6, 7, 8, 9, 10";
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringMimic_ConvertingDesiredValueToString_CheckingIfStringValueIsReturnedIsAString()
        {
            //arrange
            CustomList<string> shawnList = new CustomList<string>();
            string actual;
            string expected;
            //act
            shawnList.Add("5");
            shawnList.ToStringMimic();
            actual = shawnList.ToStringMimic();
            expected = "5";
            //assert
            Assert.AreEqual(expected, actual);
        }

        /*[TestMethod]
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
        }*/
    }
}
