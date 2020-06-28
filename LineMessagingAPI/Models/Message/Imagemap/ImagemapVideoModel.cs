namespace LineMessagingAPI.Models.Message.Imagemap
{
    /// <summary>
    /// Imagemap video object
    /// </summary>
    public class ImagemapVideoModel
    {
        /// <summary>
        /// URL of the video file (Max: 1000 characters)
        /// HTTPS over TLS 1.2 or later
        /// mp4
        /// Max: 1 minute
        /// Max: 10 MB
        /// Note: A very wide or tall video may be cropped when played in some environments.
        /// </summary>
        public string originalContentUrl { get; set; }

        /// <summary>
        /// URL of the preview image (Max: 1000 characters)
        /// HTTPS over TLS 1.2 or later
        /// JPEG
        /// Max: 240 x 240 pixels
        /// Max: 1 MB
        /// </summary>
        public string previewImageUrl { get; set; }

        /// <summary>
        /// Video area.
        /// </summary>
        public ImagemapAreaModel area { get; set; }

        /// <summary>
        /// External link.
        /// </summary>
        public ImagemapExternalLinkModel externalLink { get; set; }
    }
}