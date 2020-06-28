namespace LineChatBot.Models.RichMenu
{
    /// <summary>
    /// Rich menu area bound object
    /// </summary>
    public class RichMenuBoundsModel
    {
        /// <summary>
        /// [Required] Horizontal position of the top-left corner of the tappable area relative to the left edge of the image. Value must be 0 or higher.
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// [Required] Vertical position of the top-left corner of the tappable area relative to the left edge of the image. Value must be 0 or higher.
        /// </summary>
        public int y { get; set; }

        /// <summary>
        /// [Required] Width of the tappable area.
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// [Required] Height of the tappable area.
        /// </summary>
        public int height { get; set; }
    }
}