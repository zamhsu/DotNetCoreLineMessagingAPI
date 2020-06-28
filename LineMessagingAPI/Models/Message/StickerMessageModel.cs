namespace LineMessagingAPI.Models.Message
{
    public class StickerMessageModel : MessageModel
    {
        /// <summary>
        /// [Required] sticker
        /// </summary>
        public string type
        {
            get
            {
                return "sticker";
            }
        }

        /// <summary>
        /// [Required] Package ID for a set of stickers.
        /// </summary>
        public string packageId { get; set; }

        /// <summary>
        /// [Required] Sticker ID.
        /// </summary>
        public string stickerId { get; set; }
    }
}