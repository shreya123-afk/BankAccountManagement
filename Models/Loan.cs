using System.ComponentModel.DataAnnotations;
using WebApplication1.Services;

namespace WebApplication1.Models
{
    /// <summary>
    /// This class represents the loan details,
    /// </summary>
    public class Loan
    {
        private readonly IInterestRateCalculator _interestRateCalculator;

        /// <summary>
        /// Accepts an object that implements the IInterestRateCalculator interface.
        /// </summary>
        /// <param name="interestRateCalculator"></param>
        public Loan(IInterestRateCalculator interestRateCalculator)
        {
            _interestRateCalculator = interestRateCalculator;
        }

        [Required]
        [Range(100, 100000, ErrorMessage = "Amount must be between $100 and $100,000.")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets the intrest rate
        /// </summary>
        public decimal InterestRate { get; set; }

        /// <summary>
        /// Gets or sets the credit rating
        /// </summary>
        public int CreditRating { get; set; }

        /// <summary>
        /// Calculate the interest for the loan based on the user's credit rating and loan duration.
        /// </summary>
        public void CalculateInterest()
        {
            InterestRate = _interestRateCalculator.CalculateInterestRate(CreditRating, Duration);
        }
    }
}
