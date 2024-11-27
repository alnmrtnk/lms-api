using lms_api.Application.Reports.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace lms_api.Controllers
{
    [ApiController]
    [Route("reports")]
    public class ReportController(
        IReportRepository _reportRepository) : Controller
    {
        [HttpGet("borrow-frequency")]
        public async Task<IActionResult> GetBorrowFrequency([FromQuery] string startDate, [FromQuery] string endDate)
        {
            var data = await _reportRepository.GetBorrowFrequency(startDate, endDate);
            return Ok(data);
        }

        [HttpGet("active-users")]
        public async Task<IActionResult> GetActiveUsers([FromQuery] string startDate, [FromQuery] string endDate)
        {
            var data = await _reportRepository.GetActiveUsers(startDate, endDate);
            return Ok(data);
        }

        [HttpGet("librarian-activity")]
        public async Task<IActionResult> GetLibrarianActivity([FromQuery] string startDate, [FromQuery] string endDate)
        {
            var data = await _reportRepository.GetLibrarianActivity(startDate, endDate);
            return Ok(data);
        }
    }
}
