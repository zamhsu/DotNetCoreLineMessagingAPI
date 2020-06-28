using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineChatBot.Models.RichMenu
{
    /// <summary>
    /// Rich menu size object
    /// </summary>
    public class RichMenuSizeModel
    {
        /// <summary>
        /// [Required] Width of the rich menu. Must be 2500.
        /// </summary>
        public RichMenuSizeWidth width { get; set; }

        /// <summary>
        /// [Required] Height of the rich menu. Possible values: 1686, 843.
        /// </summary>
        public RichMenuSizeHeight height { get; set; }
    }

    /// <summary>
    /// Rich menu size width object
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RichMenuSizeWidth
    {
        /// <summary>
        /// 2500.
        /// </summary>
        [EnumMember(Value = "2500")]
        Full
    }

    /// <summary>
    /// Rich menu size height object
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RichMenuSizeHeight
    {
        /// <summary>
        /// 1686
        /// </summary>
        [EnumMember(Value = "1686")]
        Full,
        /// <summary>
        /// 843
        /// </summary>
        [EnumMember(Value = "843")]
        Half

    }
}