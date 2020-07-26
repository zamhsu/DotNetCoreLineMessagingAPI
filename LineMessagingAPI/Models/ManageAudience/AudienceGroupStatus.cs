using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience
{
    /// <summary>
    /// The audience's status.
    /// </summary>
    public enum AudienceGroupStatus
    {
        /// <summary>
        /// Pending. It may take several hours for the status to change to READY.
        /// </summary>
        IN_PROGRESS,
        /// <summary>
        /// Ready to accept messages.
        /// </summary>
        READY,
        /// <summary>
        /// An error occurred while creating the audience.
        /// </summary>
        FAILED,
        /// <summary>
        /// Expired. Audiences are automatically deleted a month after they expire.
        /// </summary>
        EXPIRED
    }
}
