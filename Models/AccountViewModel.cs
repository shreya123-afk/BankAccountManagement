namespace WebApplication1.Models
{
    /// <summary>
    /// The accountViewModel is used to represent all the data needed to display and interact with a bank account in a user interface.
    /// </summary>
    public class AccountViewModel
    {
        /// <summary>
        /// Gets or sets the from account id.
        /// </summary>
        public int FromAccountId { get; set; }

        /// <summary>
        /// Gets or sets the to account id.
        /// </summary>
        public int ToAccountId { get; set; }
    }
}