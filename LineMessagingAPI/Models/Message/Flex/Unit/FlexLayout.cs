using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Message.Flex.Unit
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlexLayout
    {
        [EnumMember(Value = "horizontal")]
        horizontal,
        [EnumMember(Value = "vertical")]
        vertical,
        [EnumMember(Value = "baseline")]
        baseline
    }
}