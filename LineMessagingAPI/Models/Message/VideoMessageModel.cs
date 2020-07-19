namespace LineMessagingAPI.Models.Message
{
    /// <summary>
    /// Send video message
    /// </summary>
    public class VideoMessageModel : MessageModel
    {
        /// <summary>
        /// [Required] video
        /// </summary>
        public string type
        {
            get
            {
                return "video";
            }
        }

        /// <summary>
        /// [Required] URL of video file (Max: 1000 characters)
        /// HTTPS over TLS 1.2 or later
        /// mp4
        /// Max: 1 minute
        /// Max: 10 MB
        /// A very wide or tall video may be cropped when played in some environments.
        /// </summary>
        public string originalContentUrl { get; set; }

        /// <summary>
        /// [Required] URL of preview image (Max: 1000 characters)
        /// HTTPS over TLS 1.2 or later
        /// JPEG
        /// Max: 240 x 240
        /// Max: 1 MB
        /// </summary>
        public string previewImageUrl { get; set; }
    }
}