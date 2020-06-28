using System.Collections.Generic;
using LineMessagingAPI.Models.Message.Flex.Container;

namespace LineMessagingAPI.Models.Message
{
    /// <summary>
    /// Flex Messages are messages with a customizable layout.
    /// You can customize the layout freely based on the specification for CSS Flexible Box (CSS Flexbox).
    /// </summary>
    public class FlexMessageModel : MessageModel
    {
        /// <summary>
        /// [必填] 固定為 flex
        /// </summary>
        public string type
        {
            get
            {
                return "flex";
            }
        }

        /// <summary>
        /// [必填] Alternative text
        ///        Max: 400 characters
        /// </summary>
        public string altText { get; set; }

        /// <summary>
        /// [必填] Models.Container
        ///        Flex Message container
        /// </summary>
        //public string contents { get; set; }
        public FlexContainerModel contents { get; set; }
    }

    /// <summary>
    /// Flex Messages are messages with a customizable layout.
    /// You can customize the layout freely based on the specification for CSS Flexible Box (CSS Flexbox).
    /// </summary>
    public class FlexMessageWithJsonModel : MessageModel
    {
        /// <summary>
        /// [必填] 固定為 flex
        /// </summary>
        public string type
        {
            get
            {
                return "flex";
            }
        }

        /// <summary>
        /// [必填] Alternative text
        ///        Max: 400 characters
        /// </summary>
        public string altText { get; set; }

        /// <summary>
        /// [必填] Models.Container
        ///        Flex Message container
        /// </summary>
        //public string contents { get; set; }
        public string contents { get; set; }
    }
}