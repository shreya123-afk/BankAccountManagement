using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// The Account controller.
    /// </summary>
    public class AccountController : Controller
    {
        /// <summary>
        /// Return the login page view
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// User logged in based on username.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(string userName)
        {
            var user = BankRepository.GetUserByName(userName);
            if (user != null)
            {
                HttpContext.Session.SetInt32("UserId", user.Id);
                HttpContext.Session.SetInt32("CreditRating", user.CreditRating);
                return RedirectToAction("Dashboard");
            }

            ModelState.AddModelError("", "User not found.");
            return View();
        }

        /// <summary>
        /// Return the dashoboard with account details with balance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Dashboard()
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

            return View(user);
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