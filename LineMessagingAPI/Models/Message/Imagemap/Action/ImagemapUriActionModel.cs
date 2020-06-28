namespace LineMessagingAPI.Models.Message.Imagemap.Action
{
    /// <summary>
    /// Object which specifies the actions and tappable areas of an imagemap.
    /// When an area is tapped, the user is redirected to the URI specified in uri and the message specified in message is sent.
    /// </summary>
    public class ImagemapUriActionModel : ImagemapActionModel
    {
        /// <summary>
        /// [必填] 固定為 uri
        /// </summary>
        public string type
        {
            get
            {
                return "uri";
            }
        }

        /// <summary>
        /// [選填] Label for the action. Spoken when the accessibility feature is enabled on the client device.
        /// Max: 50 characters
        /// Supported on LINE 8.2.0 and later for iOS.
        /// </summary>
        public string label { get; set; }

        /// <summary>
        /// [必填] Webpage URL
        /// Max: 1000 characters
        /// The available schemes are http, https, line, and tel. For more information about the LINE URL scheme, see Using the LINE URL scheme.
        /// </summary>
        public string linkUri { get; set; }

        /// <summary>
        /// [必填] Defined tappable area
        /// </summary>
        public ImagemapAreaModel area { get; set; }
    }
}