using Microsoft.AspNetCore.Mvc;
using MortgageRatesApi.Services;
using System.Threading.Tasks;

// Handles HTTP requests for rate-related endpoints
namespace MortgageRatesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RatesController : ControllerBase
    {
        private readonly IRateService _rateService;

        // Constructor with dependency injection
        public RatesController(IRateService rateService)
        {
            _rateService = rateService;
        }

        // GET: api/rates?loanType=owner-occupied&term=30
        [HttpGet]
        public async Task<IActionResult> GetRates([FromQuery] string loanType, [FromQuery] int term)
        {
            // Validate query parameters
            if (string.IsNullOrEmpty(loanType) || term <= 0)
            {
                return BadRequest("Invalid loanType or term.");
            }

            // Retrieve rates from service
            var rate = await _rateService.GetRateAsync(loanType, term);
            if (rate == null)
            {
                return NotFound("No rates found for the specified criteria.");
            }

            return Ok(rate);
        }
    }
}