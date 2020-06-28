namespace LineMessagingAPI.Models.Message
{
    public class ImageMessageModel : MessageModel
    {
        /// <summary>
        /// [必填] 固定為 image
        /// </summary>
        public string type
        {
            get
            {
                return "image";
            }
        }

        /// <summary>
        /// [必填] Image URL (Max: 1000 characters)
        /// HTTPS over TLS 1.2 or later
        /// JPEG
        /// Max: 4096 x 4096
        /// Max: 1 MB
        /// </summary>
        public string originalContentUrl { get; set; }

        /// <summary>
        /// [必填] Preview image URL (Max: 1000 characters)
        /// HTTPS over TLS 1.2 or later
        /// JPEG
        /// Max: 240 x 240
        /// Max: 1 MB
        /// </summary>
        public string previewImageUrl { get; set; }
    }
}