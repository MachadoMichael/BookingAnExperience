using Microsoft.AspNetCore.Mvc;

namespace BookingAnExperience.Domains.Appointments
{
    [ApiController]
    [Route("appointments")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _appointmentService.GetAllAsync();
                return Ok(result ?? []);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var result = await _appointmentService.GetByIdAsync(id);
                return Ok(result ?? null);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Appointment appointment)
        {
            try
            {
                await _appointmentService.AddAsync(appointment);
                return Ok("successfully created.");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Appointment appointment)
        {
            try
            {
                await _appointmentService.UpdateAsync(appointment);
                return Ok("successfully updated.");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _appointmentService.DeleteAsync(id);
                return Ok("successfully deleted.");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
