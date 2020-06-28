using LineMessagingAPI.Models.Action;

namespace LineMessagingAPI.Models.Message.Template
{
    public class ImageCarouselColumnModel
    {
        /// <summary>
        /// Image URL (Max: 1000 characters)
        /// HTTPS over TLS 1.2 or later
        /// JPEG or PNG
        /// Aspect ratio: 1:1
        /// Max width: 1024px
        /// Max: 1 MB
        /// </summary>
        public string imageUrl { get; set; }

        /// <summary>
        /// Action when image is tapped
        /// </summary>
        public ActionModel action { get; set; }
    }
}