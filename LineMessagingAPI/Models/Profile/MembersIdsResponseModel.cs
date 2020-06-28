using System.Collections.Generic;

namespace LineMessagingAPI.Models.Profile
{
    public class MembersIdsResponseModel
    {
        /// <summary>
        /// List of user IDs of members in the group or room.
        /// Users of LINE version 7.4.x or earlier are not included in memberIds.
        /// For more information, see User consent.
        /// Max: 100 user IDs
        /// </summary>
        public List<string> memberIds { get; set; }

        /// <summary>
        /// A continuation token to get the next array of user IDs of the members in the group or room.
        /// Returned only when there are remaining user IDs that were not returned in memberIds in the original request.
        /// </summary>
        public string next { get; set; }
    }
}