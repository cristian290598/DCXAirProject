namespace Flights.BLL.Impl
{
    using Flights.DAL;
    using Flights.DTO;
    using Flights.Model;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class GetJourneyService : IGetJourneysService
    {
        private readonly IDataAccess _dataAccess;

        public GetJourneyService(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<List<JourneyDto>> Get(string origin, string destination, string currency, bool roundtrip)
        {
            var journeys = _dataAccess.GetJourneys(origin, destination);

            var journeyDtos = journeys.Select(journey => new JourneyDto
            {
                Origin = journey.Origin,
                Destination = journey.Destination,
                Price = ConvertCurrency(journey.Price, currency),
                Flights = _dataAccess.GetFligths(journey.Id.ToString()).Select(flight => new FlightDto
                {
                    Origin = flight.Origin,
                    Destination = flight.Destination,
                    Price = ConvertCurrency(flight.Price, currency),
                    Transport = MapTransportToDto(_dataAccess.GetTransport(flight.Id.ToString()))
                }).ToList()
            }).ToList();

            if (roundtrip)
            {
                var returnJourneys = _dataAccess.GetJourneys(destination, origin);
                var returnJourneyDtos = returnJourneys.Select(journey => new JourneyDto
                {
                    Origin = journey.Origin,
                    Destination = journey.Destination,
                    Price = ConvertCurrency(journey.Price, currency),
                    Flights = _dataAccess.GetFligths(journey.Id.ToString()).Select(flight => new FlightDto
                    {
                        Origin = flight.Origin,
                        Destination = flight.Destination,
                        Price = ConvertCurrency(flight.Price, currency),
                        Transport = MapTransportToDto(_dataAccess.GetTransport(flight.Id.ToString()))
                    }).ToList()
                }).ToList();

                journeyDtos.AddRange(returnJourneyDtos);
            }

            return await Task.FromResult(journeyDtos);
        }

        private decimal ConvertCurrency(decimal price, string currency)
        {
            return price;
        }

        private TransportDto MapTransportToDto(List<Transport> transports)
        {
            var transport = transports.FirstOrDefault();
            if (transport == null)
                return null;

            return new TransportDto
            {
                FlightCarrier = transport.FlightCarrier,
                FlightNumber = transport.FlightNumber
            };
        }
    }
}
