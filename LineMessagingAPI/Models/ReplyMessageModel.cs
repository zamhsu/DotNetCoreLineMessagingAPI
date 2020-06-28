using System.Collections.Generic;
using LineMessagingAPI.Models.Message;

namespace LineMessagingAPI.Models
{
    /// <summary>
    /// Sends a reply message in response to an event from a user, group, or room.
    /// </summary>
    public class ReplyMessageModel
    {
        /// <summary>
        /// [Required] Reply token received via webhook
        /// </summary>
        public string replyToken { get; set; }

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