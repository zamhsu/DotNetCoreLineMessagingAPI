using LineMessagingAPI.Models.Message.Flex.Unit;

namespace LineMessagingAPI.Models.Message.Flex.Component
{
    /// <summary>
    /// This component renders multiple text strings with different designs in one row.
    /// You can specify the color, size, weight, and decoration for the font.
    /// Span is set to contents property in Text.
    /// </summary>
    public class SpanModel : FlexComponentModel
    {
        /// <summary>
        /// [Required] span
        /// </summary>
        public string type
        {
            get
            {
                return "span";
            }
        }

        /// <summary>
        /// [Required] Text. If the wrap property of the parent text is set to true, you can use a new line character (\n) to begin on a new line.
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// [Optional] Font color. Use a hexadecimal color code.
        /// </summary>
        public string color { get; set; }

        /// <summary>
        /// [Optional] Font size.
        ///        You can specify one of the following values: xxs, xs, sm, md, lg, xl, xxl, 3xl, 4xl, or 5xl.
        ///        The size increases in the order of listing.
        ///        The default value is md.
        /// </summary>
        public FlexFontSize? size { get; set; }

        /// <summary>
        /// [Optional] Font weight. You can specify one of the following values: regular or bold.
        ///        Specifying bold makes the font bold. The default value is regular.
        /// </summary>
        public TextWeight? weight { get; set; }

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
}