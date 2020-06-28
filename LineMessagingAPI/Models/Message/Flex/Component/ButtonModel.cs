using System.Runtime.Serialization;
using LineMessagingAPI.Models.Action;
using LineMessagingAPI.Models.Message.Flex.Unit;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Message.Flex.Component
{
    /// <summary>
    /// This component renders a button. When the user taps a button, a specified action is performed.
    /// </summary>
    public class ButtonModel : FlexComponentModel
    {
        /// <summary>
        /// [必填] 固定為 button
        /// </summary>
        public string type
        {
            get
            {
                return "button";
            }
        }

        /// <summary>
        /// [必填] Models.Action
        ///        Action performed when this button is tapped.
        /// </summary>
        public ActionModel action { get; set; }

        /// <summary>
        /// [選填] The ratio of the width or height of this component within the parent box.
        /// </summary>
        public int? flex { get; set; }

        /// <summary>
        /// [選填] Minimum space between this component and the previous component in the parent element.
        /// </summary>
        public FlexMarginSize? margin { get; set; }

        /// <summary>
        /// [選填] Reference for offsetTop, offsetBottom, offsetStart, and offsetEnd.
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
        /// [選填] Height of the button.
        /// </summary>
        public ButtonHeight? height { get; set; }

        /// <summary>
        /// [選填] Style of the button. Specify one of the following values:
        ///         * primary: Style for dark color buttons
        ///         * secondary: Style for light color buttons
        ///         * link: HTML link style
        ///        The default value is link.
        /// </summary>
        public ButtonStyle? style { get; set; }

        /// <summary>
        /// [選填] Character color when the style property is link.
        ///        Background color when the style property is primary or secondary.
        ///        Use a hexadecimal color code.
        /// </summary>
        public string color { get; set; }

        /// <summary>
        /// [選填] Alignment style in vertical direction.
        /// </summary>
        public FlexGravity? gravity { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ButtonStyle
    {
        [EnumMember(Value = "primary")]
        primary,
        [EnumMember(Value = "secondary")]
        secondary,
        [EnumMember(Value = "link")]
        link
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ButtonHeight
    {
        [EnumMember(Value = "md")]
        md,
        [EnumMember(Value = "sm")]
        sm
    }
}