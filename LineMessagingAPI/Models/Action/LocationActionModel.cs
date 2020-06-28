namespace LineMessagingAPI.Models.Action
{
    /// <summary>
    /// This action can be configured only with quick reply buttons.
    /// When a button associated with this action is tapped, the location screen in LINE is opened.
    /// </summary>
    public class LocationActionModel : ActionModel
    {
        /// <summary>
        /// [必填] 固定為 localtion
        /// </summary>
        public string type
        {
            get
            {
                return "location";
            }
        }

        /// <summary>
        /// [必填] Label for the action.
        ///        Max: 20 characters
        /// </summary>
        public string label { get; set; }
    }
}