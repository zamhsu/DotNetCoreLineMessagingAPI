using LineMessagingAPI.Models.Message.Flex.Unit;

namespace LineMessagingAPI.Models.Message.Flex.Component
{
    /// <summary>
    /// This component renders a separating line within a box.
    /// A vertical line will be rendered in a horizontal box and a horizontal line will be rendered in a vertical box.
    /// </summary>
    public class SeparatorModel : FlexComponentModel
    {
        /// <summary>
        /// [必填] 固定為 separator
        /// </summary>
        public string type
        {
            get
            {
                return "separator";
            }
        }

        /// <summary>
        /// [選填] Minimum space between this component and the previous component in the parent element.
        /// </summary>
        public FlexMarginSize? margin { get; set; }

        /// <summary>
        /// [選填] Font color. Use a hexadecimal color code.
        /// </summary>
        public string color { get; set; }
    }
}