using System.Collections.Generic;
using LineMessagingAPI.Models.Action;
using LineMessagingAPI.Models.Message.Flex.Unit;

namespace LineMessagingAPI.Models.Message.Flex.Component
{
    /// <summary>
    /// This is a component that defines the layout of child components. You can also include a box in a box.
    /// </summary>
    public class BoxModel : FlexComponentModel
    {
        /// <summary>
        /// [必填] 固定為 box
        /// </summary>
        public string type
        {
            get
            {
                return "box";
            }
        }

        /// <summary>
        /// [必填] The layout style of components in this box.
        /// </summary>
        public FlexLayout layout { get; set; }

        /// <summary>
        /// [必填] Models.Flex.Components
        ///        Components in this box. Here are the types of components available:
        ///        * When the layout property is horizontal or vertical: box, button, image, text, separator, filler, and spacer (not recommended)
        ///        * When the layout property is baseline: icon, text, filler, and spacer (not recommended)
        /// </summary>
        public List<FlexComponentModel> contents { get; set; }

        /// <summary>
        /// [選填] Background color of the block. Use a hexadecimal color code. (Example:#RRGGBBAA). The default value is #00000000.
        /// </summary>
        public string backgroundColor { get; set; }

        /// <summary>
        /// [選填] Color of box border. Use a hexadecimal color code.
        /// </summary>
        public string borderColor { get; set; }

        /// <summary>
        /// [選填] Width of box border.
        ///        You can specify a value in pixels or any one of none, light, normal, medium, semi-bold, or bold.
        ///        none does not render a border while the others become wider in the order of listing.
        /// </summary>
        public string borderWidth { get; set; }

        /// <summary>
        /// [選填] Radius at the time of rounding the corners of the border.
        ///        You can specify a value in pixels or any one of none, xs, sm, md, lg, xl, or xxl.
        ///        none does not round the corner while the others increase in radius in the order of listing.
        ///        The default value is none.
        /// </summary>
        public string cornerRadius { get; set; }

        /// <summary>
        /// [選填] Width of the box.
        /// </summary>
        public string width { get; set; }

        /// <summary>
        /// [選填] Height of the box.
        /// </summary>
        public string height { get; set; }

        /// <summary>
        /// [選填] The ratio of the width or height of this component within the parent box.
        /// </summary>
        public int? flex { get; set; }

        /// <summary>
        /// [選填] Minimum space between components in this box. The default value is none.
        /// </summary>
        public FlexMarginSize? spacing { get; set; }

        /// <summary>
        /// [選填] Minimum space between this component and the previous component in the parent element.
        /// </summary>
        public FlexMarginSize? margin { get; set; }

        /// <summary>
        /// [選填] Free space between the borders of this box and the child element.
        /// </summary>
        public string paddingAll { get; set; }

        /// <summary>
        /// [選填] Free space between the border at the upper end of this box and the upper end of the child element.
        /// </summary>
        public string paddingTop { get; set; }

        /// <summary>
        /// [選填] Free space between the border at the lower end of this box and the lower end of the child element.
        /// </summary>
        public string paddingBottom { get; set; }

        /// <summary>
        /// [選填] Free space between the border at the left end of this box and the left end of the child element.
        /// </summary>
        public string paddingStart { get; set; }

        /// <summary>
        /// [選填] Free space between the border at the right end of this box and the right end of the child element.
        /// </summary>
        public string paddingEnd { get; set; }

        /// <summary>
        /// [選填] Reference position for placing this box.
        ///        Specify one of the following values:
        ///        * relative: Use the previous box as reference.
        ///        * absolute: Use the top left of parent element as reference.
        ///        The default value is relative.
        /// </summary>
        public FlexPosition? position { get; set; }

        /// <summary>
        /// [選填] The top offset. 
        /// </summary>
        public string offsetTop { get; set; }

        /// <summary>
        /// [選填] The bottom offset.
        /// </summary>
        public string offsetBottom { get; set; }

        /// <summary>
        /// [選填] The left offset.
        /// </summary>
        public string offsetStart { get; set; }

        /// <summary>
        /// [選填] The right offset.
        /// </summary>
        public string offsetEnd { get; set; }

        /// <summary>
        /// [選填] Models.Action
        ///        Action performed when this image is tapped. Specify an action object. This property is supported on the following versions of LINE.
        ///        LINE for iOS and Android: 8.11.0 and later
        /// </summary>
        public ActionModel action { get; set; }
    }
}