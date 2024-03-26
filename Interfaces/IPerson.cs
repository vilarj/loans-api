namespace loans_api.Interfaces
{
    public interface IPerson
    {
        Task<ServiceResponse<Person>> GetAPerson();

        Task<ServiceResponse<Person>> GetAPersonById(long id);

        Task<ServiceResponse<Person>> CreateAPersonFull(string first, string middle, string last, string dbo);

        Task<ServiceResponse<Person>> UpdateAPerson(long id, string middle);

        Task<ServiceResponse<Person>> DeleteAPerson(long id);
    }
}
