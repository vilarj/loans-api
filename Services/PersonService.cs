﻿using loans_api.Interfaces;
using loans_api.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace loans_api.Services
{
	public class PersonService : IPerson
    {
        private readonly List<Person> people = new()
        {
            new Person(0, "Kobe", "Harden", "01/01/1999"),
            new Person(1, "Dave", "Lebron", "Jimenez", "02/02/1967"),
            new Person(2,"Hosea", "Bell", "11/01/1980"),
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
        public Task<Person> CreateAPersonFull([BindRequired] string first, string middle, [BindRequired] string last, [BindRequired] string dbo)
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
        public Task<Person> DeleteAPerson([BindRequired] long id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     GET endpoint that retrieves a person.
        /// </summary>
        /// <returns>
        ///     The sucessfully completed Task.
        /// </returns>
        public Task<Person> GetAPerson()
        {
            return Task.FromResult(people[1]);
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
        public Task GetAPersonBy([BindRequired] long id)
        {
            return Task.FromResult(people.Where(personId => personId.Id == id));
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
        public Task<Person> UpdateAPerson([BindRequired] long id, [BindRequired] string middle)
        {
            throw new NotImplementedException();
        }
    }
}
