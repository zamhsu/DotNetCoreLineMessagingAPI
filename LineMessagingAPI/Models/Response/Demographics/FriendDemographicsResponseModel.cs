using System.Collections.Generic;

namespace LineMessagingAPI.Models.Response.Demographic
{
    /// <summary>
    /// 好友統計資料
    /// </summary>
    public class FriendDemographicsResponseModel
    {
        public bool available { get; set; }

        /// <summary>
        /// Percentage per gender
        /// </summary>
        public List<GenderModel> genders { get; set; }

        /// <summary>
        /// Percentage per age group
        /// </summary>
        public List<AgeModel> ages { get; set; }

        /// <summary>
        /// Percentage per area
        /// </summary>
        public List<AreaModel> areas { get; set; }

        /// <summary>
        /// Percentage by OS
        /// </summary>
        public List<AppTypeModel> appTypes { get; set; }

        /// <summary>
        /// Percentage per friendship duration
        /// </summary>
        public List<SubscriptionPeriodModel> subscriptionPeriods { get; set; }
    }
}