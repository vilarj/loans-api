namespace loans_api.Models
{
    public class Loan
	{
        /// <summary>
        ///     Unique identifier of a document.
        ///     Key.
        /// </summary>
        /// <example>
        ///     123456
        /// </example>
        [Key]
        protected long Id { get; set; }

        /// <summary>
        ///     Identifier of a document.
        ///     Key.
        /// </summary>
        /// <example>
        ///     23238781776
        /// </example>
        [Required]
        protected long DocumentId { get; set; }

        /// <summary>
        ///     Single instance of <c>Person</c> for creating a new user given
        ///     the following args:
        /// </summary>
        /// <param name="id">
        ///      Unique identifier of the Person.
        /// </param>
        /// <param name="firstName">
        ///      First name of the person.
        /// </param>
        /// <param name="lastName">
        ///     Last name of the person.
        /// </param>
        /// <param name="dOB">
        ///     Date of birth of the person.
        /// </param>
        [Required]
        protected Person Person;

        /// <summary>
        ///     Document status. A document can only exist in one of the following statuses:
        ///     
        /// <list type="number">
        ///     <listheader>
        ///         <term>Loan Statuses</term>
        ///     </listheader>
        ///     <item>
        ///         <term>PreApproved</term>
        ///         <description>Formal pre authorization gotten for a requested type of loan. More information
        ///             needed to obtain a full approval status.
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <term>Approved</term>
        ///         <description>Formal authorization gotten for a requested type of loan</description>
        ///     </item>
        ///     <item>
        ///         <term>Pending Approved</term>
        ///         <description>Fully formal authorization gotten for a requested type of loan. Some processes are
        ///             still pending completion.
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <term>Rejected</term>
        ///         <description>Formal unapproved authorization gotten for a requested type of loan.</description>
        ///     </item>
        /// </list> 
        /// </summary>
        [Required]
        protected string Status { get; set; }

        /// <summary>
        ///     Time when the document is created.
        /// </summary>
        /// <example>
        ///     12/25/2015 12:00:00 AM
        /// </example>
        [Required]
        protected DateTime CreatedOn { get; set; }

        protected Loan()
        {
            CreatedOn = DateTime.Now;
        }

        public Loan(long id, long documentId, Person person, string status) : this()
        {
            Id = id;
            DocumentId = documentId;
            Person = person;
            Status = status;
        }
    }
}

