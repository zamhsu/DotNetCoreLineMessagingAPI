namespace LineMessagingAPI.Models.Message
{
    public class StickerMessageModel : MessageModel
    {
        /// <summary>
        /// [必填] 固定為 sticker
        /// </summary>
        public string type
        {
            get
            {
                return "sticker";
            }
        }

        /// <summary>
        /// [必填] Package ID for a set of stickers.
        /// </summary>
        public string packageId { get; set; }

        /// <summary>
        /// [必填] Sticker ID.
        /// </summary>
        public string stickerId { get; set; }
    }
}