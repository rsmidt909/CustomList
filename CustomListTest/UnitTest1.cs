using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Zip_ZipMethodForSorting_DoesZipMethodZip()
        {

            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            CustomList<int> shawnList2 = new CustomList<int>();
            string expected;
            string actual;

            //Act
            shawnList.Add(5);
            shawnList2.Add(6);
            shawnList.Add(7);
            shawnList2.Add(8);
            shawnList.Add(9);
            shawnList.Add(10);
            shawnList.Add(11);
            CustomList<int> shawnList3 = shawnList + shawnList2;
            expected = "5, 6, 7, 8, 9, 10, 11";
            actual = shawnList3.ToString();
            //Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipMethodForSorting_DoesZipMethodZipWithLargerNumbers()
        {

            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            CustomList<int> shawnList2 = new CustomList<int>();
            string expected;
            string actual;

            //Act
            shawnList.Add(5);
            shawnList2.Add(6);
            shawnList.Add(7);
            shawnList2.Add(8);
            shawnList.Add(9);
            shawnList.Add(10);
            shawnList.Add(11);
            shawnList2.Add(15);
            shawnList2.Add(20);
            CustomList<int> shawnList3 = shawnList + shawnList2;
            expected = "5, 6, 7, 8, 9, 15, 10, 20, 11";
            actual = shawnList3.ToString();
            //Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
