using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience
{
    /// <summary>
    /// The reason why the operation failed. This is only included when status is FAILED
    /// </summary>
    public enum AudienceGroupFailedType
    {
        /// <summary>
        /// An unknown type.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// There weren't enough accounts in the audience that could be used as recipients (at least 100 are needed).
        /// </summary>
        AUDIENCE_GROUP_AUDIENCE_INSUFFICIENT,
        /// <summary>
        /// Internal server error.
        /// </summary>
        INTERNAL_ERROR
    }
}
