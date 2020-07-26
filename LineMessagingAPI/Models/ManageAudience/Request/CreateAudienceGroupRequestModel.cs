using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience.Request
{
    /// <summary>
    /// Creates an audience for uploading user IDs request model.
    /// </summary>
    public class CreateAudienceGroupRequestModel
    {
        /// <summary>
        /// [Required] The audience's name. Audience names must be unique.
        /// This is case-insensitive, meaning AUDIENCE and audience are considered identical.
        /// Max character limit: 120
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// [Required] If this is false (default), recipients are specified by user IDs.
        /// If true, recipients must be specified by IFAs.
        /// </summary>
        public bool isIfaAudience { get; set; }

        /// <summary>
        /// [Optional] The description to register for the job (in jobs[].description).
        /// </summary>
        public string uploadDescription { get; set; }

        /// <summary>
        /// [Required] An array of user IDs or IFAs.
        /// Max amount: 10,000
        /// </summary>
        public List<Audience> audiences { get; set; }
    }
}
