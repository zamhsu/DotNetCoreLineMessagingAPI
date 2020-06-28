namespace LineMessagingAPI.Models.Action
{
    /// <summary>
    /// When a control associated with this action is tapped, the URI specified in the uri property is opened.
    /// </summary>
    public class URIActionModel : ActionModel
    {
        /// <summary>
        /// [Required] uri
        /// </summary>
        public string type
        {
            get
            {
                return "uri";
            }
        }

        /// <summary>
        /// Label for the action
        ///  * Required for templates other than image carousel. Max: 20 characters.
        ///  * Optional for image carousel templates. Max: 12 characters.
        ///  * Optional for rich menus. Spoken when the accessibility feature is enabled on the client device. Max: 20 characters. Supported on LINE 8.2.0 and later for iOS.
        ///  * Required for the button of Flex Message. This property can be specified for the box, image, and text but its value is not displayed. Max: 20 characters.
        /// </summary>
        public string label { get; set; }

        /// <summary>
        /// [Required] URI opened when the action is performed (Max: 1000 characters)
        ///            The available schemes are http, https, line, and tel.
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// [Optional] URI opened on LINE for macOS and Windows when the action is performed (Max: 1000 characters)
        ///            If the altUri.desktop property is set, the uri property is ignored on LINE for macOS and Windows.
        ///            The available schemes are http, https, line, and tel. For more information about the LINE URL scheme, see Using the LINE URL scheme. This property is supported on the following version of LINE.
        ///            LINE 5.12.0 or later for macOS and Windows
        ///            Note: The altUri.desktop property is supported only when you set URI actions in Flex Messages.
        /// </summary>
        public AltUri altUri { get; set; }
    }

    /// <summary>
    /// URI opened on LINE for macOS and Windows when the action is performed (Max character limit: 1000)
    /// </summary>
    public class AltUri
    {
        /// <summary>
        /// The available schemes are http, https, line, and tel.
        /// For more information about the LINE URL scheme, see Using LINE features with the LINE URL scheme.
        /// (https://developers.line.biz/zh-hant/docs/messaging-api/using-line-url-scheme/)
        /// </summary>
        public string desktop { get; set; }
    }
}