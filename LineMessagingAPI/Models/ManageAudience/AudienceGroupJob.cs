using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience
{
    /// <summary>
    /// Use to keep track of each attempt to add new user IDs or IFAs to an audience for uploading user IDs.
    /// null is returned for any other type of audience.
    /// </summary>
    public class AudienceGroupJob
    {
        /// <summary>
        /// A job ID.
        /// </summary>
        public long audienceGroupJobId { get; set; }

        /// <summary>
        /// An audience ID.
        /// </summary>
        public long audienceGroupId { get; set; }

        /// <summary>
        /// The job's description.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// The job's type.
        /// </summary>
        public AudienceGroupJobType type { get; set; }

        /// <summary>
        /// The job's status.
        /// </summary>
        public AudienceGroupJobStatus jobStatus { get; set; }

        /// <summary>
        /// The reason why the operation failed. This is only included when jobs[].jobStatus is FAILED.
        /// </summary>
        public AudienceGroupJobFailedType failedType { get; set; }

        /// <summary>
        /// The number of accounts (recipients) that were added or removed.
        /// </summary>
        public long audienceCount { get; set; }

        /// <summary>
        /// When the job was created (in UNIX time).
        /// </summary>
        public long created { get; set; }
    }
}
