namespace LineChatBot.Models.RichMenu
{
    /// <summary>
    /// Rich menu response object
    /// </summary>
    public class RichMenuResponseModel
    {
        /// <summary>
        /// ID of a rich menu
        /// </summary>
        public string richMenuId { get; set; }

        /// <summary>
        /// size object which contains the width and height of the rich menu displayed in the chat.
        /// The widths of the rich menu image must be between 800px and 2500px.
        /// The height must be at least 250px.
        /// However, the aspect ratio of width to height must be at least 1.45.
        /// </summary>
        public RichMenuSizeModel size { get; set; }

        /// <summary>
        /// true to display the rich menu by default. Otherwise, false.
        /// </summary>
        public bool selected { get; set; }

        /// <summary>
        /// Name of the rich menu. This value can be used to help manage your rich menus and is not displayed to users.
        /// Max character limit: 300
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Text displayed in the chat bar
        /// Max character limit: 14
        /// </summary>
        public string chatBarText { get; set; }

        /// <summary>
        /// Array of area objects which define the coordinates and size of tappable areas
        /// Max: 20 area objects
        /// </summary>
        public RichMenuAreaModel areas { get; set; }
    }
}