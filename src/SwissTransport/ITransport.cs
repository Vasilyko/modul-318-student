using System;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id);
        Connections GetConnections(string fromStation, string toStattion);
        //Dank dieser API erweiterung kann ich als parameter ein DateTime mitgeben
        Connections GetConnectionsWithTime(string fromStation, string toStattion, DateTime time);
    }
}