namespace LineMessagingAPI.Models.Response
{
    /// <summary>
    /// 好友統計資料
    /// </summary>
    public class NumberOfFollowersResponseModel
    {
        /// <summary>
        /// 狀態
        /// </summary>
        public NumberOfFollowersStatus status { get; set; }

        /// <summary>
        /// 加入好友。此為您的帳號首次被用戶加入好友的次數，即使對方封鎖您的帳號或稍後刪除LINE帳號，此數值也不會降低。
        /// </summary>
        public long followers { get; set; }

        /// <summary>
        /// 目標好友數。意指依性別、年齡及地區等屬性篩選好友後所得出可觸及的分眾訊息接收對象的母數，其包含經常使用LINE及LINE相關服務、且系統可高度精確地推測其屬性的好友。
        /// </summary>
        public long targetedReaches { get; set; }

        /// <summary>
        /// 封鎖。此為對方封鎖您的帳號時採計的數值；若對方解除封鎖您的帳號，此數值將會降低。
        /// </summary>
        public long blocks { get; set; }
    }

    /// <summary>
    /// 特定日期使用reply回覆訊息數量統計資料的處理狀態
    /// </summary>
    public enum NumberOfFollowersStatus
    {
        ready, //可取得
        unready, //該日期尚未完成統計
        out_of_service //日期有誤
    }
}