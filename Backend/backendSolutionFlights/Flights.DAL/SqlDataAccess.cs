namespace Flights.DAL
{
    using System.Configuration;
    using Flights.Model;
    using System.Collections.Generic;
    using System;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Data.SQLite;
    using Dapper;

    public class SqlDataAccess : IDataAccess
    {
        private static string LoadConnectionString(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public List<Journey> GetJourneys(string origin, string destination)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@origin", origin);
                p.Add("@destination", destination);
                var output = cnn.Query<Journey>("select * from journey where origin = @origin and destination = @destination", p);
                return output.ToList();
            }
        }

        public List<Flight> GetFligths(string journeyId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@JId", journeyId);
                var output = cnn.Query<Flight>("select f.* from Flight f INNER JOIN JourneyFlights jf ON f.id = jf.flightid where jf.journeyid = @JId", p);
                return output.ToList();
            }
        }

        public List<Transport> GetTransport(string flightId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@TId", flightId);
                var output = cnn.Query<Transport>("select t.* from Transport t INNER JOIN flight f ON f.transportid = t.id where t.id = @TId", p);
                return output.ToList();
            }
        }
    }
}
