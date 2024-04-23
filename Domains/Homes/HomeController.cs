using Microsoft.AspNetCore.Mvc;

namespace BookingAnExperience.Domains.Homes
{
    [ApiController]
    [Route("homes")]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _homeService.GetAllAsync();
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
                var result = await _homeService.GetByIdAsync(id);
                return Ok(result ?? null);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Home home)
        {
            try
            {
                await _homeService.AddAsync(home);
                return Ok("successfully created.");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Home home)
        {
            try
            {
                await _homeService.UpdateAsync(home);
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
                await _homeService.DeleteAsync(id);
                return Ok("successfully deleted.");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
