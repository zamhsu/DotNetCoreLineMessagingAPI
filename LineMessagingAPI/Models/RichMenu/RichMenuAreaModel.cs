using LineMessagingAPI.Models.Action;

namespace LineChatBot.Models.RichMenu
{
    /// <summary>
    /// Rich menu area object
    /// </summary>
    public class RichMenuAreaModel
    {
        /// <summary>
        /// [Required] Object describing the boundaries of the area in pixels.
        /// </summary>
        public RichMenuBoundsModel bounds { get; set; }

        /// <summary>
        /// [Required] Action performed when the area is tapped.
        /// </summary>
        public ActionModel action { get; set; }
    }
}