namespace LineMessagingAPI.Models.Message.Imagemap
{
    /// <summary>
    /// Defines the size of a tappable area.
    /// The top left is used as the origin of the area.
    /// Set these properties based on the baseSize.width property and the baseSize.height property.
    /// </summary>
    public class ImagemapAreaModel
    {
        /// <summary>
        /// [Required] Horizontal position relative to the left edge of the area. Value must be 0 or higher.
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// [Required] Vertical position relative to the top of the area. Value must be 0 or higher.
        /// </summary>
        public int y { get; set; }

        /// <summary>
        /// [Required] Width of the tappable area
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// [Required] Height of the tappable area
        /// </summary>
        public int height { get; set; }
    }
}