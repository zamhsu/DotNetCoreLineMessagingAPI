namespace LineChatBot.Models.RichMenu
{
    public class RichMenuResponseModel
    {
        public string richMenuId { get; set; }

        public RichMenuSizeModel size { get; set; }

        public bool selected { get; set; }

        public string name { get; set; }

        public string chatBarText { get; set; }

        public RichMenuAreaModel areas { get; set; }
    }
}