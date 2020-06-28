using System;
using System.Runtime.Serialization;
using LineMessagingAPI.Models.Message.Flex.Unit;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Message.Flex.Component
{
    /// <summary>
    /// This component renders an icon for decorating the adjacent text.
    /// This component can be used only in a baseline box.
    /// </summary>
    public class IconModel : FlexComponentModel
    {
        /// <summary>
        /// [Required] icon
        /// </summary>
        public string type
        {
            get
            {
                return "icon";
            }
        }

        /// <summary>
        /// [Required] Image URL
        ///        Protocol: HTTPS
        ///        Image format: JPEG or PNG
        ///        Maximum image size: 1024×1024 pixels
        ///        Maximum data size: 1 MB
        /// </summary>
        public string url { get; set; }
        //public Uri url { get; set; }

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
        /// [Optional] Maximum size of the icon width.
        ///        You can specify one of the following values: xxs, xs, sm, md, lg, xl, xxl, 3xl, 4xl, or 5xl.
        ///        The size increases in the order of listing.
        ///        The default value is md.
        /// </summary>
        public FlexFontSize? size { get; set; }

        /// <summary>
        /// [Optional] Aspect ratio of the icon.
        ///        {width}:{height} format.
        ///        Specify the value of {width} and {height} in the range from 1 to 100000.
        ///        However, you cannot set {height} to a value that is more than three times the value of {width}.
        ///        The default value is 1:1.
        /// </summary>
        public IconAspectRatio? aspectRatio { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IconAspectRatio
    {
        [EnumMember(Value = "1:1")]
        R1To1,
        [EnumMember(Value = "2:1")]
        R2To1,
        [EnumMember(Value = "3:1")]
        R3To1
    }
}