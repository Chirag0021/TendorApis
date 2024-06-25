using KotaApi.StaticData;
using Microsoft.AspNetCore.Mvc;
using static KotaApi.Models.SendText;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KotaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendImageController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSendImage()
        {
            var data = Staticdataimage.GetSendImage();
            return Ok(data);
        }

        [HttpPost]
        public IActionResult PostSendImage([FromBody] VmsData vmsData)
        {
            if (vmsData == null)
            {
                return BadRequest("VMS data is null.");
            }

            return Ok(new { message = "Data received successfully", data = vmsData });
        }
    }
}
