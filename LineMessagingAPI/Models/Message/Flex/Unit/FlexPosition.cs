using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Message.Flex.Unit
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlexPosition
    {
        [EnumMember(Value = "relative")]
        relative,
        [EnumMember(Value = "absolute")]
        absolute
    }
}