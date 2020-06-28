using System.Collections.Generic;
using System.Runtime.Serialization;
using LineMessagingAPI.Models.Action;
using LineMessagingAPI.Models.Message.Flex.Unit;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Message.Flex.Component
{
    /// <summary>
    /// This component renders a text string in one row. You can specify font color, size, and weight.
    /// </summary>
    public class TextModel : FlexComponentModel
    {
        /// <summary>
        /// [Required] text
        /// </summary>
        public string type
        {
            get
            {
                return "text";
            }
        }

        /// <summary>
        /// [Required] Text Be sure to set either one of the text property or contents property.
        ///        If you set the contents property, text is ignored.
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// [Optional] Array of spans. Be sure to set either one of the text property or contents property.
        ///        If you set the contents property, text is ignored.
        /// </summary>
        public List<SpanModel> contents { get; set; }

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
        /// [Optional] Font size.
        ///        You can specify one of the following values: xxs, xs, sm, md, lg, xl, xxl, 3xl, 4xl, or 5xl.
        ///        The size increases in the order of listing.
        ///        The default value is md.
        /// </summary>
        public FlexFontSize? size { get; set; }

        /// <summary>
        /// [Optional] Alignment style in horizontal direction.
        /// </summary>
        public FlexAlign? align { get; set; }

        /// <summary>
        /// [Optional] Alignment style in vertical direction.
        /// </summary>
        public FlexGravity? gravity { get; set; }

        /// <summary>
        /// [Optional] true to wrap text. The default value is false.
        ///        If set to true, you can use a new line character (\n) to begin on a new line.
        /// </summary>
        public bool? wrap { get; set; }

        /// <summary>
        /// [Optional] Max number of lines. If the text does not fit in the specified number of lines, an ellipsis (…) is displayed at the end of the last line.
        ///        If set to 0, all the text is displayed. The default value is 0. This property is supported on the following versions of LINE.
        ///        LINE for iOS and Android: 8.11.0 and later
        /// </summary>
        public int? maxLines { get; set; }

        /// <summary>
        /// [Optional] Font weight. You can specify one of the following values: regular or bold.
        ///        Specifying bold makes the font bold. The default value is regular.
        /// </summary>
        public TextWeight? weight { get; set; }

        /// <summary>
        /// [Optional] Font color. Use a hexadecimal color code.
        /// </summary>
        public string color { get; set; }

        /// <summary>
        /// [Optional] Models.Action
        ///        Action performed when this image is tapped.
        /// </summary>
        public ActionModel action { get; set; }

        /// <summary>
        /// [Optional] Style of the text. Specify one of the following values:
        ///         * normal: Normal
        ///         * italic: Italic
        ///        The default value is normal.
        /// </summary>
        public TextStyle? style { get; set; }

        /// <summary>
        /// [Optional] Decoration of the text. Specify one of the following values:
        ///         * none: No decoration
        ///         * underline: Underline
        ///         * line-through: Strikethrough
        ///        The default value is none.
        /// </summary>
        public TextDecoration? decoration { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextWeight
    {
        [EnumMember(Value = "regular")]
        regular,
        [EnumMember(Value = "bold")]
        bold
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextStyle
    {
        [EnumMember(Value = "normal")]
        normal,
        [EnumMember(Value = "italic")]
        italic
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextDecoration
    {
        [EnumMember(Value = "none")]
        none,
        [EnumMember(Value = "underline")]
        underline,
        [EnumMember(Value = "line-through")]
        line_through
    }
}