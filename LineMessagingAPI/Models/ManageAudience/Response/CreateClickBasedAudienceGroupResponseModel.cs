using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience.Response
{
    /// <summary>
    /// Creates an audience for click-based retargeting response model.
    /// </summary>
    public class CreateClickBasedAudienceGroupResponseModel
    {
        /// <summary>
        /// The audience ID.
        /// </summary>
        public long audienceGroupId { get; set; }

        /// <summary>
        /// CLICK
        /// </summary>
        public AudienceGroupType type { get; set; }

        /// <summary>
        /// The audience's name.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// When the audience was created (in UNIX time).
        /// </summary>
        public long created { get; set; }

        /// <summary>
        /// The request ID that was specified when the audience was created.
        /// </summary>
        public string requestId { get; set; }

        /// <summary>
        /// The URL that was specified when the audience was created.
        /// </summary>
        public string clickUrl { get; set; }
    }
}
