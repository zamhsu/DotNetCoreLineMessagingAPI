using System.Collections.Generic;

namespace LineChatBot.Models.RichMenu
{
    /// <summary>
    /// Unlink rich menus from multiple users request object
    /// </summary>
    public class RichMenuBulkUnlinkRequestModel
    {
        /// <summary>
        /// [Required] Array of user IDs. Found in the source object of webhook event objects. Do not use the LINE ID used in LINE. Max: 500 user IDs
        /// </summary>
        public List<string> userIds { get; set; }
    }
}