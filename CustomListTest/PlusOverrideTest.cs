using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class PlusOverrideTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CustomList<int> shawnList = new CustomList<int>();
            CustomList<int> shawnList2 = new CustomList<int>();
            int expected;
            int actual;

            //Act
            shawnList.Add(5);
            shawnList.Add(7);
            shawnList2.Add(6);
            shawnList2.Add(8);
            CustomList<int> List3 = shawnList + shawnList2;
            expected =
            actual = ;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
