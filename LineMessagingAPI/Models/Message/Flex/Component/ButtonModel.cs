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
        /// [Required] button
        /// </summary>
        public string type
        {
            get
            {
                return "button";
            }
        }

        /// <summary>
        /// [Required] Models.Action
        ///        Action performed when this button is tapped.
        /// </summary>
        public ActionModel action { get; set; }

        /// <summary>
        /// [Optional] The ratio of the width or height of this component within the parent box.
        /// </summary>
        public int? flex { get; set; }

        /// <summary>
        /// [Optional] Minimum space between this component and the previous component in the parent element.
        /// </summary>
        public FlexMarginSize? margin { get; set; }

        /// <summary>
        /// [Optional] Reference for offsetTop, offsetBottom, offsetStart, and offsetEnd.
        ///        Specify one of the following values:
        ///        * relative: Use the previous box as reference.
        ///        * absolute: Use the top left of parent element as reference.
        ///        The default value is relative.
        /// </summary>
        public FlexPosition? position { get; set; }

        /// <summary>
        /// [Optional] The top offset. 
        /// </summary>
        public string offsetTop { get; set; }

        /// <summary>
        /// [Optional] The bottom offset.
        /// </summary>
        public string offsetBottom { get; set; }

        /// <summary>
        /// [Optional] The left offset.
        /// </summary>
        public string offsetStart { get; set; }

        /// <summary>
        /// [Optional] The right offset.
        /// </summary>
        public string offsetEnd { get; set; }

        /// <summary>
        /// [Optional] Height of the button.
        /// </summary>
        public ButtonHeight? height { get; set; }

        /// <summary>
        /// [Optional] Style of the button. Specify one of the following values:
        ///         * primary: Style for dark color buttons
        ///         * secondary: Style for light color buttons
        ///         * link: HTML link style
        ///        The default value is link.
        /// </summary>
        public ButtonStyle? style { get; set; }

        /// <summary>
        /// [Optional] Character color when the style property is link.
        ///        Background color when the style property is primary or secondary.
        ///        Use a hexadecimal color code.
        /// </summary>
        public string color { get; set; }

        /// <summary>
        /// [Optional] Alignment style in vertical direction.
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