namespace LineMessagingAPI.Models.Action
{
    /// <summary>
    /// When a control associated with this action is tapped, the string in the text property is sent as a message from the user.
    /// </summary>
    public class MessageActionModel : ActionModel
    {
        /// <summary>
        /// [必填] 固定為 message
        /// </summary>
        public string type
        {
            get
            {
                return "message";
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
        public string label { get; set; }

        /// <summary>
        /// [必填] Text sent when the action is performed.
        ///        Max: 300 characters
        /// </summary>
        public string text { get; set; }
    }
}