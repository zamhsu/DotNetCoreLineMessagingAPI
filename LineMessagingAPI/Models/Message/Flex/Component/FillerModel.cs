namespace LineMessagingAPI.Models.Message.Flex.Component
{
    /// <summary>
    /// This component is used to create a space.
    /// You can put a space between, before, or after components by inserting a filler anywhere within a box.
    /// </summary>
    public class FillerModel : FlexComponentModel
    {
        /// <summary>
        /// [Required] filler
        /// </summary>
        public string type
        {
            get
            {
                return "filler";
            }
        }

        /// <summary>
        /// [Optional] The ratio of the width or height of this component within the parent box.
        /// </summary>
        public int? flex { get; set; }
    }
}