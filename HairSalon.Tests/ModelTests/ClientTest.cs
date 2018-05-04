using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using HairSalon;

namespace HairSalon.Tests
{
    [TestClass]
    public class ClientTest : IDisposable
    {
        public void Dispose()
        {
            Stylist.DeleteAll();
            Client.DeleteAll();
        }

        public ClientTest()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=azamat_bekmuratov_test;";
        }

        [TestMethod]
        public void GetAll_DatabaseEmptyAtFirst_0()
        {
            //Arrange, Act
            int result = Client.GetAll().Count;

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Equals_OverrideTrueForSameName_Client()
        {
          //Arrange, Act
          Client firstClient = new Client("John", 1);
          Client secondClient = new Client("John", 1);

          //Assert
          Assert.AreEqual(firstClient, secondClient);
        }

        [TestMethod]
        public void Save_SavesToDatabase_ClientList()
        {
            Client testClient = new Client("Michael", 2);

            testClient.Save();
            List<Client> testClients = Client.GetAll();
            List<Client> result = new List<Client>(){testClient};

            CollectionAssert.AreEqual(result, testClients);
        }

    }
}
