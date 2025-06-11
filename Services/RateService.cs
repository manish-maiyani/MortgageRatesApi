using MortgageRatesApi.Models;
using System.Threading.Tasks;

// Provides mock rate data based on loan type and term
namespace MortgageRatesApi.Services
{
    public class RateService : IRateService
    {
        public async Task<Rate> GetRateAsync(string loanType, int term)
        {
            // Mock data: Simulate rate lookup
            if (loanType.ToLower() == "owner-occupied" && term == 30)
            {
                return await Task.FromResult(new Rate
                {
                    LoanType = loanType,
                    Term = term,
                    InterestRate = 5.25m // Example fixed rate
                });
            }

            // Return null for unsupported loan types or terms
            return null;
        }
    }
}