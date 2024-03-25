using loans_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace loans_api.Interfaces
{
    public interface IPerson
    {
        Task<Person> GetAPerson();

        Task GetAPersonBy([BindRequired] long id);

        Task<Person> CreateAPersonFull([BindRequired] string first, string middle, [BindRequired] string last, [BindRequired] string dbo);

        Task<Person> UpdateAPerson([BindRequired] long id, [BindRequired] string middle);

        Task<Person> DeleteAPerson([BindRequired] long id);
    }
}
