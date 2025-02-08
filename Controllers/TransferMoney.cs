using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// The transfer amount from one account to another account controller.
    /// </summary>
    public class TransferMoney : Controller
    {
        /// <summary>
        /// Returns the transfer view
        /// </summary>
        /// <returns></returns>
        public IActionResult Transfer()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                return RedirectToAction("Login");
            }

            var user = BankRepository.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return RedirectToAction("Login");
            }

            ViewBag.UserAccounts = user.Accounts;
            return View();
        }

        /// <summary>
        /// Account Transfer detail.
        /// </summary>
        /// <param name="fromAccountId"></param>
        /// <param name="toAccountId"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        // POST: Account/Transfer
        [HttpPost]
        public ActionResult Transfer(int fromAccountId, int toAccountId, decimal amount)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                return RedirectToAction("Login");
            }

            var user = BankRepository.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return RedirectToAction("Login");
            }

            var fromAccount = user.Accounts.FirstOrDefault(a => a.Id == fromAccountId);
            var toAccount = user.Accounts.FirstOrDefault(a => a.Id == toAccountId);

            if (fromAccount != null && toAccount != null && fromAccount.Balance >= amount)
            {
                fromAccount.Balance -= amount;
                toAccount.Balance += amount;
                return RedirectToAction("Dashboard","Account");
            }

            ModelState.AddModelError("", "Invalid transfer details.");
            return View();
        }

        /// <summary>
        /// Session logged out from the current user.
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}