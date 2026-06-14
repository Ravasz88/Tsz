using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TSzKapu.Authentication;
using TSzKapu.Data;
using TSzKapu.Interfaces;

namespace TSzKapu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EspDeviceAut]
    public class TSzController : ControllerBase
    {
        private IUserRepository userRepository;
        private ISoilDataRepository soilDataRepository;
        public TSzController(IUserRepository userRepository, ISoilDataRepository soilData)
        {
            this.userRepository = userRepository;
            soilDataRepository = soilData;
        }

      

        [HttpPost("registration")]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
           await userRepository.CreateUser(user);
            return Ok();
        }
        [AllowAnonymous]
        [HttpGet("status")]
        public async Task<IActionResult> Get()
        {
            return Ok("I'm alive");  
        }

        [HttpPost("measure")]
        public async Task<IActionResult> RegData([FromBody] SoilData soilData)
        {
            await soilDataRepository.NewMeasurement(soilData);
            return Ok();
        }
    }
}
