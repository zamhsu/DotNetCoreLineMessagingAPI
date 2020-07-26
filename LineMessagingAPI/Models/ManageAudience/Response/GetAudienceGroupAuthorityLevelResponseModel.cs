using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience.Response
{
    /// <summary>
    /// Get the authority level of the audience.
    /// </summary>
    public class GetAudienceGroupAuthorityLevelResponseModel
    {
        /// <summary>
        /// The authority level for all audiences linked to a channel.
        /// </summary>
        public AudienceGroupAuthorityLevel authorityLevel { get; set; }
    }
}
