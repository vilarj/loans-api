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
        public IEnumerable<Person> Get()
        {
            throw new NotImplementedException();
        }
    }
}
