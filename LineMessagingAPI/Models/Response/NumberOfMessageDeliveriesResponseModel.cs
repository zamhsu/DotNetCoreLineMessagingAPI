namespace LineMessagingAPI.Models.Response
{
    /// <summary>
    /// 特定日期Line官方帳號回傳訊息的數量
    /// </summary>
    public class NumberOfMessageDeliveriesResponseModel
    {
        /// <summary>
        /// 狀態
        /// </summary>
        public NumberOfMessageDeliveriesStatus status { get; set; }

        /// <summary>
        ///推送訊息給所有Line官方帳號朋友的數量（廣播消息）。
        /// </summary>
        public long broadcast { get; set; }

        /// <summary>
        /// 根據特定屬性（targeted/segmented messages）發送給此LINE官方帳號某些朋友的推送消息數。
        /// </summary>
        public long targeting { get; set; }

        /// <summary>
        /// 使用自動回覆發送訊息的數量
        /// </summary>
        public long autoResponse { get; set; }

        /// <summary>
        /// 發送問候訊息的數量
        /// </summary>
        public long welcomeResponse { get; set; }

        /// <summary>
        /// 從LINE Official Account Manager Chat screen發送訊息的數量
        /// </summary>
        public long chat { get; set; }

        /// <summary>
        /// 使用Message API Broadcast發送訊息的數量
        /// </summary>
        public long apiBroadcast { get; set; }

        /// <summary>
        /// 使用Message API Push發送訊息的數量
        /// </summary>
        public long apiPush { get; set; }

        /// <summary>
        /// 使用Message API Multicast發送訊息的數量
        /// </summary>
        public long apiMulticast { get; set; }

        /// <summary>
        /// 使用Message API Reply發送訊息的數量
        /// </summary>
        public long apiReply { get; set; }
    }

    /// <summary>
    /// 特定日期使用reply回覆訊息數量統計資料的處理狀態
    /// </summary>
    public enum NumberOfMessageDeliveriesStatus
    {
        ready, //可取得
        unready, //該日期尚未完成統計
        out_of_service //日期有誤
    }
}