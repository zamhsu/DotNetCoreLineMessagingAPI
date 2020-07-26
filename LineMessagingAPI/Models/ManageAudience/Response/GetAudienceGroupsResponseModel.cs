using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience.Response
{
    /// <summary>
    /// Gets data for more than one audience.
    /// </summary>
    public class GetAudienceGroupsResponseModel
    {
        /// <summary>
        /// An array of audience data.
        /// </summary>
        public List<AudienceGroup> audienceGroups { get; set; }

        /// <summary>
        /// true when this is not the last page.
        /// </summary>
        public bool hasNextPage { get; set; }

        /// <summary>
        /// The total number of audiences that can be returned with the specified filter.
        /// </summary>
        public long totalCount { get; set; }

        /// <summary>
        /// Of the audiences you can get with the specified condition, the number of audiences with the update permission set to READ_WRITE.
        /// </summary>
        public long readWriteAudienceGroupTotalCount { get; set; }

        /// <summary>
        /// The current page number.
        /// </summary>
        public long page { get; set; }

        /// <summary>
        /// The number of audiences on the current page.
        /// </summary>
        public long size { get; set; }
    }
}
