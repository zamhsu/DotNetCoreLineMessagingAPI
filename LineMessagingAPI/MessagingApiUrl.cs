namespace LineMessagingAPI
{
    /// <summary>
    /// Line Messaging API Url
    /// </summary>
    public class MessagingApiUrl
    {
        /// <summary>
        /// Message相關API(HTTP GET / HTTP POST)
        /// </summary>
        public static string MessageUrl
        {
            get
            {
                return "https://api.line.me/v2/bot/message";
            }
        }

        /// <summary>
        /// 回覆訊息(HTTP POST)
        /// </summary>
        public static string ReplyUrl
        {
            get
            {
                return "https://api.line.me/v2/bot/message/reply";
            }
        }
        
        /// <summary>
        /// 推送訊息(HTTP POST)
        /// </summary>
        public static string PushUrl
        {
            get
            {
                return "https://api.line.me/v2/bot/message/push";
            }
        }

        /// <summary>
        /// 群發訊息(HTTP POST)
        /// </summary>
        public static string MulticastUrl
        {
            get
            {
                return "https://api.line.me/v2/bot/message/multicast";
            }
        }

        /// <summary>
        /// 廣播訊息(HTTP POST)
        /// </summary>
        public static string BroadcastUrl
        {
            get
            {
                return "https://api.line.me/v2/bot/message/broadcast";
            }
        }

        /// <summary>
        /// 取得訊息內容(HTTP GET)
        /// </summary>
        public static string MessageContentUrl
        {
            get
            {
                return "https://api-data.line.me/v2/bot/message";
            }
        }

        /// <summary>
        /// 取得統計資料(HTTP GET)
        /// </summary>
        public static string InsightUrl
        {
            get
            {
                return "https://api.line.me/v2/bot/insight";
            }
        }

        /// <summary>
        /// 取得個人資料(HTTP GET)
        /// </summary>
        public static string ProfileUrl
        {
            get
            {
                return "https://api.line.me/v2/bot/profile";
            }
        }

        /// <summary>
        /// 取得聊天室資料(HTTP GET)
        /// </summary>
        public static string RoomUrl
        {
            get
            {
                return "https://api.line.me/v2/bot/room";
            }
        }
        
        /// <summary>
        /// 取得群組資料(HTTP GET)
        /// </summary>
        /// <value></value>
        public static string GroupUrl
        {
            get
            {
                return "https://api.line.me/v2/bot/group";
            }
        }

        /// <summary>
        /// RichMenu相關API
        /// </summary>
        /// <value></value>
        public static string RichMenuUrl
        {
            get
            {
                return "https://api.line.me/v2/bot/richmenu";
            }
        }

        /// <summary>
        /// 使用者專屬相關API
        /// </summary>
        /// <value></value>
        public static string UserSettingUrl
        {
            get
            {
                return "https://api.line.me/v2/bot/user";
            }
        }
    }
}