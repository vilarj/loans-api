namespace loans_api.Services
{
	public class PersonService : IPerson
    {
        private List<Person> people = new()
        {
            new Person(0, "Kobe", "Harden", "01/01/1999"),
            new Person(1, "Dave", "Lebron", "Jimenez", "02/02/1967"),
            new Person(2, "Hosea", "Bell", "11/01/1980"),
        };

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
        public async Task<ServiceResponse<List<Person>>> CreateAPersonFull(Person newPerson)
        {
            var serviceResponse = new ServiceResponse<List<Person>>();

            people.Add(newPerson);
            serviceResponse.Data = people;
            serviceResponse.Message = $"{newPerson}\nwas created";
            serviceResponse.Success = true;

            return await Task.FromResult(serviceResponse);
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
        public async Task<ServiceResponse<List<Person>>> DeleteAPerson(long id)
        {
            var serviceResponse = new ServiceResponse<List<Person>>();

            if (IsEmpty(people))
            {
                serviceResponse.Success = false;
                serviceResponse.Message = $"No person associated with this id {id}";

                return await Task.FromResult(serviceResponse);
            }

            else if (!IsMatch(people, id))
            {

                serviceResponse.Success = false;
                serviceResponse.Message = $"No person associated with this id {id}";

                return await Task.FromResult(serviceResponse);
            }

            else
            {
                var personToBeRemoved = people.SingleOrDefault(person => person.Id == id);

                if (personToBeRemoved != null)
                    people.Remove(personToBeRemoved);

                serviceResponse.Data = people;
                serviceResponse.Message = $"Person with id {id} was removed.";
                serviceResponse.Success = true;

                return await Task.FromResult(serviceResponse);
            }
        }

        /// <summary>
        ///     GET endpoint that retrieves a person.
        /// </summary>
        /// <returns>
        ///     The sucessfully completed Task.
        /// </returns>
        public async Task<ServiceResponse<Person>> GetAPerson()
        {
            var serviceResponse = new ServiceResponse<Person>
            {
                Data = people[1],
                Success = true,
                Message = "Sucessful request"
            };

            return await Task.FromResult(serviceResponse);
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
        public async Task<ServiceResponse<Person>> GetAPersonById(long id)
        {
            var serviceResponse = new ServiceResponse<Person>();

            // Check: No records at all
            if (IsEmpty(people))
            {
                serviceResponse.Success = false;
                serviceResponse.Message = $"No person associated with this id {id}";

                return await Task.FromResult(serviceResponse);
            }

            // Check: No matching record
            else if (!IsMatch(people, id))
            {
                serviceResponse.Success = false;
                serviceResponse.Message = $"No person associated with this id {id}";

                return await Task.FromResult(serviceResponse);
            }

            // Check: Found a match
            else
            {
                serviceResponse.Data = people.SingleOrDefault(person => person.Id == id);
                serviceResponse.Success = true;
                serviceResponse.Message = $"Retrieving associated person with id {id}";

                return await Task.FromResult(serviceResponse);
            }
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
        public async Task<ServiceResponse<Person>> UpdateAPerson(long id, string middle)
        {

            if (IsEmpty(people))
            {
                var serviceResponse = new ServiceResponse<Person>();
                serviceResponse.Success = false;
                serviceResponse.Message = $"No person associated with this id {id}";

                return await Task.FromResult(serviceResponse);
            }

            else if (!IsMatch(people, id))
            {
                var serviceResponse = new ServiceResponse<Person>();
                serviceResponse.Success = false;
                serviceResponse.Message = $"No person associated with this id {id}";

                return await Task.FromResult(serviceResponse);
            }

            else
            {
                var serviceResponse = new ServiceResponse<Person>();
                
                var match = people.SingleOrDefault(person => person.Id == id);
                match.MiddleName = middle;

                serviceResponse.Success = true;
                serviceResponse.Message = $"Middle name for person id {id} was updated successfully";

                return await Task.FromResult(serviceResponse);
            }
        }

        /// <summary>
        ///     Determines if the list contains elements in it.
        /// </summary>
        /// <param name="person">
        ///     List of people of type <c>Person</c>.
        /// </param>
        /// <returns>
        ///     true/false based on the number of elements in the list.
        /// </returns>
        private static bool IsEmpty(List<Person> person)
        {
            return person.Count == 0;
        }

        /// <summary>
        ///     Determines if the person exists in the list of people.
        /// </summary>
        /// <param name="person">
        ///     List of people of type <c>Person</c> to be matched.
        /// </param>
        /// <param name="id">
        ///     Unique identifier of type <c>long</c> for a <c>Person</c>.
        /// </param>
        /// <returns>
        ///     true/false based on the id of the person to be matched.
        /// </returns>
        private static bool IsMatch(List<Person> person, long id)
        {
            return person.Any(p => p.Id == id);
        }
    }
}
