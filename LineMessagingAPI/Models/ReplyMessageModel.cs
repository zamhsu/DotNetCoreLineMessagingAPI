using System.Collections.Generic;
using LineMessagingAPI.Models.Message;

namespace LineMessagingAPI.Models
{
    public class ReplyMessageModel
    {
        public string replyToken { get; set; }

        /// <summary>
        /// Model.Message
        /// Max: 5
        /// </summary>
        public List<MessageModel> messages { get; set; }
    }
}