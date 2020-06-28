using System.Collections.Generic;

namespace LineChatBot.Models.RichMenu
{
    public class RichMenuModel
    {
        public RichMenuSizeModel size { get; set; }

        public bool selected { get; set; }

        public string name { get; set; }

        public string chatBarText { get; set; }

        public List<RichMenuAreaModel> areas { get; set; }
    }
}