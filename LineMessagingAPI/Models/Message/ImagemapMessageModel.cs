using System.Collections.Generic;
using LineMessagingAPI.Models.Message.Imagemap;
using LineMessagingAPI.Models.Message.Imagemap.Action;

namespace LineMessagingAPI.Models.Message
{
    /// <summary>
    /// Imagemap messages are messages configured with an image that has multiple tappable areas.
    /// You can assign one tappable area for the entire image or different tappable areas on divided areas of the image.
    /// You can also play a video on the image and display a label with a hyperlink after the video is finished.
    /// </summary>
    public class ImagemapMessageModel : MessageModel
    {
        /// <summary>
        /// [必填] 固定為 imagemap
        /// </summary>
        public string type
        {
            get
            {
                return "imagemap";
            }
        }

        /// <summary>
        /// [必填] Base URL of the image
        /// Max: 1000 characters
        /// HTTPS over TLS 1.2 or later
        /// For more information about supported images in imagemap messages, see How to configure an image.
        /// </summary>
        public string baseUrl { get; set; }

        /// <summary>
        /// [必填] Alternative text
        /// Max: 400 characters
        /// </summary>
        public string altText { get; set; }

        /// <summary>
        /// [必填] ImagemapBaseSizeModel
        /// </summary>
        public ImagemapBaseSizeModel baseSize { get; set; }

        /// <summary>
        /// video.area is required if you set a video to play on the imagemap.
        /// video.externalLink is required if you set a video to play and a label to display after the video on the imagemap.
        /// </summary>
        public ImagemapVideoModel video { get; set; }

        /// <summary>
        /// [必填] Action when tapped
        /// Max: 50
        /// </summary>
        public List<ImagemapActionModel> actions { get; set; }
    }
}