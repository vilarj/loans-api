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

        public Task<string> GenerateLoanStatus(long id)
        {
            throw new NotImplementedException();
        }
    }
}

