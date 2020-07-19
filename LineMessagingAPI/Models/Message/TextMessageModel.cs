using LineMessagingAPI.Models.Message.QuickReply;

namespace LineMessagingAPI.Models.Message
{
    /// <summary>
    /// Send text message
    /// </summary>
    public class TextMessageModel : MessageModel
    {
        /// <summary>
        /// [Required] text
        /// </summary>
        public string type
        {
            get
            {
                return "text";
            }
        }

        /// <summary>
        /// [Required] Message text. You can include the following emoji:
        ///         * Unicode emoji
        ///         * LINE original emoji (Unicode code point table for LINE original emoji)
        ///        Max: 2000 characters
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// [Optional] Quick reply.
        /// </summary>
        /// <value></value>
        public QuickReplyModel quickReply { get; set; }
    }
}