using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Message.Flex.Unit
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlexDirection
    {
        [EnumMember(Value = "ltr")]
        ltr,
        [EnumMember(Value = "rtl")]
        rtl
    }
}