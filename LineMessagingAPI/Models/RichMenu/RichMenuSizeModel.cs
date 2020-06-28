using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineChatBot.Models.RichMenu
{
    public class RichMenuSizeModel
    {
        public RichMenuSizeWidth width { get; set; }

        public RichMenuSizeHeight height { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RichMenuSizeWidth
    {
        [EnumMember(Value = 2500)]
        Full
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RichMenuSizeHeight
    {
        [EnumMember(Value = 1686)]
        Full,
        [EnumMember(Value = 843)]
        Half

    }
}