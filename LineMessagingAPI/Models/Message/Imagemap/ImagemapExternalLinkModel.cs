namespace LineMessagingAPI.Models.Message.Imagemap
{
    /// <summary>
    /// Imagemap video external link object
    /// </summary>
    public class ImagemapExternalLinkModel
    {
        /// <summary>
        /// Webpage URL. Called when the label displayed after the video is tapped.
        /// Max character limit: 1000
        /// The available schemes are http, https, line, and tel.
        /// For more information about the LINE URL scheme, see Using LINE features with the LINE URL scheme.
        /// (https://developers.line.biz/zh-hant/docs/messaging-api/using-line-url-scheme/)
        /// </summary>
        public string linkUri { get; set; }

        /// <summary>
        /// Label. Displayed after the video is finished.
        /// Max: 30 characters
        /// </summary>
        public string label { get; set; }
    }
}