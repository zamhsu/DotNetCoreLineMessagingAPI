using LineMessagingAPI.Models.Message.Template;

namespace LineMessagingAPI.Models.Message
{
    /// <summary>
    /// The following properties are common to all template message objects.
    /// </summary>
    public class TemplateMessageModel : MessageModel
    {
        /// <summary>
        /// [必填] 固定為 template
        /// </summary>
        public string type
        {
            get
            {
                return "template";
            }
        }

        /// <summary>
        /// [必填] Alternative text.
        /// Max: 400 characters
        /// </summary>
        public string altText { get; set; }

        /// <summary>
        /// [必填] A Buttons, Confirm, Carousel, or Image Carousel object.
        /// </summary>
        public TemplateModel template { get; set; }
    }
}