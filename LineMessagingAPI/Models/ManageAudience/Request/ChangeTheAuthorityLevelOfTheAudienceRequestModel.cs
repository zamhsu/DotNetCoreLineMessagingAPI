using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience.Request
{
    /// <summary>
    /// Change the authority level of all audiences created in the same channel.
    /// </summary>
    public class ChangeTheAuthorityLevelOfTheAudienceRequestModel
    {
        /// <summary>
        /// [Required] The authority level for all audiences linked to a channel.
        /// </summary>
        public AudienceGroupAuthorityLevel authorityLevel { get; set; }
    }
}
