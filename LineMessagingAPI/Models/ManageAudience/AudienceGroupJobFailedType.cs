using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience
{
    /// <summary>
    /// The reason why the operation failed. This is only included when jobs[].jobStatus is FAILED.
    /// </summary>
    public enum AudienceGroupJobFailedType
    {
        /// <summary>
        /// An unknown type.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// There weren't enough accounts in the audience that could be used as recipients (at least 100 are needed).
        /// </summary>
        INTERNAL_ERROR,
        /// <summary>
        /// Internal server error.
        /// </summary>
        AUDIENCE_GROUP_AUDIENCE_INSUFFICIENT
    }
}
