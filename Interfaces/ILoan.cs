namespace loans_api.Interfaces
{
    public interface ILoan
    {
        Task<string> GenerateLoanStatus(long id);
    }
}

