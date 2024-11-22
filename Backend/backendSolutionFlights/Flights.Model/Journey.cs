﻿namespace Flights.Model
{
    public class Journey
    {
        public string Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
        public List<Flight> Flights { get; set; }
    }
}