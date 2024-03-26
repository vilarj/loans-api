namespace loans_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        protected IPerson _personService;

        public PersonController(IPerson personService)
        {
            _personService = personService;
        }

        /// <summary>
        ///     GET endpoint that retrieves a person.
        /// </summary>
        /// <returns>
        ///     The sucessfully completed Task.
        /// </returns>
        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ServiceResponse<Person>> GetAPersonAsync()
        {
            return await _personService.GetAPerson();
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
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ServiceResponse<Person>> GetAPersonByIdAsync(long id)
        {
            return await _personService.GetAPersonById(id);
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
        public async Task<ServiceResponse<List<Person>>> CreateAPersonFullAsync(Person newPerson)
        {
            return await _personService.CreateAPersonFull(newPerson);
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
        public async Task<ServiceResponse<Person>> UpdateAPersonAsync(long id, string middle)
        {
            return await _personService.UpdateAPerson(id, middle);
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
        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ServiceResponse<Person>> DeleteAPersonAsync(long id)
        {
            return await _personService.DeleteAPerson(id);
        }
    }
}
