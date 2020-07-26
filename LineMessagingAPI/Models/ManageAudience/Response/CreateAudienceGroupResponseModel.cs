using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience.Response
{
    /// <summary>
    /// Creates an audience for uploading user IDs response model.
    /// </summary>
    public class CreateAudienceGroupResponseModel
    {
        /// <summary>
        /// The audience ID.
        /// </summary>
        public long audienceGroupId { get; set; }

        /// <summary>
        /// UPLOAD
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
    }
}
