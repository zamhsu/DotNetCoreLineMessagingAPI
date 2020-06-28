using System.Collections.Generic;

namespace LineMessagingAPI.Models.Message.Template
{
    /// <summary>
    /// Template with multiple columns which can be cycled like a carousel. The columns will be shown in order by scrolling horizontally.
    /// </summary>
    public class CarouselTemplate : TemplateModel
    {
        /// <summary>
        /// [必填] 固定為 carousel
        /// </summary>
        public string type
        {
            get
            {
                return "carousel";
            }
        }

        /// <summary>
        /// [必填] Array of columns
        /// Max: 10
        /// </summary>
        public List<CarouselColumnModel> columns { get; set; }

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
    }
}