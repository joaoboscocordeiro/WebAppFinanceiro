using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppFinanceiro.Services;

namespace WebAppFinanceiro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IFinanceService _service;

        public DashboardController(IFinanceService service)
        {
            _service = service;
        }

        [HttpGet("summary")]
        public async Task<IActionResult> Summary([FromQuery] int month, [FromQuery] int year)
        {
            var result = await _service.GetDashboardAsync(month, year);
            return Ok(result);
        }

        [HttpGet("by-category")]
        public async Task<IActionResult> ByCategory([FromQuery] int? month, [FromQuery] int? year)
        {
            var result = await _service.GetTotalsByCategoryAsync(month, year);
            return Ok(result);
        }
    }
}
