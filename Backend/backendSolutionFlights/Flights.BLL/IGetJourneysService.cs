namespace Flights.BLL
{
    using Flights.DTO;

    public interface IGetJourneysService
    {
        Task<List<JourneyDto>> Get(string origin, string destination, string currency, bool roundtrip);
    }
}
