using System;

namespace LineMessagingAPI.Models.Profile
{
    /// <summary>
    /// 使用者個人資料
    /// </summary>
    public class UserProfileResponseModel
    {
        /// <summary>
        /// User's display name
        /// </summary>
        public string displayName{get;set;}

        /// <summary>
        /// User ID
        /// </summary>
        public string userId{get;set;}

        /// <summary>
        /// Profile image URL. "https" image URL. Not included in the response if the user doesn't have a profile image.
        /// </summary>
        public string pictureUrl{get;set;}

        /// <summary>
        /// User's status message. Not included in the response if the user doesn't have a status message.
        /// </summary>
        public string statusMessage{get;set;}
    }
}