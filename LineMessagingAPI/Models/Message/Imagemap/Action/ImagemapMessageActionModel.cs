namespace LineMessagingAPI.Models.Message.Imagemap.Action
{
    public class ImagemapMessageActionModel : ImagemapActionModel
    {
        /// <summary>
        /// [Required] message
        /// </summary>
        public string type
        {
            get
            {
                return "message";
            }
        }

        /// <summary>
        /// [Optional] Label for the action. Spoken when the accessibility feature is enabled on the client device.
        /// Max: 50 characters
        /// Supported on LINE 8.2.0 and later for iOS.
        /// </summary>
        public string label { get; set; }

        /// <summary>
        /// [Required] Message to send
        /// Max: 400 characters
        /// Supported on LINE for iOS and Android only.
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// [Required] Defined tappable area
        /// </summary>
        public ImagemapAreaModel area { get; set; }
    }
}