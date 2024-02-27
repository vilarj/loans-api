using System.ComponentModel.DataAnnotations;

namespace loans_api.Models
{
    public class Person
    {
        /// <summary>
        ///     Unique identifier of a person.
        ///     Key.
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        ///     First name of the person.
        ///     Required.
        /// </summary>
        /// <example>
        ///     Ash
        /// </example>
        [Required]
        public string FirstName { get; set; } = null!;

        /// <summary>
        ///     Middle name of the person.
        ///     Optional.
        /// </summary>
        /// <example>
        ///     Daniel
        /// </example>
        public string? MiddleName { get; set; }

        /// <summary>
        ///     Last name of the person.
        ///     Required.
        /// </summary>
        /// <example>
        ///     Harden
        /// </example>
        [Required]
        public string LastName { get; set; } = null!;

        /// <summary>
        ///     Date of birth of the person.
        ///     Required.
        /// </summary>
        /// <example>
        ///     12/25/2015
        /// </example>
        [Required]
        public string DOB { get; set; } = null!;

        /// <summary>
        ///     Time when the user is created.
        /// </summary>
        /// <example>
        ///     12/25/2015 12:00:00 AM
        /// </example>
        public DateTime CreatedOn { get; set; }
        
        /// <summary>
        ///     Single instance of <c>Person</c> that sets the time when
        ///     the new user is created.
        /// </summary>
        protected Person() 
        {
            CreatedOn = DateTime.Now;
        }

        /// <summary>
        ///     Single instance of <c>Person</c> for creating a new user given
        ///     the following args:
        /// </summary>
        /// <param name="firstName">
        ///      First name of the person.
        /// </param>
        /// <param name="lastName">
        ///     Last name of the person.
        /// </param>
        /// <param name="dOB">
        ///     Date of birth of the person.
        /// </param>
        public Person(string firstName, string lastName, string dOB)
        {
            FirstName = firstName;
            LastName = lastName;
            DOB = dOB;
        }

        /// <summary>
        ///     Single instance of <c>Person</c> for creating a new user given
        ///     the following args:
        /// </summary>
        /// <param name="firstName">
        ///      First name of the person.
        /// </param>
        /// <param name="middleName">
        ///     Middle name of the person.
        /// </param>
        /// <param name="lastName">
        ///     Last name of the person.
        /// </param>
        /// <param name="dOB">
        ///     Date of birth of the person.
        /// </param>
        public Person(string firstName, string middleName, string lastName, string dOB) : this(firstName, lastName, dOB)
        {
            MiddleName = middleName;
        }
    }
}
