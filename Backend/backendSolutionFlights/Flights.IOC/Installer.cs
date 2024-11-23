namespace Flights.IOC
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Configuration;
    using Flights.DAL;
    using Flights.BLL;
    using Flights.BLL.Impl;

    public static class Installer
    {
        public static void Install(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IDataAccess, SqlDataAccess>();
            services.AddScoped<IGetJourneysService, GetJourneyService>();
            services.AddScoped<IExchangeCurrency, ExchangeCurrency>();
        }
    }
}
