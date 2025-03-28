using ItFoto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItFoto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly SendEmailDb _sendEmailDb;
        public HomeController(SendEmailDb sendEmailDb)
        {
            _sendEmailDb = sendEmailDb;
        }

        [HttpPost("Preia")]
        public async Task<IActionResult> preluareDate(emailSent data)
        {
            if (data == null)
            {
                return BadRequest("Invalid message data.");
            }

            try 
            {
                await _sendEmailDb.AddEmail(data);
                return Ok(new { Message = "Contact message saved successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = "Error saving message", Error = ex.Message });
            }
        }

                [HttpGet("Ofera")]
        public async Task<IActionResult> GetMessages()
        {
            var messages = await _sendEmailDb.GetEmails();
            return Ok(messages);
        }
    }
}
