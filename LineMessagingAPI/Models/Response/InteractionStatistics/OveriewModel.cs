namespace LineMessagingAPI.Models.Response.InteractionStatistics
{
    /// <summary>
    /// Summary of message statistics.
    /// </summary>
    public class OverviewModel
    {
        /// <summary>
        /// Request ID.
        /// </summary>
        public string requestId { get; set; }

        /// <summary>
        /// UNIX timestamp for message delivery time.
        /// </summary>
        public long timestamp { get; set; }

        /// <summary>
        /// Number of messages delivered. This property shows values of less than 20.
        /// </summary>
        public long delivered { get; set; }

        /// <summary>
        /// Number of people who opened the message, meaning they displayed at least 1 bubble.
        /// </summary>
        public long uniqueImpression { get; set; }

        /// <summary>
        /// Number of people who opened any URL in the message.
        /// </summary>
        public long uniqueClick { get; set; }

        /// <summary>
        /// Number of people who started playing any video or audio in the message.
        /// </summary>
        public long uniqueMediaPlay { get; set; }

        /// <summary>
        /// Number of people who played the entirety of any video or audio in the message.
        /// </summary>
        public long uniqueMediaPlay100Percent { get; set; }
    }
}