using MagazineAPI.Application.Dto;
using MagazineAPI.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagazineAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagazineController : ControllerBase
    {
        private readonly IMagazineService _magazineService;

        public MagazineController(IMagazineService magazineService)
        {
            _magazineService = magazineService;
        }

        [HttpPost("addMagazine")]
        public async Task<IActionResult> AddMagazine([FromBody] MagazineRequestDto magazine)
        {
            try
            {
                var addedMag = await _magazineService.AddMagazine(magazine);
                return Ok(addedMag);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while adding the magazine.");
            }
        }
    }
}
