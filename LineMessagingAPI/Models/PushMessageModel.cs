using System.Collections.Generic;
using LineMessagingAPI.Models.Message;

namespace LineMessagingAPI.Models
{
    public class PushMessageModel
    {
        /// <summary>
        /// 單一 userId
        /// </summary>
        public string to { get; set; }

        /// <summary>
        /// Model.Message
        /// Max: 5
        /// </summary>
        public List<MessageModel> messages { get; set; }
    }
}