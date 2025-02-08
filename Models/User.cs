namespace WebApplication1.Models
{
    /// <summary>
    /// This class represents the user details,
    /// </summary>
    public class User
    {
        /// <summary>
        /// List of account types.
        /// </summary>
        public User()
        {
            Accounts = new List<Account>();
        }

        /// <summary>
        /// Gets or sets the user is.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the credit rating .
        /// </summary>
        public int CreditRating {  get; set; }

        /// <summary>
        /// Gets or sets the list of accounts.
        /// </summary>
        public List<Account> Accounts { get; set; }
    }
}
