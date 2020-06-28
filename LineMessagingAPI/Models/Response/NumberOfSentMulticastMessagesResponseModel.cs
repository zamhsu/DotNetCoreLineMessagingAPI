namespace LineMessagingAPI.Models.Response
{
    /// <summary>
    /// 特定日期使用multicast群發訊息的數量(使用/bot/message/multicast)
    /// </summary>
    public class NumberOfSentMulticastMessagesResponseModel
    {
        /// <summary>
        /// 狀態:ready, unready, out_of_service
        /// </summary>
        /// <value></value>
        public NumberOfSentMulticastMessagesStatus status { get; set; }

        /// <summary>
        /// status為ready時, 可取得特定日期使用multicast群發訊息的數量
        /// </summary>
        public int success { get; set; }

        /// <summary>
        /// 錯誤訊息
        /// </summary>
        public string message { get; set; }
    }

    /// <summary>
    /// 特定日期使用multicast群發訊息數量統計資料的處理狀態
    /// </summary>
    public enum NumberOfSentMulticastMessagesStatus
    {
        ready, //可取得
        unready, //該日期尚未完成統計
        out_of_service //日期有誤
    }
}