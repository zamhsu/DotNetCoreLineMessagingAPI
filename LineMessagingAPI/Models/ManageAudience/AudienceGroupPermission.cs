using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience
{
    /// <summary>
    /// Audience's update permission.
    /// Audiences linked to the same channel will be READ_WRITE.
    /// </summary>
    public enum AudienceGroupPermission
    {
        /// <summary>
        /// Can use only.
        /// </summary>
        READ,
        /// <summary>
        /// Can use and update.
        /// </summary>
        READ_WRITE
    }
}
