namespace LineMessagingAPI.Models.Response
{
    /// <summary>
    /// 特定日期使用reply回覆訊息的數量(使用/bot/message/reply)
    /// </summary>
    public class NumberOfSentReplyMessagesResponseModel
    {
        /// <summary>
        /// 狀態:ready, unready, out_of_service
        /// </summary>
        /// <value></value>
        public NumberOfSentReplyMessagesStatus status { get; set; }

        /// <summary>
        /// status為ready時, 可取得特定日期使用reply回覆訊息的數量
        /// </summary>
        public int success { get; set; }

        /// <summary>
        /// 錯誤訊息
        /// </summary>
        public string message { get; set; }
    }

    /// <summary>
    /// 特定日期使用reply回覆訊息數量統計資料的處理狀態
    /// </summary>
    public enum NumberOfSentReplyMessagesStatus
    {
        ready, //可取得
        unready, //該日期尚未完成統計
        out_of_service //日期有誤
    }
}