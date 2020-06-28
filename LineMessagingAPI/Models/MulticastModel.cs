using System.Collections.Generic;
using LineMessagingAPI.Models.Message;

namespace LineMessagingAPI.Models
{
    /// <summary>
    /// Sends push messages to multiple users at any time. Messages cannot be sent to groups or rooms.
    /// </summary>
    public class MulticastModel
    {
        /// <summary>
        /// [Required] UserIds
        /// Max: 150 user IDs
        /// </summary>
        public List<string> to { get; set; }

        /// <summary>
        /// [Required] Model.Message
        /// Max: 5
        /// </summary>
        public List<MessageModel> messages { get; set; }

        /// <summary>
        /// [Optional] true: The user doesn't receive a push notification when the message is sent.
        /// false: The user receives a push notification when the message is sent (unless they have disabled push notifications in LINE and/or their device).
        /// </summary>
        public bool notificationDisabled { get; set; }
    }
}