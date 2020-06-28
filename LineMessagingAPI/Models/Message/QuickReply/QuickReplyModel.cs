using System.Collections.Generic;

namespace LineMessagingAPI.Models.Message.QuickReply
{
    /// <summary>
    /// This is a container that contains quick reply buttons.
    /// </summary>
    public class QuickReplyModel
    {
        /// <summary>
        /// [Required] Quick reply button objects. Max: 13 objects
        /// </summary>
        public List<QuickReplyItemModel> items { get; set; }
    }
}