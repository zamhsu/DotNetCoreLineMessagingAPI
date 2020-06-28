using System.Collections.Generic;

namespace LineChatBot.Models.RichMenu
{
    public class RichMenuBulkLinkRequestModel
    {
        public string richMenuId { get; set; }

        public List<string> userIds { get; set; }
    }
}