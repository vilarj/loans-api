namespace loans_api.Interfaces
{
    public interface IPerson
    {
        Task<Person> GetAPerson();

        Task<Person> GetAPersonById(long id);

        Task<Person> CreateAPersonFull(string first, string middle, string last, string dbo);

        Task<Person> UpdateAPerson(long id, string middle);

        Task<Person> DeleteAPerson(long id);
    }
}
