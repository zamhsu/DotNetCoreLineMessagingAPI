using System.Collections.Generic;

namespace LineChatBot.Models.RichMenu
{
    /// <summary>
    /// Links a rich menu to multiple users request object
    /// </summary>
    public class RichMenuBulkLinkRequestModel
    {
        /// <summary>
        /// [Required] ID of a rich menu
        /// </summary>
        public string richMenuId { get; set; }

        /// <summary>
        /// [Required] Array of user IDs. Found in the source object of webhook event objects.
        /// Do not use the LINE ID used in LINE.
        /// Max: 500 user IDs
        /// </summary>
        public List<string> userIds { get; set; }
    }
}