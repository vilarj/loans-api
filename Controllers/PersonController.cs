using loans_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace loans_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class PersonController : ControllerBase
    {
        public PersonController()
        {

        }

        /// <summary>
        ///     GET endpoint that retrieves a person.
        /// </summary>
        /// <returns>
        ///     The sucessfully completed Task.
        /// </returns>
        [HttpGet]
        [ProducesResponseType(200)]
        public Task<Person> GetAPerson()
        {
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
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public Task<Person> GetAPersonBy([BindRequired] long id)
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
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public Task<Person> GetAListOfPeople([BindRequired] List<long> ids)
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
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public Task<Person> CreateAPersonFull([BindRequired] string first, string middle, [BindRequired] string last, [BindRequired] string dbo)
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
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public Task<Person> UpdateAPerson([BindRequired] long id, [BindRequired] string middle)
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
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public Task<Person> DeleteAPerson([BindRequired] long id)
        {
            throw new NotImplementedException();
        }
    }
}
