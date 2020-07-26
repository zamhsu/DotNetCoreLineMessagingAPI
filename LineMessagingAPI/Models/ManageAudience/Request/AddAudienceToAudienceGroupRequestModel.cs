using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience.Request
{
    /// <summary>
    /// Adds new user IDs or IFAs to an audience for uploading user IDs request model
    /// </summary>
    public class AddAudienceToAudienceGroupRequestModel
    {
        /// <summary>
        /// [Required] The audience ID.
        /// </summary>
        public long audienceGroupId { get; set; }

        /// <summary>
        /// [Optional] The description to register with the job (in jobs[].description).
        /// </summary>
        public string uploadDescription { get; set; }

        /// <summary>
        /// [Required] An array of up to 10,000 user IDs or IFAs.
        /// </summary>
        public List<Audience> audiences { get; set; }
    }
}
