using LineMessagingAPI.Models.Message.QuickReply;

namespace LineMessagingAPI.Models.Message
{
    public class TextMessageModel : MessageModel
    {
        /// <summary>
        /// [必填] 固定為 text
        /// </summary>
        public string type
        {
            get
            {
                return "text";
            }
        }

        /// <summary>
        /// [必填] Message text. You can include the following emoji:
        ///         * Unicode emoji
        ///         * LINE original emoji (Unicode code point table for LINE original emoji)
        ///        Max: 2000 characters
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// [選填] Quick reply.
        /// </summary>
        /// <value></value>
        public QuickReplyModel quickReply { get; set; }
    }
}