using System.Collections.Generic;

namespace LineMessagingAPI.Models.Response.Demographic
{
    /// <summary>
    /// Friend demographics response object
    /// </summary>
    public class FriendDemographicsResponseModel
    {
        /// <summary>
        /// true if friend demographic information is available.
        /// </summary>
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