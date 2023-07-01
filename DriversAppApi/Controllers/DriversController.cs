using DriversAppApi.Models;
using DriversAppApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DriversAppApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DriversController : ControllerBase
    {
        private readonly DriverService _driverService;
        public DriversController(DriverService driverService)
        {
            _driverService = driverService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var drivers = await _driverService.GetDriversAsync();
                return Ok(drivers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id:length(24)}")]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                var driver = await _driverService.GetDriverAsync(id);

                if (driver is null)
                {
                    return NotFound("Driver not found");
                }

                return Ok(driver);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Driver driver)
        {
            try
            {
                await _driverService.CreateDriverAsync(driver);
                return CreatedAtAction(nameof(Get), new { id = driver.Id }, driver);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Driver driver)
        {
            try
            {
                var existingDriver = await _driverService.GetDriverAsync(id);

                if (existingDriver is null)
                {
                    return BadRequest($"Driver {id} does not exist");
                }

                driver.Id = id;
                await _driverService.UpdateDriverAsync(driver);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                var existingDriver = await _driverService.GetDriverAsync(id);

                if (existingDriver is null)
                {
                    return BadRequest($"Driver {id} does not exist");
                }

                await _driverService.DeleteDriverAsync(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}