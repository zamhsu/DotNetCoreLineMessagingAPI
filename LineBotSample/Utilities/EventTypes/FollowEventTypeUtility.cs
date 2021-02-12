using System.Threading.Tasks;
using LineMessagingAPI;
using LineMessagingAPI.Models.Profile;

namespace LineChatBot.Utilities.EventTypes
{
    /// <summary>
    /// Follow Event 處理器
    /// </summary>
    public class FollowEventTypeUtility
    {
        private readonly string _accessToken;
        private readonly LineMessagingClient _lineClient;

        public FollowEventTypeUtility(string accessToken)
        {
            _accessToken = accessToken;
            _lineClient = new LineMessagingClient(_accessToken);
        }

        /// <summary>
        /// 取得使用者個人資料
        /// </summary>
        /// <param name="userId">userId</param>
        /// <returns>UserProfileResponseModel</returns>
        public async Task<UserProfileResponseModel> GetProfileAsync(string userId)
        {
            UserProfileResponseModel responseModel = new UserProfileResponseModel();
            responseModel = await _lineClient.GetProfileAsync(userId);

            return responseModel;
        }
    }
}