using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience
{
    /// <summary>
    /// The job's type.
    /// </summary>
    public enum AudienceGroupJobType
    {
        /// <summary>
        /// An unknown type.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// Indicates that a user ID or IFA was added via the Messaging API.
        /// </summary>
        DIFF_ADD
    }
}
