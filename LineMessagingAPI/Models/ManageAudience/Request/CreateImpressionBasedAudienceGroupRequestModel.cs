using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience.Request
{
    /// <summary>
    /// Creates an audience for impression-based retargeting request model
    /// </summary>
    public class CreateImpressionBasedAudienceGroupRequestModel
    {
        /// <summary>
        /// [Required] The audience's name. Audience names must be unique.
        /// This is case-insensitive, meaning AUDIENCE and audience are considered identical.
        /// Max character limit: 120
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// [Required] The request ID of a broadcast or narrowcast message sent in the past 60 days.
        /// Each Messaging API request has a request ID.
        /// Find it in the response headers.
        /// https://developers.line.biz/zh-hant/reference/messaging-api/#response-headers
        /// </summary>
        public string requestId { get; set; }
    }
}
