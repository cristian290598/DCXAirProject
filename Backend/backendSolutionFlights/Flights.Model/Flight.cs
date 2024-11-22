namespace Flights.Model
{
    public class Flight
    {
        public string Id { get; set; }
        public string Origin { get; set; }
        public string Price { get; set; }
        public Transport Transport { get; set; }
    }
}
