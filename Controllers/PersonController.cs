using loans_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace loans_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        ///     GET endpoint that retrieves a person.
        /// </summary>
        /// <returns>
        ///     The sucessfully completed Task.
        /// </returns>
        [HttpGet(Name = "/GetAPerson")]
        public Task<Person> GetAPerson()
        {
            _logger.LogInformation("Instianciating the new Person object");

            Person person = new("Carlos", "Daniel", "Jimenez", "10/02/1998");

            return Task.FromResult(person);
        }

        /// <summary>
        ///     GET endpoint that retrieves a person given its unique identifier.
        /// </summary>
        /// <param name="id">
        ///     The unique identifier of the person to be retrieved.
        /// </param>
        /// <returns>
        ///     The sucessfully completed Task.
        /// </returns>
        [HttpGet("{Id}")]
        public Task<Person> GetAPersonBy(long id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     GET endpoint that retrieves a list of people given a list of unique identifiers.
        /// </summary>
        /// <param name="ids">
        ///     List of unique identifiers of people to be retrieved.
        /// </param>
        /// <returns></returns>
        [HttpGet("{Ids}")]
        public Task<Person> GetAListOfPeople(List<long> ids)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     POST endpoint that creates a person with all the possible arguments.
        /// </summary>
        /// <param name="first">
        ///      First name of the newly created user.
        /// </param>
        /// <param name="middle">
        ///      Middle name of the newly created user.
        /// </param>
        /// <param name="last">
        ///      Last name of the newly created user.
        /// </param>
        /// <param name="dbo">
        ///     Date when the person was borned.
        /// </param>
        /// <returns>
        ///     The sucessfully completed Task.
        /// </returns>
        [HttpPost("{first}/middle/{last}/{dbo}")]
        public Task<Person> CreateAPersonFull(string first, string middle, string last, string dbo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     PUT endpoint that updates a person's name by providing its unique identifier
        ///     and the new middle name.
        /// </summary>
        /// <param name="id">
        ///     Unique identifier of the person.
        /// </param>
        /// <param name="middle">
        ///     Middle name of the person that will be updated to.
        /// </param>
        /// <returns>
        ///     The sucessfully completed Task.
        /// </returns>
        [HttpPut("{Id}/{middle}")]
        public Task<Person> UpdateAPerson(long id, string middle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     DELETE endpoint that removes a given person.
        /// </summary>
        /// <param name="id">
        ///     Unique identidier of the person to be removed.
        /// </param>
        /// <returns>
        ///     The sucessfully completed Task.
        /// </returns>
        [HttpDelete("{Id}")]
        public Task<Person> DeleteAPerson(long id)
        {
            throw new NotImplementedException();
        }
    }
}
