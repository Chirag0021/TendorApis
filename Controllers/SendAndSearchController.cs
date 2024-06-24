using KotaApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KotaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendAndSearchController : ControllerBase
    {
        private static SendAndSearchCommand _sendAndSearchCommand = new SendAndSearchCommand
        {
            IpAdrress = "192.168.1.119",
            VMSScreenType = 8792,
            ScreenWidth = 256,
            ScreenHeight = 160,
            Port = 80,
            Username = "guest",
            Password = "guest",
            DeviceName = "KE/VMS/RGB/1.0/192.168.1.119",
            Subnetmask = "255.255.255.0",
            Gateway = "192.168.1.1",
            DnsServer = "192.168.1.1",
            DeviceCode = "032258230612003E3",
            Ip = "MTkyLjE2OC4xLjExOQ==",
            VMSMessageTypeId = 0,
            BrightnessValue = 255,
            MessagesData = new List<string>()
        };
        // GET: api/<SendAndSearchController>
        [HttpGet]
        public ActionResult<SendAndSearchCommand> GetSendAndSearchCommand()
        {
            return Ok(_sendAndSearchCommand);
        }

        // GET api/<SendAndSearchController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SendAndSearchController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SendAndSearchCommand _sendAndSearchCommand)
        {
            if (_sendAndSearchCommand == null)
            {
                return BadRequest("Invalid request body");
            }
            return Ok("Command received successfully");
        }

        // PUT api/<SendAndSearchController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SendAndSearchController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
