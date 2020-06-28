namespace LineMessagingAPI.Models.Action
{
    /// <summary>
    /// When a control associated with this action is tapped, a postback event is returned via webhook with the specified string in the data property.
    /// </summary>
    public class PostbackActionModel : ActionModel
    {
        /// <summary>
        /// [必填] 固定為 postback
        /// </summary>
        public string type
        {
            get
            {
                return "postback";
            }
        }

        /// <summary>
        /// Label for the action
        ///  * Required for templates other than image carousel. Max: 20 characters.
        ///  * Optional for image carousel templates. Max: 12 characters.
        ///  * Optional for rich menus. Spoken when the accessibility feature is enabled on the client device. Max: 20 characters. Supported on LINE 8.2.0 and later for iOS.
        ///  * Required for quick reply buttons. Max: 20 characters. Supported on LINE 8.11.0 and later for iOS and Android.
        ///  * Required for the button of Flex Message. This property can be specified for the box, image, and text but its value is not displayed. Max: 20 characters.
        /// </summary>
        public string lable { get; set; }

        /// <summary>
        /// [必填] String returned via webhook in the postback.data property of the postback event
        ///        Max: 300 characters
        /// </summary>
        public string data { get; set; }

        /// <summary>
        /// Text displayed in the chat as a message sent by the user when the action is performed.
        ///  * Required for quick reply buttons.
        ///  * Optional for the other message types.
        /// Max: 300 characters
        /// The displayText and text properties cannot both be used at the same time.
        /// </summary>
        public string displayText { get; set; }

        /// <summary>
        /// Text displayed in the chat as a message sent by the user when the action is performed. Returned from the server through a webhook. This property shouldn't be used with quick reply buttons.
        /// Max: 300 characters
        /// The displayText and text properties cannot both be used at the same time.
        /// </summary>
        public string text { get; set; }
    }
}