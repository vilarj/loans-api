namespace loans_api.Services
{
    public class LoanService : ILoan
	{
        private readonly List<Person> people = new()
        {
            new Person(0, "Kobe", "Harden", "01/01/1999"),
            new Person(1, "Dave", "Lebron", "Jimenez", "02/02/1967"),
            new Person(2, "Hosea", "Bell", "11/01/1980"),
        };

        // Generate PDF file report of the status of the loan.
        // A loan can be in PreApproved, Approved, Pending Approval, Rejected.
        public Task<string> GenerateLoanStatus(long id)
        {
            // Check if the id is valid (if the user exists/if the id is not null)
            throw new NotImplementedException();
        }
    }
}

