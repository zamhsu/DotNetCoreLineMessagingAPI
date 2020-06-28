using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Message.Template
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TemplateImageSize
    {
        [EnumMember(Value = "cover")]
        cover,
        [EnumMember(Value = "contain")]
        contain
    }
}