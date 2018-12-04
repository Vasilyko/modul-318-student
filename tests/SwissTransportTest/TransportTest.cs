using Microsoft.VisualStudio.TestTools.UnitTesting;
using ÖVApp_KOV;
using System;

namespace SwissTransport
{
    [TestClass]
    public class TransportTest
    {
        private ITransport testee;

        [TestMethod]
        public void Locations()
        {
            testee = new Transport();
            var stations = testee.GetStations("Sursee,");

            Assert.AreEqual(10, stations.StationList.Count);
        }

        [TestMethod]
        public void StationBoard()
        {
            testee = new Transport();
            var stationBoard = testee.GetStationBoard("Sursee", "8502007");

            Assert.IsNotNull(stationBoard);
        }

        [TestMethod]
        public void Connections()
        {
            testee = new Transport();
            var connections = testee.GetConnections("Sursee", "Luzern");

            Assert.IsNotNull(connections);
        }

        [TestMethod]
        public void getConnectionWithTime()
        {
            testee = new Transport();
            var resultconnections = testee.GetConnectionsWithTime("Luzern", "Engelberg", new DateTime(2018,11,20,13,30,0));

            Assert.IsNotNull(resultconnections);
        }

        [TestMethod]
        public void GetBoard()
        {
            var testee = new Form2();

            Assert.IsNotNull(testee);
        }

        [TestMethod]
        public void GetSmth()
        {
            //Arrange
            var testee = new StationBoard();

            //Act
            testee.To = "Luzern";
            testee.Stop.Departure = new DateTime(2018, 11, 20, 12, 20, 00);

            var result = testee.ToString();

            //Assert
            Assert.Equals(result, " To: Luzern, Stop: 12:20:00");
        }
    }
}
