using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// The loan detail controller.
    /// </summary>
    public class LoanController : Controller
    {
        private readonly IInterestRateCalculator _interestRateCalculator;

        public LoanController(IInterestRateCalculator interestRateCalculator)
        {
            _interestRateCalculator = interestRateCalculator;
        }

        /// <summary>
        /// Return the apply loan.
        /// </summary>
        /// <returns></returns>
        public ActionResult ApplyLoan()
        {
            // Retrieve the current logged-in user's UserId from session
            int? userId = HttpContext.Session.GetInt32("UserId");
            int? creditRating = HttpContext.Session.GetInt32("CreditRating");

            if (creditRating < 20)
            {
                TempData["Message"] = "Loan request denied: Credit rating too low.";
                return RedirectToAction("Dashboard", "Account");
            }
            return RedirectToAction("RequestLoan");
        }

        /// <summary>
        /// Returns the request loan page.
        /// </summary>
        /// <param name="creditRating"></param>
        /// <param name="duration"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public ActionResult RequestLoan(int creditRating, int duration, decimal amount)
        {
            var loan = new Loan(_interestRateCalculator)
            {
                CreditRating = creditRating,
                Duration = duration,
                Amount = amount
            };

            loan.CalculateInterest();
            return View(loan);
        }
    }
}
