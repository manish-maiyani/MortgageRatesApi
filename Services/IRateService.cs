using MortgageRatesApi.Models;
using System.Threading.Tasks;

// Interface for rate service to ensure loose coupling
namespace MortgageRatesApi.Services
{
    public interface IRateService
    {
        Task<Rate> GetRateAsync(string loanType, int term);
    }
}