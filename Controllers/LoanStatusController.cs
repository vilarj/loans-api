namespace loans_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanStatus : Controller
    {
        private readonly ILoan _loanService;
        private readonly IPerson _personServive;

        public LoanStatus(ILoan loanService, IPerson personService)
        {
            _loanService = loanService;
            _personServive = personService;
        }

        /// <summary>
        ///     GET endpoint that retrieves the status of an existing loan.
        /// </summary>
        /// <param name="id">
        ///     Unique identifier of the <c>Person</c>'s loan. 
        /// </param>
        /// <returns>
        ///     The sucessfully completed Task.
        /// </returns>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public Task<string> GenerateLoanStatus(long id)
        {
            return _loanService.GenerateLoanStatus(id);
        }
    }
}

