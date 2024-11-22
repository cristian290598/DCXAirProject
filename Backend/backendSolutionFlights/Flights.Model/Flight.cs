namespace Flights.Model
{
    public class Flight
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
        public string TransportId { get; set; }
        public Transport Transport { get; set; }
    }
}
