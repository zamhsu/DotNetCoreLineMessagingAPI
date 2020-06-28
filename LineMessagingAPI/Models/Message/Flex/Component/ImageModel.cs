using System;
using System.Runtime.Serialization;
using LineMessagingAPI.Models.Action;
using LineMessagingAPI.Models.Message.Flex.Unit;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Message.Flex.Component
{
    /// <summary>
    /// This component renders an image.
    /// </summary>
    public class ImageModel : FlexComponentModel
    {
        /// <summary>
        /// [Required] image
        /// </summary>
        public string type
        {
            get
            {
                return "image";
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
        /// [Optional] Alignment style in horizontal direction.
        /// </summary>
        public FlexAlign? align { get; set; }

        /// <summary>
        /// [Optional] Alignment style in vertical direction.
        /// </summary>
        public FlexGravity? gravity { get; set; }

        /// <summary>
        /// [Optional] Maximum size of the image width.
        ///        You can specify one of the following values: xxs, xs, sm, md, lg, xl, xxl, 3xl, 4xl, 5xl, or full.
        ///        The size increases in the order of listing.
        ///        The default value is md.
        /// </summary>
        public ImageSize? size { get; set; }

        /// <summary>
        /// [Optional] Aspect ratio of the image.
        ///        {width}:{height} format.
        ///        Specify the value of {width} and {height} in the range from 1 to 100000.
        ///        However, you cannot set {height} to a value that is more than three times the value of {width}.
        ///        The default value is 1:1.
        /// </summary>
        public ImageAspectRatio? aspectRatio { get; set; }

        /// <summary>
        /// [Optional] The display style of the image if the aspect ratio of the image and that specified by the aspectRatio property do not match.
        /// </summary>
        public ImageAspectMode? aspectMode { get; set; }

        /// <summary>
        /// [Optional] Background color of the block. Use a hexadecimal color code. (Example:#RRGGBBAA).
        /// </summary>
        public string backgroundColor { get; set; }

        /// <summary>
        /// [Optional] Models.Action
        ///        Action performed when this image is tapped. Specify an action object. This property is supported on the following versions of LINE.
        ///        LINE for iOS and Android: 8.11.0 and later
        /// </summary>
        public ActionModel action { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImageSize
    {
        [EnumMember(Value = "xxs")]
        xxs,
        [EnumMember(Value = "xs")]
        xs,
        [EnumMember(Value = "sm")]
        sm,
        [EnumMember(Value = "md")]
        md,
        [EnumMember(Value = "lg")]
        lg,
        [EnumMember(Value = "xl")]
        xl,
        [EnumMember(Value = "xxl")]
        xxl,
        [EnumMember(Value = "3xl")]
        xxxl,
        [EnumMember(Value = "4xl")]
        xxxxl,
        [EnumMember(Value = "5xl")]
        xxxxxl,
        [EnumMember(Value = "full")]
        full
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImageAspectRatio
    {
        [EnumMember(Value = "1:1")]
        R1To1,
        [EnumMember(Value = "20:13")]
        R20To13,
        [EnumMember(Value = "1.91:1")]
        R1_91To1,
        [EnumMember(Value = "4:3")]
        R4To3,
        [EnumMember(Value = "16:9")]
        R16To9,
        [EnumMember(Value = "2:1")]
        R2To1,
        [EnumMember(Value = "2:3")]
        R2To3,
        [EnumMember(Value = "3:1")]
        R3To1,
        [EnumMember(Value = "3:4")]
        R3To4,
        [EnumMember(Value = "9:16")]
        R9To16,
        [EnumMember(Value = "1:2")]
        R1To2,
        [EnumMember(Value = "1:3")]
        R1To3,
        [EnumMember(Value = "1.51:1")]
        R1_51To1
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImageAspectMode
    {
        [EnumMember(Value = "fit")]
        fit,
        [EnumMember(Value = "cover")]
        cover
    }
}