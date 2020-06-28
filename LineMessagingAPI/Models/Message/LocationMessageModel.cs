namespace LineMessagingAPI.Models.Message
{
    public class LocationMessageModel : MessageModel
    {
        /// <summary>
        /// [必填] 固定為 location
        /// </summary>
        public string type
        {
            get
            {
                return "location";
            }
        }

        /// <summary>
        /// [必填] Title
        /// Max: 100 characters
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// [必填] Address
        /// Max: 100 characters
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// [必填] Latitude
        /// </summary>
        public double latitude { get; set; }

        /// <summary>
        /// [必填] Longitude
        /// </summary>
        public double longtitude { get; set; }
    }
}