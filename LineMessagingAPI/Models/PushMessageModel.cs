using System.Collections.Generic;
using LineMessagingAPI.Models.Message;

namespace LineMessagingAPI.Models
{
    public class PushMessageModel
    {
        /// <summary>
        /// [Required] ID of the target recipient.
        /// Use a userId, groupId, or roomId value returned in a webhook event object. Do not use the LINE ID found on LINE.
        /// </summary>
        public string to { get; set; }

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