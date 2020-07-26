using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience.Response
{
    /// <summary>
    /// Creates an audience for impression-based retargeting response model.
    /// </summary>
    public class CreateImpressionBasedAudienceGroupResponseModel
    {
        /// <summary>
        /// The audience ID.
        /// </summary>
        public long audienceGroupId { get; set; }

        /// <summary>
        /// IMP
        /// </summary>
        public AudienceGroupType type { get; set; }

        /// <summary>
        /// When the audience was created (in UNIX time).
        /// </summary>
        public long created { get; set; }

        /// <summary>
        /// The request ID that was specified when the audience was created.
        /// </summary>
        public string requestId { get; set; }
    }
}
