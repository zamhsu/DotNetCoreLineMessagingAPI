using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience
{
    public class AudienceGroup
    {
        /// <summary>
        /// The audience ID.
        /// </summary>
        public long audienceGroupId { get; set; }

        /// <summary>
        /// The audience type.
        /// </summary>
        public AudienceGroupType type { get; set; }

        /// <summary>
        /// The audience's name.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// The audience's status.
        /// </summary>
        public AudienceGroupStatus status { get; set; }

        /// <summary>
        /// The reason why the operation failed. This is only included when status is FAILED
        /// </summary>
        public AudienceGroupFailedType failedType { get; set; }

        /// <summary>
        /// The number of valid recipients.
        /// </summary>
        public long audienceCount { get; set; }

        /// <summary>
        /// When the audience was created (in UNIX time).
        /// </summary>
        public long created { get; set; }

        /// <summary>
        /// The request ID that was specified when the audience was created.
        /// This is only included when type is CLICK or IMP.
        /// </summary>
        public string requestId { get; set; }

        /// <summary>
        /// The URL that was specified when the audience was created.
        /// This is only included when type is CLICK.
        /// </summary>
        public string clickUrl { get; set; }

        /// <summary>
        /// The value specified when creating an audience for uploading user IDs to indicate the type of accounts that will be given as recipients.
        /// One of:
        /// true: Accounts are specified with IFAs.
        /// false (default): Accounts are specified with user IDs.
        /// </summary>
        public bool isIfaAudience { get; set; }

        /// <summary>
        /// Audience's update permission.
        /// Audiences linked to the same channel will be READ_WRITE.
        /// </summary>
        public AudienceGroupPermission permission { get; set; }

        /// <summary>
        /// How the audience was created. If omitted, you will get all audiences.
        /// </summary>
        public AudienceGroupCreateRoute createRoute { get; set; }
    }
}
