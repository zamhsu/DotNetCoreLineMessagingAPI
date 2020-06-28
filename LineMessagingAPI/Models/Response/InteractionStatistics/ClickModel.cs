namespace LineMessagingAPI.Models.Response.InteractionStatistics
{
    /// <summary>
    /// Information about URLs in the message.
    /// </summary>
    public class ClickModel
    {
        /// <summary>
        /// The URL's serial number.
        /// </summary>
        public long seq { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Number of times the URL was opened.
        /// </summary>
        public long click { get; set; }

        /// <summary>
        /// Number of people that opened the URL.
        /// </summary>
        public long uniqueClick { get; set; }

        /// <summary>
        /// Number of people who opened this url through any link in the message.
        /// If a message contains two links to the same URL and a user opens both links, they're counted only once.
        /// </summary>
        public long uniqueClickOfRequest { get; set; }
    }
}