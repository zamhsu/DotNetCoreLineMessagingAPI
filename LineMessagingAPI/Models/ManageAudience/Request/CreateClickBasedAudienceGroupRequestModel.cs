using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience.Request
{
    /// <summary>
    /// Creates an audience for click-based retargeting request model.
    /// </summary>
    public class CreateClickBasedAudienceGroupRequestModel
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

        /// <summary>
        /// [Optional] The URL clicked by the user. If empty, users who clicked any URL in the message are added to the list of recipients.
        /// Max character limit: 2,000
        /// </summary>
        public string clickUrl { get; set; }
    }
}
