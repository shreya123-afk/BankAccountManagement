namespace WebApplication1.Services
{
    /// <summary>
    /// Defines the interface to calculate the rate of intrest.
    /// </summary>
    public interface IInterestRateCalculator
    {
        /// <summary>
        /// Method to calulate rate of intrest.
        /// </summary>
        /// <param name="creditRating"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        decimal CalculateInterestRate(int creditRating, int duration);
    }
}
