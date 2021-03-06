using System.Collections.Generic;

namespace LineMessagingAPI.Models.Message.Flex.Container
{
    /// <summary>
    /// A carousel is a container that contains multiple bubbles as child elements. Users can scroll horizontally through the bubbles.
    /// The maximum size of JSON data that defines a carousel is 50 KB.
    /// </summary>
    public class CarouselModel : FlexContainerModel
    {
        /// <summary>
        /// [Required] carousel
        /// </summary>
        public string type
        {
            get
            {
                return "carousel";
            }
        }

        /// <summary>
        /// [Required] Bubbles in the carousel. Max: 10 bubbles
        /// </summary>
        public List<BubbleModel> contents { get; set; }
    }
}