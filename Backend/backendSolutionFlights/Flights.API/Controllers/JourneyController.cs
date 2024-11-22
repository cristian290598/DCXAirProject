namespace Flights.API.Controllers
{
    using Flights.BLL;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class JourneyController : ControllerBase
    {
        private readonly IGetJourneysService _service;

        public JourneyController(IGetJourneysService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("journeys")]
        public async Task<IActionResult> Get(string origin, string destination, string currency, bool roundtrip)
        {
            IActionResult response = null;

            try
            {
                response = Ok(await _service.Get(origin, destination, currency, roundtrip));
            }
            catch (Exception ex)
            {
                response = NotFound();
            }

            return response;
        }
    }
}
