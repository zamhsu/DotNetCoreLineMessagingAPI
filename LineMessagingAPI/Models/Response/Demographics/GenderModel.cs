namespace LineMessagingAPI.Models.Response.Demographic
{
    /// <summary>
    /// Percentage per gender
    /// </summary>
    public class GenderModel
    {
        /// <summary>
        /// Gender
        /// </summary>
        public string gender { get; set; }

        /// <summary>
        /// Percentage
        /// </summary>
        public double percentage { get; set; }
    }
}