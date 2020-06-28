using System.Collections.Generic;
using LineMessagingAPI.Models.Action;

namespace LineMessagingAPI.Models.Message.Template
{
    public class CarouselColumnModel
    {
        /// <summary>
        /// [選填] Image URL (Max: 1000 characters)
        /// HTTPS over TLS 1.2 or later
        /// JPEG or PNG
        /// Aspect ratio: 1:1.51
        /// Max width: 1024px
        /// Max: 1 MB
        /// </summary>
        public string thumbnailImageUrl { get; set; }

        /// <summary>
        /// [選填] Background color of image. Specify a RGB color value. The default value is #FFFFFF (white).
        /// </summary>
        public string imageBackgroundColor { get; set; }

        /// <summary>
        /// [選填] Title
        /// Max: 40 characters
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// [必填] Message text
        /// Max: 120 characters (no image or title)
        /// Max: 60 characters (message with an image or title)
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// [選填] Action when image is tapped; set for the entire image, title, and text area
        /// </summary>
        public ActionModel defaultAction { get; set; }

        /// <summary>
        /// [必填] Action when tapped
        /// Max: 3
        /// </summary>
        public List<ActionModel> actions { get; set; }
    }
}