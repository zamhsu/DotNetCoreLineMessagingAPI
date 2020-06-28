using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Message.Flex.Unit
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlexGravity
    {
        [EnumMember(Value = "top")]
        top,
        [EnumMember(Value = "bottom")]
        bottom,
        [EnumMember(Value = "center")]
        center
    }
}