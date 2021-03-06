﻿using LineChatBot.Models.RichMenu;
using LineMessagingAPI.Models;
using LineMessagingAPI.Models.ManageAudience.Request;
using LineMessagingAPI.Models.ManageAudience.Response;
using LineMessagingAPI.Models.Profile;
using LineMessagingAPI.Models.Response;
using LineMessagingAPI.Models.Response.Demographic;
using LineMessagingAPI.Models.Response.InteractionStatistics;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LineMessagingAPI
{
    /// <summary>
    /// Line Messaging API 功能
    /// </summary>
    public class LineMessagingClient
    {
        private readonly string accessToken;

        /// <summary>
        /// Line Messaging API 功能
        /// </summary>
        /// <param name="accessToken">LINE AccessToken</param>
        public LineMessagingClient(string accessToken)
        {
            this.accessToken = accessToken;
        }

        #region message

        //content

        /// <summary>
        /// 回覆訊息
        /// </summary>
        /// <param name="replyMessageBody">回覆訊息body資料</param>
        public async Task ReplyMessageAsync(ReplyMessageModel replyMessageBody)
        {
            string jsonString = JsonConvert.SerializeObject(replyMessageBody, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.None });

            await Utility.DoLineHttpPostAsync(MessagingApiUrl.ReplyUrl, jsonString, accessToken);
        }

        /// <summary>
        /// 回覆訊息(訊息內容使用Json字串，不需messages:[])
        /// </summary>
        /// <param name="replyToken">ReplyToken</param>
        /// <param name="jsonMessages">Json格式的messages內容</param>
        public async Task ReplyMessageWithJsonAsync(string replyToken, string jsonMessages)
        {
            string flexMessage = @"{""replyToken"":""" + replyToken + "" + @""",""messages"":[{""type"":""flex"",""altText"":""購物"",""contents"":{""type"":""carousel"",""contents"":[{""type"":""bubble"",""body"":{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""image"",""url"":""https://scdn.line-apps.com/n/channel_devcenter/img/flexsnapshot/clip/clip1.jpg"",""size"":""full"",""aspectMode"":""cover"",""aspectRatio"":""2:3"",""gravity"":""top""},{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""text"",""text"":""Brown's T-shirts"",""size"":""xl"",""color"":""#ffffff"",""weight"":""bold""}]},{""type"":""box"",""layout"":""baseline"",""contents"":[{""type"":""text"",""text"":""¥35,800"",""color"":""#ebebeb"",""size"":""sm"",""flex"":0},{""type"":""text"",""text"":""¥75,000"",""color"":""#ffffffcc"",""decoration"":""line-through"",""gravity"":""bottom"",""flex"":0,""size"":""sm""}],""spacing"":""lg""},{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""filler""},{""type"":""box"",""layout"":""baseline"",""contents"":[{""type"":""filler""},{""type"":""icon"",""url"":""https://scdn.line-apps.com/n/channel_devcenter/img/flexsnapshot/clip/clip14.png""},{""type"":""text"",""text"":""Add to cart"",""color"":""#ffffff"",""flex"":0,""offsetTop"":""-2px""},{""type"":""filler""}],""spacing"":""sm""},{""type"":""filler""}],""borderWidth"":""1px"",""cornerRadius"":""4px"",""spacing"":""sm"",""borderColor"":""#ffffff"",""margin"":""xxl"",""height"":""40px""}],""position"":""absolute"",""offsetBottom"":""0px"",""offsetStart"":""0px"",""offsetEnd"":""0px"",""backgroundColor"":""#03303Acc"",""paddingAll"":""20px"",""paddingTop"":""18px""},{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""text"",""text"":""SALE"",""color"":""#ffffff"",""align"":""center"",""size"":""xs"",""offsetTop"":""3px""}],""position"":""absolute"",""cornerRadius"":""20px"",""offsetTop"":""18px"",""backgroundColor"":""#ff334b"",""offsetStart"":""18px"",""height"":""25px"",""width"":""53px""}],""paddingAll"":""0px""}},{""type"":""bubble"",""body"":{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""image"",""url"":""https://scdn.line-apps.com/n/channel_devcenter/img/flexsnapshot/clip/clip2.jpg"",""size"":""full"",""aspectMode"":""cover"",""aspectRatio"":""2:3"",""gravity"":""top""},{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""text"",""text"":""Cony's T-shirts"",""size"":""xl"",""color"":""#ffffff"",""weight"":""bold""}]},{""type"":""box"",""layout"":""baseline"",""contents"":[{""type"":""text"",""text"":""¥35,800"",""color"":""#ebebeb"",""size"":""sm"",""flex"":0},{""type"":""text"",""text"":""¥75,000"",""color"":""#ffffffcc"",""decoration"":""line-through"",""gravity"":""bottom"",""flex"":0,""size"":""sm""}],""spacing"":""lg""},{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""filler""},{""type"":""box"",""layout"":""baseline"",""contents"":[{""type"":""filler""},{""type"":""icon"",""url"":""https://scdn.line-apps.com/n/channel_devcenter/img/flexsnapshot/clip/clip14.png""},{""type"":""text"",""text"":""Add to cart"",""color"":""#ffffff"",""flex"":0,""offsetTop"":""-2px""},{""type"":""filler""}],""spacing"":""sm""},{""type"":""filler""}],""borderWidth"":""1px"",""cornerRadius"":""4px"",""spacing"":""sm"",""borderColor"":""#ffffff"",""margin"":""xxl"",""height"":""40px""}],""position"":""absolute"",""offsetBottom"":""0px"",""offsetStart"":""0px"",""offsetEnd"":""0px"",""backgroundColor"":""#9C8E7Ecc"",""paddingAll"":""20px"",""paddingTop"":""18px""},{""type"":""box"",""layout"":""vertical"",""contents"":[{""type"":""text"",""text"":""SALE"",""color"":""#ffffff"",""align"":""center"",""size"":""xs"",""offsetTop"":""3px""}],""position"":""absolute"",""cornerRadius"":""20px"",""offsetTop"":""18px"",""backgroundColor"":""#ff334b"",""offsetStart"":""18px"",""height"":""25px"",""width"":""53px""}],""paddingAll"":""0px""}}]}}]}";

            string jsonString = @"{""replyToken"":""" + replyToken + "" + @""",""messages"":[" + jsonMessages + "]}";

            await Utility.DoLineHttpPostAsync(MessagingApiUrl.ReplyUrl, jsonString, accessToken);
        }

        /// <summary>
        /// 推送訊息
        /// </summary>
        /// <param name="pushMessageBody">推送訊息body資料</param>
        public async Task PushMessageAsync(PushMessageModel pushMessageBody)
        {
            string jsonString = JsonConvert.SerializeObject(pushMessageBody, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.None });

            await Utility.DoLineHttpPostAsync(MessagingApiUrl.PushUrl, jsonString, accessToken);
        }

        /// <summary>
        /// 群發訊息
        /// </summary>
        /// <param name="multicastModel">群發訊息body資料</param>
        public async Task MulticastMessageAsync(MulticastModel multicastModel)
        {
            string jsonString = JsonConvert.SerializeObject(multicastModel, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.None });

            await Utility.DoLineHttpPostAsync(MessagingApiUrl.MulticastUrl, jsonString, accessToken);
        }

        /// <summary>
        /// 廣播訊息
        /// </summary>
        /// <param name="broadcastModel">廣播訊息body資料</param>
        public async Task BroadcastMessageAsync(BroadcastModel broadcastModel)
        {
            string jsonString = JsonConvert.SerializeObject(broadcastModel, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.None });

            await Utility.DoLineHttpPostAsync(MessagingApiUrl.BroadcastUrl, jsonString, accessToken);
        }

        /// <summary>
        /// Gets the target limit for additional messages in the current month.
        /// The number of messages retrieved by this operation includes the number of messages sent from LINE Official Account Manager.
        /// Set a target limit with LINE Official Account Manager. For the procedures, refer to the LINE Official Account Manager manual.
        /// Note: LINE@ accounts cannot call this API endpoint.
        /// </summary>
        /// <returns>TargetLimitForAdditionalMessagesResponseModel</returns>
        public async Task<TargetLimitForAdditionalMessagesResponseModel> GetTheTargetLimitForAdditionsMessagesAsync()
        {
            TargetLimitForAdditionalMessagesResponseModel responseModel = new TargetLimitForAdditionalMessagesResponseModel();
            string para = "/quota";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.MessageUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<TargetLimitForAdditionalMessagesResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// Gets the number of messages sent in the current month.
        /// The number of messages retrieved by this operation includes the number of messages sent from LINE Official Account Manager.
        /// The number of messages retrieved by this operation is approximate. To get the correct number of sent messages, use LINE Official Account Manager or execute API operations for getting the number of sent messages.
        /// Note: LINE@ accounts cannot call this API endpoint.
        /// </summary>
        /// <returns>NumberOfMessagesSentThisMonthResponseModel</returns>
        public async Task<NumberOfMessagesSentThisMonthResponseModel> GetNumberOfMessagesSentThisMonthAsync()
        {
            NumberOfMessagesSentThisMonthResponseModel responseModel = new NumberOfMessagesSentThisMonthResponseModel();
            string para = "/quota/consumption";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.MessageUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<NumberOfMessagesSentThisMonthResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// Gets the number of messages sent with the /bot/message/reply endpoint.
        /// The number of messages retrieved by this operation does not include the number of messages sent from LINE Official Account Manager.
        /// </summary>
        /// <param name="date">日期(yyyyMMdd)</param>
        /// <returns>NumberOfSentReplyMessagesResponseModel</returns>
        public async Task<NumberOfSentReplyMessagesResponseModel> GetNumberOfSentReplyMessagesAsync(string date)
        {
            NumberOfSentReplyMessagesResponseModel responseModel = new NumberOfSentReplyMessagesResponseModel();
            string para = $"/delivery/reply?date={date}";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.MessageUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<NumberOfSentReplyMessagesResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// Gets the number of messages sent with the /bot/message/push endpoint.
        /// The number of messages retrieved by this operation does not include the number of messages sent from LINE Official Account Manager.
        /// Note: LINE@ accounts under the free or basic plan cannot call this API endpoint.
        /// </summary>
        /// <param name="date">日期(yyyyMMdd)</param>
        /// <returns>NumberOfSentPushMessagesResponseModel</returns>
        public async Task<NumberOfSentPushMessagesResponseModel> GetNumberOfSentPushMessagesAsync(string date)
        {
            NumberOfSentPushMessagesResponseModel responseModel = new NumberOfSentPushMessagesResponseModel();
            string para = $"/delivery/push?date={date}";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.MessageUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<NumberOfSentPushMessagesResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// Gets the number of messages sent with the /bot/message/multicast endpoint.
        /// The number of messages retrieved by this operation does not include the number of messages sent from LINE Official Account Manager.
        /// Note: LINE@ accounts under the free or basic plan cannot call this API endpoint.
        /// </summary>
        /// <param name="date">日期(yyyyMMdd)</param>
        /// <returns>NumberOfSentMulticastMessagesResponseModel</returns>
        public async Task<NumberOfSentMulticastMessagesResponseModel> GetNumberOfSentMulticastMessagesAsync(string date)
        {
            NumberOfSentMulticastMessagesResponseModel responseModel = new NumberOfSentMulticastMessagesResponseModel();
            string para = $"/delivery/multicast?date={date}";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.MessageUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<NumberOfSentMulticastMessagesResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// Gets the number of messages sent with the /bot/message/broadcast endpoint.
        /// The number of messages retrieved by this operation does not include the number of messages sent from LINE Official Account Manager.
        /// </summary>
        /// <param name="date">日期(yyyyMMdd)</param>
        /// <returns>NumberOfSentBroadcastMessagesResponseModel</returns>
        public async Task<NumberOfSentBroadcastMessagesResponseModel> GetNumberOfSentBroadcastMessagesAsync(string date)
        {
            NumberOfSentBroadcastMessagesResponseModel responseModel = new NumberOfSentBroadcastMessagesResponseModel();
            string para = $"/delivery/broadcast?date={date}";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.MessageUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<NumberOfSentBroadcastMessagesResponseModel>(apiResult);

            return responseModel;
        }

        #endregion

        #region manageAudience

        /// <summary>
        /// Create audience for uploading user IDs.
        /// </summary>
        /// <param name="createRequestModel">CreateAudienceGroupRequestModel</param>
        /// <returns></returns>
        public async Task<CreateAudienceGroupResponseModel> CreateAudienceGroupAsync(CreateAudienceGroupRequestModel createRequestModel)
        {
            //POST /upload
            string url = MessagingApiUrl.AudienceGroupUrl + "/upload";
            string jsonString = JsonConvert.SerializeObject(createRequestModel, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.None });
            string apiResult = null;
            CreateAudienceGroupResponseModel responseModel = new CreateAudienceGroupResponseModel();

            apiResult = await Utility.DoLineHttpPostAsync(url, jsonString, accessToken);
            responseModel = JsonConvert.DeserializeObject<CreateAudienceGroupResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// Create audience for uploading user IDs.
        /// </summary>
        /// <returns></returns>
        /*public async Task<CreateAudienceGroupResponseModel> AddAudienceToAudienceGroupAsync()
        {
            //POST /upload
        }*/

        /// <summary>
        /// Add user IDs or Identifiers for Advertisers (IFAs) to an audience for uploading user IDs.
        /// </summary>
        /// <param name="addAudienceGroupRequestModel">AddAudienceToAudienceGroupRequestModel</param>
        /// <returns></returns>
        public async Task AddAudienceToAudienceGroupAsync(AddAudienceToAudienceGroupRequestModel addAudienceGroupRequestModel)
        {
            //PUT /upload
            string url = MessagingApiUrl.AudienceGroupUrl + "/upload";
            string jsonString = JsonConvert.SerializeObject(addAudienceGroupRequestModel, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.None });

            await Utility.DoLineHttpPutAsync(url, jsonString, accessToken);
        }

        /// <summary>
        /// Create audience for click-based retargeting.
        /// </summary>
        /// <param name="clickBasedRequestModel">CreateClickBasedAudienceGroupRequestModel</param>
        /// <returns></returns>
        public async Task<CreateClickBasedAudienceGroupResponseModel> CreateClickBasedAudienceGroupAsync(CreateClickBasedAudienceGroupRequestModel clickBasedRequestModel)
        {
            //POST /click
            string url = MessagingApiUrl.AudienceGroupUrl + "/click";
            string jsonString = JsonConvert.SerializeObject(clickBasedRequestModel, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.None });
            string apiResult = null;
            CreateClickBasedAudienceGroupResponseModel responseModel = new CreateClickBasedAudienceGroupResponseModel();

            apiResult = await Utility.DoLineHttpPostAsync(url, jsonString, accessToken);
            responseModel = JsonConvert.DeserializeObject<CreateClickBasedAudienceGroupResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// Create audience for impression-based retargeting.
        /// </summary>
        /// <param name="createImpressionBased">CreateImpressionBasedAudienceGroupRequestModel</param>
        /// <returns></returns>
        public async Task<CreateImpressionBasedAudienceGroupResponseModel> CreateImpressionBasedAudienceAsync(CreateImpressionBasedAudienceGroupRequestModel createImpressionBased)
        {
            //POST /imp
            string url = MessagingApiUrl.AudienceGroupUrl + "/imp";
            string jsonString = JsonConvert.SerializeObject(createImpressionBased, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.None });
            string apiResult = null;
            CreateImpressionBasedAudienceGroupResponseModel responseModel = new CreateImpressionBasedAudienceGroupResponseModel();

            apiResult = await Utility.DoLineHttpPostAsync(url, jsonString, accessToken);
            responseModel = JsonConvert.DeserializeObject<CreateImpressionBasedAudienceGroupResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// Rename an audience.
        /// </summary>
        /// <param name="renameRequestModel">RenameAnAudienceRequestModel</param>
        /// <returns></returns>
        public async Task RenameAnAudienceAsync(RenameAnAudienceRequestModel renameRequestModel)
        {
            //PUT /{audienceGroupId}/updateDescription
            string url = MessagingApiUrl.AudienceGroupUrl + "/" + renameRequestModel.audienceGroupId + "/updateDescription";
            string jsonString = JsonConvert.SerializeObject(renameRequestModel, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.None });

            await Utility.DoLineHttpPutAsync(url, jsonString, accessToken);
        }

        /// <summary>
        /// Delete audience.
        /// </summary>
        /// <param name="audienceGroupId">Audience GroupId</param>
        /// <returns></returns>
        public async Task DeleteAudienceGroupAsync(long audienceGroupId)
        {
            //DELETE /{audienceGroupId}
            string url = MessagingApiUrl.AudienceGroupUrl;
            string para = $"/{audienceGroupId}";

            await Utility.DoLineHttpDeleteAsync(url, para, accessToken);
        }

        /// <summary>
        /// Get audience data.
        /// </summary>
        /// <param name="audienceGroupId">Audience GroupId</param>
        /// <returns></returns>
        public async Task<GetAudienceDataResponseModel> GetAudienceDataAsync(long audienceGroupId)
        {
            //GET /{audienceGroupId}
            GetAudienceDataResponseModel responseModel = new GetAudienceDataResponseModel();
            string para = $"/{audienceGroupId}";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.MessageUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<GetAudienceDataResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// Get data for multiple audiences.
        /// </summary>
        /// <param name="getAudienceGroupsRequestModel">GetAudienceGroupsRequestModel</param>
        /// <returns></returns>
        public async Task<GetAudienceGroupsResponseModel> GetAudienceGroupsAsync(GetAudienceGroupsRequestModel getAudienceGroupsRequestModel)
        {
            //GET /list
            GetAudienceGroupsResponseModel responseModel = new GetAudienceGroupsResponseModel();
            string para = $"/list?page={getAudienceGroupsRequestModel.page}&description={getAudienceGroupsRequestModel.description}&status={getAudienceGroupsRequestModel.status}"
                + $"&size={getAudienceGroupsRequestModel.size}&includesExternalPublicGroups={getAudienceGroupsRequestModel.includesExternalPublicGroups}&createRoute={getAudienceGroupsRequestModel.createRoute}";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.MessageUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<GetAudienceGroupsResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// Get the authority level of the audience.
        /// </summary>
        /// <returns></returns>
        public async Task<GetAudienceGroupAuthorityLevelResponseModel> GetAudienceGroupAuthorityLevelAsync()
        {
            //GET /authorityLevel
            GetAudienceGroupAuthorityLevelResponseModel responseModel = new GetAudienceGroupAuthorityLevelResponseModel();
            string para = $"/authorityLevel";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.MessageUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<GetAudienceGroupAuthorityLevelResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// Change the authority level of the audience.
        /// </summary>
        /// <param name="changeAudienceAuthorityLevelRequestModel">ChangeTheAuthorityLevelOfTheAudienceRequestModel</param>
        /// <returns></returns>
        public async Task ChangeAudienceAuthorityLevel(ChangeTheAuthorityLevelOfTheAudienceRequestModel changeAudienceAuthorityLevelRequestModel)
        {
            //PUT /authorityLevel
            string url = MessagingApiUrl.AudienceGroupUrl + "/authorityLevel";
            string jsonString = JsonConvert.SerializeObject(changeAudienceAuthorityLevelRequestModel, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.None });

            await Utility.DoLineHttpPutAsync(url, jsonString, accessToken);
        }

        #endregion

        #region insight

        /// <summary>
        /// 取得特定日期Line官方帳號回傳訊息的數量
        /// </summary>
        /// <param name="date">日期(yyyyMMdd)</param>
        /// <returns>NumberOfMessageDeliveriesResponseModel</returns>
        public async Task<NumberOfMessageDeliveriesResponseModel> GetNumberOfMessageDeliveriesAsync(string date)
        {
            NumberOfMessageDeliveriesResponseModel responseModel = new NumberOfMessageDeliveriesResponseModel();
            string para = $"/message/delivery?date={date}";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.InsightUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<NumberOfMessageDeliveriesResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// 取得特定日期加Line官方帳號為好友的數量
        /// </summary>
        /// <param name="date">日期(yyyyMMdd)</param>
        /// <returns>NumberOfFollowersResponseModel</returns>
        public async Task<NumberOfFollowersResponseModel> GetNumberOfFollowersAsync(string date)
        {
            NumberOfFollowersResponseModel responseModel = new NumberOfFollowersResponseModel();
            string para = $"/followers?date={date}";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.InsightUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<NumberOfFollowersResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// 取得好友統計資料
        /// </summary>
        /// <returns>FriendDemographicsResponseModel</returns>
        public async Task<FriendDemographicsResponseModel> GetFriendDemographicsAsync()
        {
            FriendDemographicsResponseModel responseModel = new FriendDemographicsResponseModel();
            string para = $"/demographic";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.InsightUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<FriendDemographicsResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// 取得發送廣播訊息後使用者的動作統計資料(14天內)
        /// </summary>
        /// <param name="requestId">廣播訊息的Request ID。(為Reponse Header中X-Line-Request-Id的Requert ID)</param>
        /// <returns>UserInteractionStatisticsResponseModel</returns>
        public async Task<UserInteractionStatisticsResponseModel> GetUserInteractionStatisticsAsync(string requestId)
        {
            UserInteractionStatisticsResponseModel responseModel = new UserInteractionStatisticsResponseModel();
            string para = $"/message/event?requestId={requestId}";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.InsightUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<UserInteractionStatisticsResponseModel>(apiResult);

            return responseModel;
        }

        #endregion

        #region  profile

        /// <summary>
        /// 取得使用者個人資料
        /// </summary>
        /// <param name="userId">userId</param>
        /// <returns>UserProfileResponseModel</returns>
        public async Task<UserProfileResponseModel> GetProfileAsync(string userId)
        {
            UserProfileResponseModel responseModel = new UserProfileResponseModel();
            string apiResult = null;
            string para = $"/{userId}";

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.ProfileUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<UserProfileResponseModel>(apiResult);

            return responseModel;
        }

        #endregion

        #region  room

        /// <summary>
        /// [未測試][認證帳號/高級帳號]取得特定聊天室內所有使用者ID
        /// </summary>
        /// <param name="roomId">roomId</param>
        /// <returns></returns>
        public async Task<List<string>> GetRoomMemberUserIDsAsync(string roomId)
        {
            /*一次最多可以取100筆資料,超過100筆會回傳continuationToken(在next欄位)
              next欄位有資料就用continautaionToken再取一次,此時的api要加參數start
              直到next欄位為空值就停止取的資料
            */
            List<string> memberIdList = new List<string>();
            MembersIdsResponseModel responseModel = new MembersIdsResponseModel();
            string memberId = null;
            string apiResult = null;
            string continuationToken = null;
            string para = $"/{roomId}/members/ids";

            do
            {
                if (string.IsNullOrWhiteSpace(continuationToken))
                {
                    para = $"/{roomId}/members/ids";
                    apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.RoomUrl, para, accessToken);
                }
                else
                {
                    para = $"/{roomId}/members/ids" + $"?start={continuationToken}";
                    continuationToken = null;
                    apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.RoomUrl, para, accessToken);
                }

                responseModel = JsonConvert.DeserializeObject<MembersIdsResponseModel>(apiResult);
                continuationToken = responseModel.next;

                foreach (var q in responseModel.memberIds)
                {
                    memberId = q;
                    memberIdList.Add(memberId);
                }

            } while (!string.IsNullOrWhiteSpace(continuationToken));

            return memberIdList;
        }

        /// <summary>
        /// [未測試]取得特定聊天室中特定使用者的個人資料
        /// </summary>
        /// <param name="roomId">roomId</param>
        /// <param name="userId">userId</param>
        /// <returns>UserProfileResponseModel</returns>
        public async Task<UserProfileResponseModel> GetRoomMemberProfileAsync(string roomId, string userId)
        {
            UserProfileResponseModel responseModel = new UserProfileResponseModel();
            string apiResult = null;
            string para = $"/{roomId}/member/{userId}";

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.RoomUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<UserProfileResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// [未測試]離開特定聊天室
        /// </summary>
        /// <param name="roomId">roomId</param>
        /// <returns></returns>
        public async Task LeaveRoomAsync(string roomId)
        {
            string para = $"/{roomId}/leave";

            await Utility.DoLineHttpGetAsync(MessagingApiUrl.RoomUrl, para, accessToken);
        }

        #endregion

        #region  group

        /// <summary>
        /// [未測試][認證帳號/高級帳號]取得特定群組所有內使用者ID
        /// </summary>
        /// <param name="groupId">groupId</param>
        /// <returns></returns>
        public async Task<List<string>> GetGroupMemberUserIDsAsync(string groupId)
        {
            /*一次最多可以取100筆資料,超過100筆會回傳continuationToken(在next欄位)
              next欄位有資料就用continautaionToken再取一次,此時的api要加參數start
              直到next欄位為空值就停止取的資料
            */
            List<string> memberIdList = new List<string>();
            MembersIdsResponseModel responseModel = new MembersIdsResponseModel();
            string memberId = null;
            string apiResult = null;
            string continuationToken = null;
            string para = $"/{groupId}/members/ids";

            do
            {
                if (string.IsNullOrWhiteSpace(continuationToken))
                {
                    para = $"/{groupId}/members/ids";
                    apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.GroupUrl, para, accessToken);
                }
                else
                {
                    para = $"/{groupId}/members/ids" + $"?start={continuationToken}";
                    continuationToken = null;
                    apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.GroupUrl, para, accessToken);
                }

                responseModel = JsonConvert.DeserializeObject<MembersIdsResponseModel>(apiResult);
                continuationToken = responseModel.next;

                foreach (var q in responseModel.memberIds)
                {
                    memberId = q;
                    memberIdList.Add(memberId);
                }

            } while (!string.IsNullOrWhiteSpace(continuationToken));

            return memberIdList;
        }

        /// <summary>
        /// [未測試]取得特定群組中特定使用者的個人資料
        /// </summary>
        /// <param name="groupId">groupId</param>
        /// <param name="userId">userId</param>
        /// <returns>UserProfileResponseModel</returns>
        public async Task<UserProfileResponseModel> GetGroupMemberProfileAsync(string groupId, string userId)
        {
            UserProfileResponseModel responseModel = new UserProfileResponseModel();
            string apiResult = null;
            string para = $"/{groupId}/member/{userId}";

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.GroupUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<UserProfileResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// [未測試]離開特定群組
        /// </summary>
        /// <param name="groupId">groupId</param>
        /// <returns></returns>
        public async Task LeaveGroupAsync(string groupId)
        {
            string para = $"/{groupId}/leave";

            await Utility.DoLineHttpGetAsync(MessagingApiUrl.GroupUrl, para, accessToken);
        }

        #endregion

        #region richmenu

        /// <summary>
        /// Creates a rich menu.
        /// </summary>
        /// <param name="richMenuModel">RichMenuModel</param>
        /// <returns></returns>
        public async Task<RichMenuResponseModel> CreateRichMenuAsync(RichMenuModel richMenuModel)
        {
            //POST
            RichMenuResponseModel responseModel = new RichMenuResponseModel();
            string apiResult = null;
            string jsonString = JsonConvert.SerializeObject(richMenuModel);

            apiResult = await Utility.DoLineHttpPostAsync(MessagingApiUrl.RichMenuUrl, jsonString, accessToken);
            responseModel = JsonConvert.DeserializeObject<RichMenuResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// Uploads and attaches an image to a rich menu.
        /// </summary>
        /// <param name="richMenuId">The ID of the rich menu to attach the image to</param>
        /// <returns></returns>
        /*public async Task UploadRichMenuImageAsync(string richMenuId)
        {
            //POST
            //Content-Type	image/jpeg or image/png
            string para = $"/{richMenuId}/content";

            //https://api-data.line.me/v2/bot
            MessagingApiUrl.RichMenuUrl;
        }*/

        /// <summary>
        /// Gets a list of the rich menu response object of all rich menus created by Create a rich menu.
        /// (https://developers.line.biz/zh-hant/reference/messaging-api/#create-rich-menu)
        /// </summary>
        /// <returns></returns>
        public async Task<List<RichMenuResponseModel>> GetRichMenuListAsync()
        {
            //GET
            List<RichMenuResponseModel> responseModel = new List<RichMenuResponseModel>();
            string para = $"/list";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.RichMenuUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<List<RichMenuResponseModel>>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// Gets a rich menu via a rich menu ID.
        /// </summary>
        /// <param name="richMenuId">ID of a rich menu</param>
        /// <returns></returns>
        public async Task<RichMenuResponseModel> GetRichMenuAsync(string richMenuId)
        {
            //GET
            RichMenuResponseModel responseModel = new RichMenuResponseModel();
            string para = $"/{richMenuId}";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.RichMenuUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<RichMenuResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// Deletes a rich menu.
        /// </summary>
        /// <param name="richMenuId">ID of a rich menu</param>
        /// <returns></returns>
        public async Task DeleteRichMenuAsync(string richMenuId)
        {
            //DELETE
            string para = $"/{richMenuId}";

            await Utility.DoLineHttpDeleteAsync(MessagingApiUrl.RichMenuUrl, para, accessToken);
        }

        /// <summary>
        /// Sets the default rich menu.
        /// The default rich menu is displayed to all users who have added your LINE Official Account as a friend and are not linked to any per-user rich menu.
        /// If a default rich menu has already been set, calling this endpoint replaces the current default rich menu with the one specified in your request.
        /// </summary>
        /// <param name="richMenuId">ID of a rich menu</param>
        /// <returns></returns>
        public async Task SetDefaultRichMenuAsync(string richMenuId)
        {
            //POST
            string para = $"/all/richmenu/{richMenuId}";
            string fullUrl = MessagingApiUrl.UserSettingUrl + para;

            await Utility.DoLineHttpPostAsync(fullUrl, null, accessToken);
        }

        /// <summary>
        /// Gets the ID of the default rich menu set with the Messaging API.
        /// </summary>
        /// <returns></returns>
        public async Task<RichMenuResponseModel> GetDefaultRichMenuIDAsync()
        {
            //GET
            RichMenuResponseModel responseModel = new RichMenuResponseModel();
            string para = $"/all/richmenu";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.UserSettingUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<RichMenuResponseModel>(apiResult);

            return responseModel;
        }

        /// <summary>
        /// Cancels the default rich menu set with the Messaging API.
        /// </summary>
        /// <returns></returns>
        public async Task CancelDefaultRichMenuAsync()
        {
            //DELETE
            string para = $"/all/richmenu";

            await Utility.DoLineHttpDeleteAsync(MessagingApiUrl.UserSettingUrl, para, accessToken);
        }

        /// <summary>
        /// Links a rich menu to a user.
        /// Only one rich menu can be linked to a user at one time.
        /// If a user already has a rich menu linked, calling this endpoint replaces the existing rich menu with the one specified in your request.
        /// </summary>
        /// <param name="richMenuId">ID of a rich menu</param>
        /// <param name="userId">User ID. Found in the source object of webhook event objects. Do not use the LINE ID used in LINE.</param>
        /// <returns></returns>
        public async Task LinkRichMenuToUserAsync(string richMenuId, string userId)
        {
            //POST
            string para = $"/{userId}/richmenu/{richMenuId}";
            string fullUrl = MessagingApiUrl.UserSettingUrl + para;

            await Utility.DoLineHttpPostAsync(fullUrl, null, accessToken);
        }

        /// <summary>
        /// Links a rich menu to multiple users.
        /// </summary>
        /// <param name="bulkLinkRequestModel">RichMenuBulkLinkRequestModel</param>
        /// <returns></returns>
        public async Task LinkRichMenuToMultipleUsersAsync(RichMenuBulkLinkRequestModel bulkLinkRequestModel)
        {
            //POST
            string para = $"/bulk/link";
            string fullUrl = MessagingApiUrl.RichMenuUrl + para;

            string jsonString = JsonConvert.SerializeObject(bulkLinkRequestModel);

            await Utility.DoLineHttpPostAsync(fullUrl, jsonString, accessToken);
        }

        /// <summary>
        /// Gets the ID of the rich menu linked to a user.
        /// </summary>
        /// <param name="userId">User ID. Found in the source object of webhook event objects. Do not use the LINE ID used in LINE.</param>
        /// <returns></returns>
        public async Task<string> GetRichMenuIDOfUserAsync(string userId)
        {
            //GET
            RichMenuResponseModel responseModel = new RichMenuResponseModel();
            string para = $"/{userId}/richMenu";
            string apiResult = null;

            apiResult = await Utility.DoLineHttpGetAsync(MessagingApiUrl.UserSettingUrl, para, accessToken);
            responseModel = JsonConvert.DeserializeObject<RichMenuResponseModel>(apiResult);

            return responseModel.richMenuId;
        }

        /// <summary>
        /// Unlinks a rich menu from a user.
        /// </summary>
        /// <param name="userId">User ID. Found in the source object of webhook event objects. Do not use the LINE ID used in LINE.</param>
        /// <returns></returns>
        public async Task UnlinkRichMenuFromUserAsync(string userId)
        {
            //DELETE
            string para = $"/{userId}/richMenu";

            await Utility.DoLineHttpDeleteAsync(MessagingApiUrl.UserSettingUrl, para, accessToken);
        }

        /// <summary>
        /// Unlinks rich menus from multiple users.
        /// </summary>
        /// <param name="unlinkRequestModel">Array of user IDs. Found in the source object of webhook event objects. Do not use the LINE ID used in LINE.Max: 500 user IDs</param>
        /// <returns></returns>
        public async Task UnlinkRichMenusFromMultipleUsersAsync(RichMenuBulkUnlinkRequestModel unlinkRequestModel)
        {
            //POST
            string para = $"/bulk/unlink";
            string fullUrl = MessagingApiUrl.RichMenuUrl + para;

            string jsonString = JsonConvert.SerializeObject(unlinkRequestModel);

            await Utility.DoLineHttpPostAsync(fullUrl, jsonString, accessToken);
        }

        #endregion
    }
}
