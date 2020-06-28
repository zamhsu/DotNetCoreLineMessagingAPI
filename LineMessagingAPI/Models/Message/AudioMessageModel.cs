namespace LineMessagingAPI.Models.Message
{
    public class AudioMessageModel : MessageModel
    {
        /// <summary>
        /// [Required] audio
        /// </summary>
        public string type
        {
            get
            {
                return "audio";
            }
        }

        /// <summary>
        /// [Required] URL of audio file (Max: 1000 characters)
        /// HTTPS over TLS 1.2 or later
        /// m4a
        /// Max: 1 minute
        /// Max: 10 MB
        /// </summary>
        public string originalContentUrl { get; set; }

        /// <summary>
        /// [Required] Length of audio file (milliseconds)
        /// </summary>
        public string duration { get; set; }
    }
}