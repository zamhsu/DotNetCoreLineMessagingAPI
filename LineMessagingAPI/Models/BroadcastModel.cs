using System.Collections.Generic;
using LineMessagingAPI.Models.Message;

namespace LineMessagingAPI.Models
{
    /// <summary>
    /// Sends push messages to multiple users at any time.
    /// </summary>
    public class BroadcastModel
    {
        /// <summary>
        /// [Rquired] Model.Message
        /// Max: 5
        /// </summary>
        public List<MessageModel> messages { get; set; }
    }
}