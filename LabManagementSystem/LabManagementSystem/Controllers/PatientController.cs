using LabManagementSystem.Data;
using LabManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LabManagementSystem.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class PatientController : Controller
    {

        private readonly LabManagementSystemContext _dbContext;

        public PatientController(LabManagementSystemContext dbContext)
        {
            _dbContext = dbContext;
        }

        //// Dummy data for demonstration purposes
        //private readonly List<Patient> _patients = new List<Patient>
        //    {
        //      new Patient { PatientID = 1, PatientName = "John Doe", PatientDOB = new DateTime(1980, 1, 1), PatientGender = "Male" },            // Add more patients here
        //      new Patient { PatientID = 1, PatientName = "John Doe", PatientDOB = new DateTime(1980, 1, 1), PatientGender = "Male" },            // Add more patients here
        //};

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatientDetails()
        {
            if (_dbContext.patients == null)
            {
                return NotFound();
            }
            return await _dbContext.patients.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatientDetailsById(int id)
        {
            if (_dbContext.patients == null)
            {
                return NotFound();
            }
            var patient = await _dbContext.patients.FindAsync(id);
            if(patient == null)
            {
                return NotFound();
            }
            else
            {
                return patient;
            }
        }

        [HttpPost]
        public async Task<ActionResult<Patient>> PostPatientDetails(Patient patient)
        {
            _dbContext.patients.Add(patient);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPatientDetails), new { id = patient.PatientID }, patient);

        }

        [HttpPut]
        public async Task<IActionResult> PutPatientDetails(int id, Patient patient)
        {
            if (patient == null)
            {
                return BadRequest();
            }
            _dbContext.Entry(patient).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                if (!PatientAvailable(id))
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
        private bool PatientAvailable(int id)
        {
            return (_dbContext.patients?.Any(p => p.PatientID == id)).GetValueOrDefault();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePatientDetails(int id)
        {
            if (_dbContext.patients == null)
            {
                return BadRequest();
            }
            var patient = _dbContext.patients.FindAsync(id);
            
            if(patient== null)
            {
                return NotFound();
            }
            
            _dbContext.patients.Remove(await patient);

            await _dbContext.SaveChangesAsync();

            return Ok();
        }


        //[HttpGet]
        //public ActionResult<IEnumerable<Patient>> Get()
        //{
        //    return Ok(_patients); // Return the list of patients as JSON
        //}

        //// This method is not implemented yet, you can add logic to retrieve a specific patient by ID or other criteria
        //[HttpGet("{id}")]
        //public ActionResult<Patient> GetById(int id)
        //{
        //    // Logic to retrieve patient by ID
        //    var patient = _patients.Find(p => p.PatientID == id);
        //    if (patient == null)
        //    {
        //        return NotFound(); // Return 404 if patient is not found
        //    }
        //    return Ok(patient); // Return the patient as JSON
        //}

        //[HttpPost]
        //public ActionResult<Patient> CreatePatient([FromBody] Patient patient)
        //{
        //    if (patient == null)
        //    {
        //        return BadRequest("Invalid data"); // If request body is empty or invalid
        //    }

        //    // Assign a new ID to the patient (you may handle this differently in production)
        //    patient.PatientID = _patients.Count + 1;

        //    _patients.Add(patient); // Add the new patient to the list

        //    // Return the newly created patient along with HTTP status code 201 (Created)
        //    return CreatedAtAction(nameof(GetById), new { id = patient.PatientID }, patient);
        //}

    }
}
