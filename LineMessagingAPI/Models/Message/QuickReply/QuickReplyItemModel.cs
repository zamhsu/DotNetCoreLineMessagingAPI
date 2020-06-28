using LineMessagingAPI.Models.Action;

namespace LineMessagingAPI.Models.Message.QuickReply
{
    /// <summary>
    /// This is a quick reply option that is displayed as a button.
    /// </summary>
    public class QuickReplyItemModel
    {
        /// <summary>
        /// [Required] action
        /// </summary>
        public string type
        {
            get
            {
                return "action";
            }
        }

        /// <summary>
        /// URL of the icon that is displayed at the beginning of the button
        /// Max: 1000 characters
        /// URL scheme: https
        /// Image format: PNG
        /// Aspect ratio: 1:1
        /// Data size: Up to 1 MB
        /// There is no limit on the image size.
        /// If the action property has a camera action, camera roll action, or location action, and the imageUrl property is not set, the default icon is displayed.
        /// </summary>
        public string imageUrl { get; set; }

        /// <summary>
        /// Action performed when this button is tapped. Specify an action object. The following is a list of the available actions:
        /// Postback action
        /// Message action
        /// Datetime picker action
        /// Camera action
        /// Camera roll action
        /// Location action
        /// </summary>
        public ActionModel action { get; set; }
    }
}