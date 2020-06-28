namespace LineMessagingAPI.Models.Message.Imagemap
{
    /// <summary>
    /// Imagemap Base Size
    /// </summary>
    public class ImagemapBaseSizeModel
    {
        /// <summary>
        /// [Required] Width of base image in pixels. Set to 1040.
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// [Required] Height of base image. Set to the height that corresponds to a width of 1040 pixels.
        /// </summary>
        public int height { get; set; }
    }
}