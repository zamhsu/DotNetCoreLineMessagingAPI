using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Message.Flex.Unit
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlexAlign
    {
        [EnumMember(Value = "start")]
        start,
        [EnumMember(Value = "end")]
        end,
        [EnumMember(Value = "center")]
        center
    }
}