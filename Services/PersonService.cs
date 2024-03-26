namespace loans_api.Services
{
	public class PersonService : IPerson
    {
        private readonly List<Person> people = new()
        {
            new Person(0, "Kobe", "Harden", "01/01/1999"),
            new Person(1, "Dave", "Lebron", "Jimenez", "02/02/1967"),
            new Person(2, "Hosea", "Bell", "11/01/1980"),
        };

        private readonly ServiceResponse<Person> response = new();

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
        public Task<ServiceResponse<Person>> CreateAPersonFull(string first, string middle, string last, string dbo)
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
        public Task<ServiceResponse<Person>> DeleteAPerson(long id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     GET endpoint that retrieves a person.
        /// </summary>
        /// <returns>
        ///     The sucessfully completed Task.
        /// </returns>
        public Task<ServiceResponse<Person>> GetAPerson()
        {
            response.Data = people[1];
            response.Success = true;
            response.Message = "Sucessful request";

            return Task.FromResult(response);
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
        public Task<ServiceResponse<Person>> GetAPersonById(long id)
        {
            response.Data = people.SingleOrDefault(person => person.Id == id);
            response.Success = true;
            response.Message = "Sucessful request";

            return Task.FromResult(response);
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
        public Task<ServiceResponse<Person>> UpdateAPerson(long id, string middle)
        {
            var matchingPerson = people.SingleOrDefault(person => person.Id == id);

            if (matchingPerson != null)
                matchingPerson.MiddleName = middle;

            response.Data = matchingPerson;
            response.Success = true;
            response.Message = $"Middle name for person id {id} was updated successfully";

            return Task.FromResult(response);
        }
    }
}
