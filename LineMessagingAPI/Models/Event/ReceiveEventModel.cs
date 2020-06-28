using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Event
{
    /// <summary>
    /// 接收到的Event
    /// </summary>
    public class ReceiveEventModel
    {
        public List<EventModel> events { get; set; }
    }

    /// <summary>
    /// Event訊息
    /// </summary>
    public class EventModel
    {
        public string replyToken { get; set; }
        public EventType type { get; set; }
        public string timestamp { get; set; }
        public Source source { get; set; }
        public ReceiveMessage message { get; set; }
    }

    /// <summary>
    /// 接收到的訊息
    /// </summary>
    public class ReceiveMessage : Message<MessageType>
    {

    }

    public abstract class Message<T>
    {
        public string id { get; set; }
        public T type { get; set; }
        public string text { get; set; }
        public ContentProvider contentProvider { get; set; }
        public int duration { get; set; }
        public string fileNmae { get; set; }
        public int fileSize { get; set; }
        public string title { get; set; }
        public string address { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public string packageId { get; set; }
        public string stickerId { get; set; }
    }

    /// <summary>
    /// 訊息來源
    /// </summary>
    public class Source
    {
        public SourceType type { get; set; }
        public string userId { get; set; }
        public string groupId { get; set; }
        public string roomId { get; set; }
    }

    public class ContentProvider
    {
        public ContentProviderType type { get; set; }
        public string originalContentUrl { get; set; }
        public string previewImageUrl { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContentProviderType
    {
        [EnumMember(Value = "line")]
        line,
        [EnumMember(Value = "external")]
        external
    }

    /// <summary>
    /// 訊息類型
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessageType
    {
        [EnumMember(Value = "text")]
        text,
        [EnumMember(Value = "image")]
        image,
        [EnumMember(Value = "video")]
        video,
        [EnumMember(Value = "audio")]
        audio,
        [EnumMember(Value = "file")]
        file,
        [EnumMember(Value = "location")]
        location,
        [EnumMember(Value = "sticker")]
        sticker
    }

    /// <summary>
    /// 訊息來源類型
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SourceType
    {
        [EnumMember(Value = "user")]
        user,
        [EnumMember(Value = "group")]
        group,
        [EnumMember(Value = "room")]
        room
    }

    /// <summary>
    /// Event 類型
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventType
    {
        [EnumMember(Value = "message")]
        message,
        [EnumMember(Value = "follow")]
        follow,
        [EnumMember(Value = "unfollow")]
        unfollow,
        [EnumMember(Value = "join")]
        join,
        [EnumMember(Value = "leave")]
        leave,
        [EnumMember(Value = "memberJoined")]
        memberJoined,
        [EnumMember(Value = "memberLeft")]
        memberLeft,
        [EnumMember(Value = "postback")]
        postback,
        [EnumMember(Value = "beacon")]
        beacon,
        [EnumMember(Value = "accountLink")]
        accountLink,
        [EnumMember(Value = "things")]
        things
    }
}