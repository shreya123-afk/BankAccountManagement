namespace WebApplication1.Models
{
    public class Account
    {
        /// <summary>
        /// Initialize the account.
        /// </summary>
        /// <param name="accountType"></param>
        /// <param name="balance"></param>
        public Account(string accountType, decimal balance)
        {
            AccountType = accountType;
            Balanace = balance;
        }

        /// <summary>
        /// Get or set the account id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// get or set the account balance.
        /// </summary>
        public decimal Balanace { get; set; }

        /// <summary>
        /// get or set the accountType
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// get or set the User.
        /// </summary>
        public User User { get; set; }

    }
}
