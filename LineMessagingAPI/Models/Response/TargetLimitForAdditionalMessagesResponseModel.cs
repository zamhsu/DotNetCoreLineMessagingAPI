namespace LineMessagingAPI.Models.Response
{
    /// <summary>
    /// Gets the target limit for additional messages in the current month.
    /// </summary>
    public class TargetLimitForAdditionalMessagesResponseModel
    {
        /// <summary>
        /// One of the following values to indicate whether a target limit is set or not.none. 
        /// "none" This indicates that a target limit is not set.limited. 
        /// "limited" This indicates that a target limit is set.
        /// </summary>
        public TargetLimitForAdditionalMessagesType type { get; set; }

        /// <summary>
        /// The target limit for additional messages in the current month. This property is returned when the type property has a value of limited.
        /// </summary>
        public int value { get; set; }
    }

    /// <summary>
    /// One of the following values to indicate whether a target limit is set or not.
    /// </summary>
    public enum TargetLimitForAdditionalMessagesType
    {
        none, //This indicates that a target limit is not set.
        limited //This indicates that a target limit is set.
    }
}