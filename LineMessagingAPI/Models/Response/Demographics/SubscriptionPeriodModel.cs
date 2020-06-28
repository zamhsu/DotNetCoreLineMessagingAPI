namespace LineMessagingAPI.Models.Response.Demographic
{
    /// <summary>
    /// Percentage per friendship duration
    /// </summary>
    public class SubscriptionPeriodModel
    {
        /// <summary>
        /// Friendship duration
        /// </summary>
        public string subscriptionPeriod { get; set; }

        /// <summary>
        /// Percentage
        /// </summary>
        public double percentage { get; set; }
    }
}