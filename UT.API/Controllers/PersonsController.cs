using Microsoft.AspNetCore.Mvc;
using UT.API.Services;
using UT.Domain.Models;

namespace UT.API.Controllers
{
    [Route("api/persons")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
    public async Task<ActionResult<List<Person>>> GetPeople()
    {
        var people =await _personService.GetPeople();
        return Ok(people);
    }
    }
}
