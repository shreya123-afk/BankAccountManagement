namespace WebApplication1.Models
{
    /// <summary>
    /// This class has the simulated data of users. 
    /// </summary>
    public static class BankRepository
    {
        public static List<User> Users = new List<User>
    {
        new User { Id = 1, Name = "Bob", CreditRating = 15, Accounts = new List<Account>
        {
            new Account { Id = 1, Balance = 1000, AccountType = "Current" },
            new Account { Id = 2, Balance = 2000, AccountType = "Savings" }
        }},

        new User { Id = 2, Name = "Jim", CreditRating = 45, Accounts = new List<Account>
        {
            new Account { Id = 3, Balance = 1500, AccountType = "Current" },
            new Account { Id = 4, Balance = 5000, AccountType = "Savings" },
            new Account { Id = 5, Balance = 1000, AccountType = "Loan" }
        }},

        new User { Id = 3, Name = "Anne", CreditRating = 80, Accounts = new List<Account>
        {
            new Account { Id = 6, Balance = 3000, AccountType = "Current" },
            new Account { Id = 7, Balance = 8000, AccountType = "Savings" }
        }}
    };

        /// <summary>
        /// Get the logged in user name.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static User GetUserByName(string userName)
        {
            return Users.FirstOrDefault(u => u.Name.Equals(userName, StringComparison.OrdinalIgnoreCase));
        }
    }
}

