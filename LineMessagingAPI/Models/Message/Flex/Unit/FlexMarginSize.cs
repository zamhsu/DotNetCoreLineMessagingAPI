using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Message.Flex.Unit
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlexMarginSize
    {
        [EnumMember(Value = "none")]
        none,
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
        xxl
    }
}