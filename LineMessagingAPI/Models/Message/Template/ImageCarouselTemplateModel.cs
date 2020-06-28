using System.Collections.Generic;

namespace LineMessagingAPI.Models.Message.Template
{
    /// <summary>
    /// Template with multiple images which can be cycled like a carousel. The images will be shown in order by scrolling horizontally.
    /// </summary>
    public class ImageCarouselTemplateModel : TemplateModel
    {
        /// <summary>
        /// [必填] 固定為 image_carousel
        /// </summary>
        public string type
        {
            get
            {
                return "image_carousel";
            }
        }

        /// <summary>
        /// [必填] Array of columns
        /// Max: 10
        /// </summary>
        public List<ImageCarouselColumnModel> columns { get; set; }
    }
}