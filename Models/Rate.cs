namespace MortgageRatesApi.Models
{
    // Represents a mortgage rate data model
    public class Rate
    {
        public string LoanType { get; set; }
        public int Term { get; set; }
        public decimal InterestRate { get; set; }
    }
}