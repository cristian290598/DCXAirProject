namespace Flights.DAL
{
    using Flights.Model;
    using System.Collections.Generic;

    public interface IDataAccess
    {
        public List<Journey> GetJourneys(string origin, string destination);
        public List<Flight> GetFligths(string journeyId);
        public List<Transport> GetTransport(string flightId);
    }
}
