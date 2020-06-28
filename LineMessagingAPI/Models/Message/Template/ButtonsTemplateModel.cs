using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using LineMessagingAPI.Models.Action;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Message.Template
{
    /// <summary>
    /// Template with an image, title, text, and multiple action buttons.
    /// </summary>
    public class ButtonsTemplateModel : TemplateModel
    {
        /// <summary>
        /// [必填] 固定為 buttons
        /// </summary>
        public string type
        {
            get
            {
                return "buttons";
            }
        }

        /// <summary>
        /// [選填] Image URL (Max: 1000 characters)
        /// HTTPS over TLS 1.2 or later
        /// JPEG or PNG
        /// Max width: 1024px
        /// Max: 1 MB
        /// </summary>
        public string thumbnailImageUrl { get; set; }

        /// <summary>
        /// [選填] Aspect ratio of the image. Specify one of the following values:
        /// rectangle: 1.51:1
        /// square: 1:1
        /// The default value is rectangle.
        /// </summary>
        public TemplateImageAspectRatio imageAspectRatio { get; set; }

        /// <summary>
        /// [選填] Size of the image. Specify one of the following values:
        /// cover: The image fills the entire image area. Parts of the image that do not fit in the area are not displayed.
        /// contain: The entire image is displayed in the image area. A background is displayed in the unused areas to the left and right of vertical images and in the areas above and below horizontal images.
        /// The default value is cover.
        /// </summary>
        public TemplateImageSize imageSize { get; set; }

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
        /// Max: 160 characters (no image or title)
        /// Max: 60 characters (message with an image or title)
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// [選填] Action when image is tapped; set for the entire image, title, and text area
        /// </summary>
        public ActionModel defaultAction { get; set; }

        /// <summary>
        /// [選填] Action when tapped
        /// Max: 4
        /// </summary>
        public List<ActionModel> actions { get; set; }
    }
}