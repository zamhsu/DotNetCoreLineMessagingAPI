using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience
{
    /// <summary>
    /// The job's status.
    /// </summary>
    public enum AudienceGroupJobStatus
    {
        /// <summary>
        /// Waiting to run.
        /// </summary>
        QUEUED,
        /// <summary>
        /// Running.
        /// </summary>
        WORKING,
        /// <summary>
        /// Completed.
        /// </summary>
        FINISHED,
        /// <summary>
        /// Failed.
        /// </summary>
        FAILED
    }
}
