using LabManagementSystem.Data;
using LabManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LabManagementSystem.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class LabReportController : Controller
    {
        private readonly LabManagementSystemContext _dbContext;

        public LabReportController(LabManagementSystemContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LabReport>>> GetLabReportDetails()
        {
            if (_dbContext.labReports == null)
            {
                return NotFound();
            }
            return await _dbContext.labReports.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LabReport>> GetLabReportDetailsById(int id)
        {
            if (_dbContext.labReports == null)
            {
                return NotFound();
            }
            var labReport = await _dbContext.labReports.FindAsync(id);
            if (labReport == null)
            {
                return NotFound();
            }
            else
            {
                return labReport;
            }
        }

        [HttpPost]
        public async Task<ActionResult<LabReport>> PostLabReportDetails(LabReport labReport)
        {
            _dbContext.labReports.Add(labReport);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLabReportDetails), new { id = labReport.ReportID }, labReport);

        }

        [HttpPut]
        public async Task<IActionResult> PutLabReportDetails(int id, LabReport labReport)
        {
            if (labReport == null)
            {
                return BadRequest();
            }
            _dbContext.Entry(labReport).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                if (!LabReportAvailable(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }
        private bool LabReportAvailable(int id)
        {
            return (_dbContext.labReports?.Any(p => p.ReportID == id)).GetValueOrDefault();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteLabReportDetails(int id)
        {
            if (_dbContext.labReports == null)
            {
                return BadRequest();
            }
            var labReport = _dbContext.labReports.FindAsync(id);

            if (labReport == null)
            {
                return NotFound();
            }

            _dbContext.labReports.Remove(await labReport);

            await _dbContext.SaveChangesAsync();

            return Ok();
        }

    }
}
