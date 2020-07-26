using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience
{
    /// <summary>
    /// How the audience was created. If omitted, you will get all audiences.
    /// </summary>
    public enum AudienceGroupCreateRoute
    {
        /// <summary>
        /// Audience created with LINE Official Account Manager.
        /// </summary>
        OA_MANAGER,
        /// <summary>
        /// Audience created with Messaging API.
        /// </summary>
        MESSAGING_API
    }
}
