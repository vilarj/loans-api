using System.Drawing;
using System.Drawing.Printing;

namespace loans_api.Services
{
    public class LoanService : ILoan
	{
        private readonly List<Person> people = new()
        {
            new Person(0, "Kobe", "Harden", "01/01/1999"),
        };

        /// <summary>
        ///     GET endpoint that generates a PDF file containing the basic
        ///     information of a <c>Person</c> that pertain to the information
        ///     on the loan application.
        /// </summary>
        /// <param name="id">
        ///     Unique identifier of a <c>Person</c> that is linked to the loan document.
        /// </param>
        /// <returns>
        ///     The sucessfully completed Task.
        /// </returns>
        public async Task<ServiceResponse<string>> GenerateLoanStatusAsync(long id)
        {
            ServiceResponse<string> serviceResponse = new();

            PrintDocument document = new();
            document.PrintPage += new PrintPageEventHandler(OnPrint);
            document.Print();

            serviceResponse.Message = "PDF File genreated";
            serviceResponse.Success = true;

            return await Task.FromResult(serviceResponse);
        }

        /// <summary>
        ///     Generates a PDF document.
        /// </summary>
        /// <param name="sender">
        ///     The sender of the PDF document.
        /// </param>
        /// <param name="e">
        ///     PrintPageEventArgs object that fills the PDF file with all formating details.
        /// </param>
        private static void OnPrint(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hello, World!", new Font("Arial", 20), Brushes.Black, 0, 0);
        }
    }
}
