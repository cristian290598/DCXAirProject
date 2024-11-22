using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.DTO
{
    public class FlightDto
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Price { get; set; }
        public TransportDto Transport { get; set; }
    }
}