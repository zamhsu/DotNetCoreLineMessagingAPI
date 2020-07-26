using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience.Response
{
    /// <summary>
    /// Gets audience data.
    /// </summary>
    public class GetAudienceDataResponseModel
    {
        /// <summary>
        /// Audience data.
        /// </summary>
        public AudienceGroup audienceGroup { get; set; }

        /// <summary>
        /// An array of jobs. This array is used to keep track of each attempt to add new user IDs or IFAs to an audience for uploading user IDs.
        /// null is returned for any other type of audience.
        /// </summary>
        public List<AudienceGroupJob> jobs { get; set; }
    }
}
