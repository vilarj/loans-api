namespace loans_api.Interfaces
{
    public interface ILoan
    {
        Task<ServiceResponse<string>> GenerateLoanStatusAsync(long id);
    }
}

