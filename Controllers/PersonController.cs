using loans_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace loans_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPerson")]
        public Task<Person> Get()
        {
            _logger.LogInformation("Instianciating the new Person object");

            Person person = new("Carlos", "Daniel", "Jimenez", "10/02/1998");

            return Task.FromResult(person);
        }
    }
}
