using KotaApi.StaticData;
using Microsoft.AspNetCore.Mvc;
using static KotaApi.Models.SendText;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KotaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMultisegementController : ControllerBase
    {
        [HttpGet("MS")]
        public IActionResult GetVmsDataV4()
        {
            var data = StaticdataMultisegement.GetSendMultisegment();
            return Ok(data);
        }

        [HttpPost("MS")]
        public IActionResult PostVmsDataV4([FromBody] VmsData vmsData)
        {
            if (vmsData == null)
            {
                return BadRequest("VMS data is null.");
            }

            return Ok(new { message = "Data received successfully", data = vmsData });
        }
    }
}
