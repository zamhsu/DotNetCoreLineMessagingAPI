namespace LineMessagingAPI.Models.Message
{
    public class AudioMessageModel : MessageModel
    {
        /// <summary>
        /// [必填] 固定為 audio
        /// </summary>
        public string type
        {
            get
            {
                return "audio";
            }
        }

        /// <summary>
        /// [必填] URL of audio file (Max: 1000 characters)
        /// HTTPS over TLS 1.2 or later
        /// m4a
        /// Max: 1 minute
        /// Max: 10 MB
        /// </summary>
        public string originalContentUrl { get; set; }

        /// <summary>
        /// [必填] Length of audio file (milliseconds)
        /// </summary>
        public string duration { get; set; }
    }
}