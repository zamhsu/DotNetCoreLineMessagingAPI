namespace LineMessagingAPI.Models.Message.Imagemap
{
    public class ImagemapExternalLinkModel
    {
        /// <summary>
        /// Webpage URL. Called when the label displayed after the video is tapped.
        /// Max: 1000 characters
        /// The available schemes are http, https, line, and tel. For more information about the LINE URL scheme, see Using the LINE URL scheme.
        /// </summary>
        public string linkUri { get; set; }

        /// <summary>
        /// Label. Displayed after the video is finished.
        /// Max: 30 characters
        /// </summary>
        public string label { get; set; }
    }
}