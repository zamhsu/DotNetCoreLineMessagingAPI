using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience.Request
{
    public class RenameAnAudienceRequestModel
    {
        /// <summary>
        /// [Required] The audience's name. Audience names must be unique.
        /// This is case-insensitive, meaning AUDIENCE and audience are considered identical.
        /// Max character limit: 120
        /// </summary>
        public string description { get; set; }
    }
}
