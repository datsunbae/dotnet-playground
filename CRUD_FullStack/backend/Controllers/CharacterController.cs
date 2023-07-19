using Backend.Models.Character;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCharacter()
        {
            try
            {
                var response = await _characterService.GetAllCharacters();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An internal server error occurred: " + ex.Message);
            }
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetCharacter([FromRoute] Guid id)
        {
            try
            {
                var response = await _characterService.GetCharacter(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An internal server error occurred: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter([FromBody] CharacterRequest request)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest();
                var response = await _characterService.AddCharacter(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An internal server error occurred: " + ex.Message);
            }
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateCharacter([FromRoute] Guid id, [FromBody] CharacterRequest request)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest();

                var response = await _characterService.UpdateCharacter(id, request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An internal server error occurred: " + ex.Message);
            }
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteCharacter([FromRoute] Guid id)
        {
            try
            {
                var response = await _characterService.DeleteCharacter(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An internal server error occurred: " + ex.Message);
            }
        }
    }
}