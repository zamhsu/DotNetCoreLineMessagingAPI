namespace LineMessagingAPI.Models.Message.Imagemap
{
    public class ImagemapAreaModel
    {
        /// <summary>
        /// Horizontal position relative to the left edge of the area. Value must be 0 or higher.
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// Vertical position relative to the top of the area. Value must be 0 or higher.
        /// </summary>
        public int y { get; set; }

        /// <summary>
        /// Width of the tappable area
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Height of the tappable area
        /// </summary>
        public int height { get; set; }
    }
}