using System.Collections.Generic;
using LineMessagingAPI.Models.Action;

namespace LineMessagingAPI.Models.Message.Template
{
    /// <summary>
    /// Template with two action buttons.
    /// </summary>
    public class ConfirmTemplateModel : TemplateModel
    {
        /// <summary>
        /// [Required] confirm
        /// </summary>
        public string type
        {
            get
            {
                return "confirm";
            }
        }

        /// <summary>
        /// [Required] Message text
        /// Max: 240 characters
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// [Required] Action when tapped
        /// Set 2 actions for the 2 buttons
        /// </summary>
        public List<ActionModel> actions { get; set; }
    }
}