using System.Runtime.Serialization;
using LineMessagingAPI.Models.Action;
using LineMessagingAPI.Models.Message.Flex.Component;
using LineMessagingAPI.Models.Message.Flex.Unit;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Message.Flex.Container
{
    /// <summary>
    /// This is a container that contains one message bubble. It can contain four blocks: header, hero, body, and footer. For more information about using each block, see Block in the API documentation.
    /// The maximum size of JSON data that defines a bubble is 10 KB.
    /// </summary>
    public class BubbleModel : FlexContainerModel
    {
        /// <summary>
        /// [Required] bubble
        /// </summary>
        public string type
        {
            get
            {
                return "bubble";
            }
        }

        /// <summary>
        /// [Optional] The size of the bubble. You can specify one of the following values: nano, micro, kilo, mega, or giga. The default value is mega.
        /// </summary>
        public BubbleSize? size { get; set; }

        /// <summary>
        /// [Optional] Text directionality and the direction of placement of components in horizontal boxes. Specify one of the following values:
        ///         * ltr: The text is left-to-right horizontal writing, and the components are placed from left to right
        ///         * rtl: The text is right-to-left horizontal writing, and the components are placed from right to left
        ///        The default value is ltr.
        /// </summary>
        public FlexDirection? direction { get; set; }

        /// <summary>
        /// [Optional] Header block. Specify a Box.
        /// </summary>
        public BoxModel header { get; set; }

        /// <summary>
        /// [Optional] Model.Flex.Component(BoxModel / ImageModel) 
        ///        Hero block. Specify a box or an image.
        /// </summary>
        public FlexComponentModel hero { get; set; }

        /// <summary>
        /// [Optional] Body block. Specify a Box.
        /// </summary>
        public BoxModel body { get; set; }

        /// <summary>
        /// [Optional] Footer block. Specify a Box.
        /// </summary>
        public BoxModel footer { get; set; }

        /// <summary>
        /// [Optional] Style of each block. Specify a bubble style.
        /// </summary>
        public BubbleStyleModel styles { get; set; }

        /// <summary>
        /// [Optional] Model.Action
        ///        Action performed when this image is tapped. Specify an action object. This property is supported on the following versions of LINE.
        ///        LINE for iOS and Android: 8.11.0 and later
        /// </summary>
        public ActionModel action { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BubbleSize
    {
        [EnumMember(Value = "mega")]
        mega,
        [EnumMember(Value = "nano")]
        nano,
        [EnumMember(Value = "micro")]
        micro,
        [EnumMember(Value = "kilo")]
        kilo,
        [EnumMember(Value = "giga")]
        giga
    }
}