using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ADT;

namespace UnitTest
{
    [TestClass]
    public class CityMapTest
    {
        [TestMethod]
        public void Map_AddCityDistance_SingleWay()
        {
            ADT.Map cm = new ADT.Map();

            cm.AddCity("Aalborg");
            cm.AddCity("Silkeborg");
            cm.AddDistance("Aalborg", "Silkeborg", 101, false);
            Assert.AreEqual(101, cm.GetDistance("Aalborg", "Silkeborg"));
            Assert.AreNotEqual(0, cm.GetDistance("Aalborg", "Silkeborg"));

            bool testResult;
            try
            {
                // method are expected to throw an exception
                Assert.AreEqual(101, cm.GetDistance("Silkeborg", "Aalborg"));

                // Then this line of code should not be executed
                testResult = false;
            }
            catch (Exception)
            {
                // If this line executes, then the method under test did threw an exception and the test is a success
                testResult = true;
            }
            Assert.IsTrue(testResult);
        }
        [TestMethod]
        public void Map_AddCityDistance_BothVay()
        {
            ADT.Map cm = new ADT.Map();

            cm.AddCity("Aalborg");
            cm.AddCity("Silkeborg");
            cm.AddDistance("Aalborg", "Silkeborg", 101, true);
            Assert.AreEqual(101, cm.GetDistance("Aalborg", "Silkeborg"));
            Assert.AreNotEqual(0, cm.GetDistance("Aalborg", "Silkeborg"));
            Assert.AreEqual(101, cm.GetDistance("Silkeborg", "Aalborg"));
            Assert.AreNotEqual(0, cm.GetDistance("Silkeborg", "Aalborg"));
        }
        [TestMethod]
        public void Map_AddDistance_SingleWay()
        {
            ADT.Map cm = new ADT.Map();

            bool testResult;
            try
            {
                // method are expected to throw an exception
                cm.AddDistance("Aalborg", "Silkeborg", 101, false);

                // Then this line of code should not be executed
                testResult = false;
            }
            catch (Exception)
            {
                // If this line executes, then the method under test did threw an exception and the test is a success
                testResult = true;
            }
            Assert.IsTrue(testResult);
        }
    }
