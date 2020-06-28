using LineMessagingAPI.Models.Action;

namespace LineChatBot.Models.RichMenu
{
    public class RichMenuAreaModel
    {
        public RichMenuBoundsModel bounds { get; set; }

        public ActionModel action { get; set; }
    }
}