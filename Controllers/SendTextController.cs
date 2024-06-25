using KotaApi.Models;
using KotaApi.StaticData;
using Microsoft.AspNetCore.Mvc;
using static KotaApi.Models.SendText;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KotaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendTextController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetVMSData()
        {
            var data = StaticdataText.GetSendText();
            return Ok(data);
        }
        [HttpPost]
        public IActionResult PostVmsData([FromBody] VmsData vmsData)
        {
            if (vmsData == null)
            {
                return BadRequest("VMS data is null.");
            }

            return Ok(new { message = "Data received successfully", data = vmsData });
        }
    }
}
