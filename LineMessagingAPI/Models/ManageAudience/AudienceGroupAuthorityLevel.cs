using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience
{
    /// <summary>
    /// The authority level for all audiences linked to a channel.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AudienceGroupAuthorityLevel
    {
        /// <summary>
        /// The default authority level. Audiences will be available in channels other than the one where you created the audience.
        /// For example, it will be available in LINE Official Account Manager, LINE Ad Manager, and all channels the bot is linked to.
        /// </summary>
        [EnumMember(Value = "PUBLIC")]
        PUBLIC,
        /// <summary>
        /// Audiences will be available only in the channel where you created the audience.
        /// </summary>
        [EnumMember(Value = "PRIVATE")]
        PRIVATE
    }
}
