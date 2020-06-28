using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Message.Flex.Unit
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FlexFontSize
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
        xxxxxl
    }
}