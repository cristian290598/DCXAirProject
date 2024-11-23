namespace Flights.BLL
{
    public interface IExchangeCurrency
    {
        public decimal Exchange(decimal value, string currency);
    }
}
