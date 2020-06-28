namespace LineMessagingAPI.Models.Response.Demographic
{
    /// <summary>
    /// Percentage per age group
    /// </summary>
    public class AgeModel
    {
        /// <summary>
        /// Age group
        /// </summary>
        public string age { get; set; }

        /// <summary>
        /// Percentage
        /// </summary>
        public double percentage { get; set; }
    }
}