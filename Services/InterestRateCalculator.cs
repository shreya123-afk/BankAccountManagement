namespace WebApplication1.Services
{
    /// <summary>
    /// The u=intrest rate calculater.
    /// </summary>
    public class InterestRateCalculator : IInterestRateCalculator
    {
        /// <summary>
        /// Method to calculate the intrest rate.
        /// </summary>
        /// <param name="creditRating"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public decimal CalculateInterestRate(int creditRating, int duration)
        {
            if (creditRating < 20)
                return 0;

            if (creditRating >= 20 && creditRating <= 50)
            {
                if (duration == 1) return 0.20m;
                if (duration == 3) return 0.15m;
                if (duration == 5) return 0.10m;
            }

            if (creditRating > 50)
            {
                if (duration == 1) return 0.12m;
                if (duration == 3) return 0.08m;
                if (duration == 5) return 0.05m;
            }
            return 0;
        }
    }
}