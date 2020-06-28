namespace LineMessagingAPI.Models.Response.Demographic
{
    /// <summary>
    /// Percentage by OS
    /// </summary>
    public class AppTypeModel
    {
        /// <summary>
        /// OS
        /// </summary>
        public string appType { get; set; }

        /// <summary>
        /// Percentage
        /// </summary>
        public double percentage { get; set; }
    }
}