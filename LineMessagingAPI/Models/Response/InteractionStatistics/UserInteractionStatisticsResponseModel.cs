using System.Collections.Generic;

namespace LineMessagingAPI.Models.Response.InteractionStatistics
{
    /// <summary>
    /// User interaction statistics response object
    /// </summary>
    public class UserInteractionStatisticsResponseModel
    {
        /// <summary>
        /// Summary of message statistics.
        /// </summary>
        public List<OverviewModel> overview { get; set; }

        /// <summary>
        /// Array of information about individual message bubbles.
        /// </summary>
        public List<MessageModel> messages { get; set; }

        /// <summary>
        /// Array of information about URLs in the message.
        /// </summary>
        public List<ClickModel> clicks { get; set; }
    }
}