using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Npgsql;
using Npgsql.ConfigureConnection;
using BUMA.Utilities.Connection;
using System.Threading.Tasks;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BUMA.Utilities.Test
{
    [TestClass]
    public class PostgressConectionTest
    {
        [TestMethod]
        public void ConnectionPostgressAdminTest()
        {
            var action = new Connection.PostgressConection();
            NpgsqlConnection ConnectPostgressAdmin = new NpgsqlConnection();
            ConnectPostgressAdmin = action.ConnectionPostgressAdmin();
           // ConnectPostgressAdmin.State;
            //testConection.Close();

            Assert.AreEqual("Open",string.Empty);

        }
    }
}
