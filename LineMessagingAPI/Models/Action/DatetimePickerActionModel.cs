using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LineMessagingAPI.Models.Action
{
    /// <summary>
    /// When a control associated with this action is tapped, a postback event is returned via webhook with the date and time selected by the user from the date and time selection dialog.
    /// The datetime picker action does not support time zones.
    /// </summary>
    public class DatetimePickerActionModel : ActionModel
    {
        /// <summary>
        /// [必填] 固定為 datetimepicker
        /// </summary>
        public string type
        {
            get
            {
                return "datetimepicker";
            }
        }

        /// <summary>
        /// Label for the action
        ///  * Required for templates other than image carousel. Max: 20 characters.
        ///  * Optional for image carousel templates. Max: 12 characters.
        ///  * Optional for rich menus. Spoken when the accessibility feature is enabled on the client device. Max: 20 characters. Supported on LINE 8.2.0 and later for iOS.
        ///  * Required for the button of Flex Message. This property can be specified for the box, image, and text but its value is not displayed. Max: 20 characters.
        /// </summary>
        public string label { get; set; }

        /// <summary>
        /// [必填] String returned via webhook in the postback.data property of the postback event
        ///        Max: 300 characters
        /// </summary>
        public string data { get; set; }

        /// <summary>
        /// [必填] Action mode
        ///         * date: Pick date (full-date[max: 2100-12-31, min: 1900-01-01] ex. 2017-06-18)
        ///         * time: Pick time (time-hour:time-minute[max: 23:59, min: 00:00] ex. 06:19)
        ///         * datetime: Pick date and time (full-dateTtime-hour:time-minute or full-datettime-hour:time-minute[max: 2100-12-31T23:59, min: 1900-01-01T00:00] ex. 2017-06-18T06:15/2017-06-18t06:15)
        /// </summary>
        public DatetimePickerActionMode mode { get; set; }

        /// <summary>
        /// [選填] Initial value of date or time.
        /// </summary>
        public string initial { get; set; }

        /// <summary>
        /// [選填] Largest date or time value that can be selected. Must be greater than the min value.
        /// </summary>
        public string max { get; set; }

        /// <summary>
        /// [選填] Smallest date or time value that can be selected. Must be less than the max value.s
        /// </summary>
        public string min { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DatetimePickerActionMode
    {
        [EnumMember(Value = "date")]
        date,
        [EnumMember(Value = "time")]
        time,
        [EnumMember(Value = "datetime")]
        datetime
    }
}