namespace LineMessagingAPI.Models.Response.InteractionStatistics
{
    /// <summary>
    /// Information about individual message bubbles.
    /// </summary>
    public class MessageModel
    {
        /// <summary>
        /// Bubble's serial number.
        /// </summary>
        public long seq { get; set; }

        /// <summary>
        /// Number of times the bubble was displayed.
        /// </summary>
        public long impression { get; set; }

        /// <summary>
        /// Number of times audio or video in the bubble started playing.
        /// </summary>
        public long mediaPlayed { get; set; }

        /// <summary>
        /// Number of times audio or video in the bubble was played from start to 25%.
        /// </summary>
        public long mediaPlayed25Percent { get; set; }

        /// <summary>
        /// Number of times audio or video in the bubble was played from start to 50%.
        /// </summary>
        public long mediaPlayed50Percent { get; set; }

        /// <summary>
        /// Number of times audio or video in the bubble was played from start to 75%.
        /// </summary>
        public long mediaPlayed75Percent { get; set; }

        /// <summary>
        /// Number of times audio or video in the bubble was played in its entirety.
        /// </summary>
        public long mediaPlayed100Percent { get; set; }

        /// <summary>
        /// Number of people that started playing audio or video in the bubble.
        /// </summary>
        public long uniqueMediaPlayed { get; set; }

        /// <summary>
        /// Number of people that played audio or video in the bubble from start to 25%.
        /// </summary>
        public long uniqueMediaPlayed25Percent { get; set; }

        /// <summary>
        /// Number of people that played audio or video in the bubble from start to 50%.
        /// </summary>
        public long uniqueMediaPlayed50Percent { get; set; }

        /// <summary>
        /// Number of people that played audio or video in the bubble from start to 75%.
        /// </summary>
        public long uniqueMediaPlayed75Percent { get; set; }

        /// <summary>
        /// Number of people that played audio or video in the bubble in its entirety.
        /// </summary>
        public long uniqueMediaPlayed100Percent { get; set; }
    }
}