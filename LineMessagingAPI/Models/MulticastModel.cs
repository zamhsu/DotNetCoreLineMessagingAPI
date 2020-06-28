using System.Collections.Generic;
using LineMessagingAPI.Models.Message;

namespace LineMessagingAPI.Models
{
    public class MulticastModel
    {
        /// <summary>
        /// UserIds
        /// Max: 150 user IDs
        /// </summary>
        public List<string> to { get; set; }

        /// <summary>
        /// Model.Message
        /// Max: 5
        /// </summary>
        public List<MessageModel> messages { get; set; }
    }
}