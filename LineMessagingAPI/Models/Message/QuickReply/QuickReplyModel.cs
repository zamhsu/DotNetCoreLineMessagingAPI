using System.Collections.Generic;

namespace LineMessagingAPI.Models.Message.QuickReply
{
    /// <summary>
    /// This is a container that contains quick reply buttons.
    /// </summary>
    public class QuickReplyModel
    {
        public List<QuickReplyItemModel> items { get; set; }
    }
}