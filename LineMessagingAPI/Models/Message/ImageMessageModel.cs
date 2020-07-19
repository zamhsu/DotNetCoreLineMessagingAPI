namespace LineMessagingAPI.Models.Message
{
    /// <summary>
    /// Send image message
    /// </summary>
    public class ImageMessageModel : MessageModel
    {
        /// <summary>
        /// [Required] image
        /// </summary>
        public string type
        {
            get
            {
                return "image";
            }
        }

        /// <summary>
        /// [Required] Image URL (Max: 1000 characters)
        /// HTTPS over TLS 1.2 or later
        /// JPEG
        /// Max: 4096 x 4096
        /// Max: 1 MB
        /// </summary>
        public string originalContentUrl { get; set; }

        /// <summary>
        /// [Required] Preview image URL (Max: 1000 characters)
        /// HTTPS over TLS 1.2 or later
        /// JPEG
        /// Max: 240 x 240
        /// Max: 1 MB
        /// </summary>
        public string previewImageUrl { get; set; }
    }
}