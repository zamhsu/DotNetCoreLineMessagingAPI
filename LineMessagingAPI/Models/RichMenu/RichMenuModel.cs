using System.Collections.Generic;

namespace LineChatBot.Models.RichMenu
{
    /// <summary>
    /// Rich menu object
    /// </summary>
    public class RichMenuModel
    {
        /// <summary>
        /// [Required] size object which contains the width and height of the rich menu displayed in the chat.
        /// The width of the rich menu image must be between 800px and 2500px.
        /// The height must be at least 250px.
        /// However, the aspect ratio of width to height must be at least 1.45.
        /// </summary>
        public RichMenuSizeModel size { get; set; }

        /// <summary>
        /// [Required] true to display the rich menu by default. Otherwise, false.
        /// </summary>
        public bool selected { get; set; }

        /// <summary>
        /// [Required] Name of the rich menu.
        /// This value can be used to help manage your rich menus and is not displayed to users.
        /// Max character limit: 300
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// [Required] Text displayed in the chat bar
        /// Max character limit: 14
        /// </summary>
        public string chatBarText { get; set; }

        /// <summary>
        /// [Required] Array of area objects which define the coordinates and size of tappable areas
        /// Max: 20 area objects
        /// </summary>
        public List<RichMenuAreaModel> areas { get; set; }
    }
}