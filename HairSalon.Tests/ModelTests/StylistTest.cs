using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using HairSalon;

namespace HairSalon.Tests
{
    [TestClass]
    public class StylistTest : IDisposable
    {
        public void Dispose()
        {
            Stylist.DeleteAll();
            Client.DeleteAll();
        }

        public StylistTest()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=azamat_bekmuratov_test;";
        }

        [TestMethod]
        public void GetAll_DatabaseEmptyAtFirst_0()
        {
            //Arrange, Act
            int result = Stylist.GetAll().Count;

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Equals_OverrideTrueForSameName_Stylist()
        {
          //Arrange, Act
          Stylist firstStylist = new Stylist("John", 1);
          Stylist secondStylist = new Stylist("John", 1);

          //Assert
          Assert.AreEqual(firstStylist, secondStylist);
        }

        [TestMethod]
        public void Save_SavesToDatabase_StylistList()
        {
            Stylist testStylist = new Stylist("Michael");

            testStylist.Save();
            List<Stylist> testStylists = Stylist.GetAll();
            List<Stylist> result = new List<Stylist>(){testStylist};

            CollectionAssert.AreEqual(result, testStylists);
        }

        [TestMethod]
        public void Find_FindStylistInDatabase_Stylist()
        {
            Stylist testStylist = new Stylist("David");
            testStylist.Save();

            Stylist foundStylist = Stylist.Find(testStylist.GetId());

            Assert.AreEqual(testStylist, foundStylist);
        }

    }
}
