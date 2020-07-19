namespace LineMessagingAPI.Models.Message
{
    /// <summary>
    /// Send location message
    /// </summary>
    public class LocationMessageModel : MessageModel
    {
        /// <summary>
        /// [Required] location
        /// </summary>
        public string type
        {
            get
            {
                return "location";
            }
        }

        /// <summary>
        /// [Required] Title
        /// Max: 100 characters
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// [Required] Address
        /// Max: 100 characters
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// [Required] Latitude
        /// </summary>
        public double latitude { get; set; }

        /// <summary>
        /// [Required] Longitude
        /// </summary>
        public double longtitude { get; set; }
    }
}