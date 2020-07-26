using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace LineMessagingAPI.Models.ManageAudience
{
    /// <summary>
    /// The audience type.
    /// </summary>
    public enum AudienceGroupType
    {
        /// <summary>
        /// An audience used for uploading user IDs.
        /// </summary>
        UPLOAD,
        /// <summary>
        /// An audience used for click-based retargeting.
        /// </summary>
        CLICK,
        /// <summary>
        /// An audience used for impression-based retargeting.
        /// </summary>
        IMP,
        /// <summary>
        /// Chat tag audience.
        /// </summary>
        CHAT_TAG,
        /// <summary>
        /// Friend path audience.
        /// </summary>
        FRIEND_PATH
    }
}
