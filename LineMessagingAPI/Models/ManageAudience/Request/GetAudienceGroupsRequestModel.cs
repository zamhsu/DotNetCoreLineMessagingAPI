using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience.Request
{
    /// <summary>
    /// Get audience groups request parameters
    /// </summary>
    public class GetAudienceGroupsRequestModel
    {
        /// <summary>
        /// [Required] The page to return when getting (paginated) results. Must be 1 or higher.
        /// </summary>
        public long page { get; set; }

        /// <summary>
        /// [Optional] The name of the audience(s) to return. You can search for partial matches.
        /// This is case-insensitive, meaning AUDIENCE and audience are considered identical.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// [Optional] The status of the audience(s) to return. One of:
        /// IN_PROGRESS: Pending.It may take several hours for the status to change to READY.
        /// READY: Ready to accept messages
        /// FAILED: An error occurred while creating the audience.
        /// EXPIRED: Expired.Audiences are automatically deleted a month after they expire.
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// [Optional] The number of audiences per page. Default: 20
        /// Max: 40
        /// </summary>
        public long size { get; set; }

        /// <summary>
        /// [Optional]
        /// true: Get public audiences created in all channels linked to the same bot.
        /// false: Get audiences created in the same channel.
        /// </summary>
        public bool includesExternalPublicGroups { get; set; }

        /// <summary>
        /// [Optional] How the audience was created. If omitted, all audiences are included.
        /// OA_MANAGER: Return only audiences created with LINE Official Account Manager.
        /// MESSAGING_API: Return only audiences created with Messaging API.
        /// </summary>
        public string createRoute { get; set; }
    }
}
