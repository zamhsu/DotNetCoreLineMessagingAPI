using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Message.Template
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TemplateImageAspectRatio
    {
        [EnumMember(Value = "rectangle")]
        rectangle,
        [EnumMember(Value = "square")]
        square
    }
}