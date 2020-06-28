using System.Collections.Generic;
using LineMessagingAPI.Models.Message;

namespace LineMessagingAPI.Models
{
    public class BroadcastModel
    {
        /// <summary>
        /// Model.Message
        /// Max: 5
        /// </summary>
        public List<MessageModel> messages { get; set; }
    }
}