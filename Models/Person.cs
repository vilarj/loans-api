namespace loans_api.Models
{
    public class Person
    {
        /// <summary>
        ///     First name of the person.
        /// </summary>
        /// <example>
        ///     Ash
        /// </example>
        public string? FirstName { get; set; } = null!;

        /// <summary>
        ///     Middle name of the person.
        /// </summary>
        /// <example>
        ///     Daniel
        /// </example>
        public string? MiddleName { get; set; } = null!;

        /// <summary>
        ///     Last name of the person.
        /// </summary>
        /// <example>
        ///     Harden
        /// </example>
        public string? LastName { get; set; } = null!;

        /// <summary>
        ///     Date of birth of the person.
        /// </summary>
        /// <example>
        ///     12/25/2015
        /// </example>
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
