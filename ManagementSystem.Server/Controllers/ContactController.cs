using ManagementSystem.Server.DTOs;
using ManagementSystem.Server.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] CreateContactDto dto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();
                return BadRequest(new { Errors = errors });
            }

            try
            {
                _contactService.AddContact(dto);
                return Ok(new { Message = "Contact added successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Errors = new List<string> { ex.Message } });
            }
        }


        [HttpGet("getContact")]
        public IActionResult GetContact()
        {
            var contacts = _contactService.GetAllContacts();
            return Ok(contacts);
        }

        //[HttpDelete]
        //public IActionResult DeleteContact()
        //{

        //}


    }
}
