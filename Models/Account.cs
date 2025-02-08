namespace WebApplication1.Models
{
    /// <summary>
    /// This class represents the account details.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Gets or sets account id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the account balance.
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Gets or sets the accountType
        /// </summary>
        public required string AccountType { get; set; }
    }
}
