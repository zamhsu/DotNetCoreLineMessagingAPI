using LineMessagingAPI.Models.Message.Template;

namespace LineMessagingAPI.Models.Message
{
    /// <summary>
    /// The following properties are common to all template message objects.
    /// </summary>
    public class TemplateMessageModel : MessageModel
    {
        /// <summary>
        /// [Required] template
        /// </summary>
        public string type
        {
            get
            {
                return "template";
            }
        }

        /// <summary>
        /// [Required] Alternative text.
        /// Max: 400 characters
        /// </summary>
        public string altText { get; set; }

        /// <summary>
        /// [Required] A Buttons, Confirm, Carousel, or Image Carousel object.
        /// </summary>
        public TemplateModel template { get; set; }
    }
}