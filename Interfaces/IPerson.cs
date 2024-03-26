namespace loans_api.Interfaces
{
    public interface IPerson
    {
        Task<ServiceResponse<Person>> GetAPerson();

        Task<ServiceResponse<Person>> GetAPersonById(long id);

        Task<ServiceResponse<List<Person>>> CreateAPersonFull(Person newPerson);

        Task<ServiceResponse<Person>> UpdateAPerson(long id, string middle);

        Task<ServiceResponse<Person>> DeleteAPerson(long id);
    }
}
