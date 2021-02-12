using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LineMessagingAPI.Models.Action;
using LineMessagingAPI.Models.Message;
using LineMessagingAPI.Models.Message.QuickReply;
using LineMessagingAPI.Models.Response;
using LineMessagingAPI.Models.Response.Demographic;
using LineBotSample.Models.SampleFlexMessage;
using LineBotSample.Models.SampleTemplateMessage;
using Newtonsoft.Json;
using LineMessagingAPI;

namespace LineBotSample.Models
{
    public class SpecificTextMessage
    {
        private readonly LineMessagingClient _lineClient;

        public SpecificTextMessage(LineMessagingClient lineClient)
        {
            _lineClient = lineClient;
        }

        /// <summary>
        /// 回覆文字訊息
        /// </summary>
        /// <param name="receiveText">接收到的文字訊息</param>
        public async Task<MessageModel> ReplySpecificText(string receiveText)
        {
            TextMessageModel textMessage = new TextMessageModel();
            FlexMessageModel flexMessage = new FlexMessageModel();

            if (receiveText.Contains("指令"))
            {
                textMessage.text = CommandTips;
                return textMessage;
            }
            else if (receiveText.Contains("用途"))
            {
                textMessage.text = ApplicationTips;
                return textMessage;
            }
            else if (receiveText.Contains("額外訊息目標數"))
            {
                textMessage.text = await GetTargetLimitOfAdditionMessagesTips();
                return textMessage;
            }
            else if (receiveText.Contains("本月已發送訊息數"))
            {
                textMessage.text = await GetNumberOfMessagesSentThisMonthTips();
                return textMessage;
            }
            else if (receiveText.Contains("回覆訊息數"))
            {
                textMessage.text = await GetNumberOfSentReplyMessagesTips(receiveText);
                return textMessage;
            }
            else if (receiveText.Contains("推送訊息數"))
            {
                textMessage.text = await GetNumberOfSentPushMessagesTips(receiveText);
                return textMessage;
            }
            else if (receiveText.Contains("群發訊息數"))
            {
                textMessage.text = await GetNumberOfSentMulticastMessagesTips(receiveText);
                return textMessage;
            }
            else if (receiveText.Contains("廣播訊息數"))
            {
                textMessage.text = await GetNumberOfSentBroadcastMessagesTips(receiveText);
                return textMessage;
            }
            else if (receiveText.Contains("統計訊息數"))
            {
                textMessage.text = await GetNumberOfMessageDeliveriesTips(receiveText);
                return textMessage;
            }
            else if (receiveText.Contains("統計好友數"))
            {
                textMessage.text = await GetNumberOfFollowersTips(receiveText);
                return textMessage;
            }
            else if (receiveText.Contains("好友統計資料"))
            {
                textMessage.text = await GetFriendDemographicsTips();
                return textMessage;
            }
            else if (receiveText.Contains("快速回覆"))
            {
                textMessage.text = "請選擇下面的快速回覆按鈕";
                textMessage.quickReply = GetQuickReplyModel();
                return textMessage;
            }
            else if (receiveText.Contains("購物"))
            {
                ApparelFlexMessage flexMessageSample = new ApparelFlexMessage();
                flexMessage.altText = "購物";
                flexMessage.contents = flexMessageSample.Create();
                return flexMessage;
            }
            else if (receiveText.Equals("課程"))
            {
                return GetTemplateMessage();
            }
            else if (receiveText.Contains("優惠課程") || receiveText.Contains("最新課程") || receiveText.Contains("熱門課程"))
            {
                PromotionCourseFlexMessage buyInPromotionCourseFlexMessage = new PromotionCourseFlexMessage();
                flexMessage.altText = "優惠課程";
                flexMessage.contents = buyInPromotionCourseFlexMessage.Create();
                return flexMessage;
            }
            else
            {
                textMessage.text = receiveText;
                return textMessage; //重複使用者的話
            }
        }

        /// <summary>
        /// 回覆文字訊息(回傳Json)
        /// </summary>
        /// <param name="receiveText">接收到的文字訊息</param>
        public async Task<string> ReplySpecificTextWithJson(string receiveText)
        {
            TextMessageModel textMessage = new TextMessageModel();
            FlexMessageModel flexMessage = new FlexMessageModel();

            if (receiveText.Contains("指令"))
            {
                textMessage.text = CommandTips;
                return JsonConvert.SerializeObject(textMessage);
            }
            else if (receiveText.Contains("用途"))
            {
                textMessage.text = ApplicationTips;
                return JsonConvert.SerializeObject(textMessage);
            }
            else if (receiveText.Contains("額外訊息目標數"))
            {
                textMessage.text = await GetTargetLimitOfAdditionMessagesTips();
                return JsonConvert.SerializeObject(textMessage);
            }
            else if (receiveText.Contains("本月已發送訊息數"))
            {
                textMessage.text = await GetNumberOfMessagesSentThisMonthTips();
                return JsonConvert.SerializeObject(textMessage);
            }
            else if (receiveText.Contains("回覆訊息數"))
            {
                textMessage.text = await GetNumberOfSentReplyMessagesTips(receiveText);
                return JsonConvert.SerializeObject(textMessage);
            }
            else if (receiveText.Contains("推送訊息數"))
            {
                textMessage.text = await GetNumberOfSentPushMessagesTips(receiveText);
                return JsonConvert.SerializeObject(textMessage);
            }
            else if (receiveText.Contains("群發訊息數"))
            {
                textMessage.text = await GetNumberOfSentMulticastMessagesTips(receiveText);
                return JsonConvert.SerializeObject(textMessage);
            }
            else if (receiveText.Contains("廣播訊息數"))
            {
                textMessage.text = await GetNumberOfSentBroadcastMessagesTips(receiveText);
                return JsonConvert.SerializeObject(textMessage);
            }
            else if (receiveText.Contains("統計訊息數"))
            {
                textMessage.text = await GetNumberOfMessageDeliveriesTips(receiveText);
                return JsonConvert.SerializeObject(textMessage);
            }
            else if (receiveText.Contains("統計好友數"))
            {
                textMessage.text = await GetNumberOfFollowersTips(receiveText);
                return JsonConvert.SerializeObject(textMessage);
            }
            else if (receiveText.Contains("好友統計資料"))
            {
                textMessage.text = await GetFriendDemographicsTips();
                return JsonConvert.SerializeObject(textMessage);
            }
            else if (receiveText.Contains("快速回覆"))
            {
                textMessage.text = "請選擇下面的快速回覆按鈕";
                textMessage.quickReply = GetQuickReplyModel();
                return JsonConvert.SerializeObject(textMessage);
            }
            else if (receiveText.Contains("購物"))
            {
                ApparelFlexMessage flexMessageSample = new ApparelFlexMessage();
                flexMessage.altText = "購物";
                flexMessage.contents = flexMessageSample.Create();
                return JsonConvert.SerializeObject(flexMessage);
            }
            else if (receiveText.Equals("課程"))
            {
                return JsonConvert.SerializeObject(GetTemplateMessage());
            }
            else if (receiveText.Contains("優惠課程") || receiveText.Contains("最新課程") || receiveText.Contains("熱門課程"))
            {
                PromotionCourseFlexMessage buyInPromotionCourseFlexMessage = new PromotionCourseFlexMessage();
                //flexMessage.altText = "優惠課程";
                //flexMessage.contents = buyInPromotionCourseFlexMessage.Create();
                //return JsonConvert.SerializeObject(flexMessage);

                return buyInPromotionCourseFlexMessage.CreateWithJson();
            }
            else
            {
                textMessage.text = receiveText;
                return JsonConvert.SerializeObject(textMessage); //重複使用者的話
            }
        }

        /// <summary>
        /// 收到 "指令" 後會回覆的文字 
        /// </summary>
        private string CommandTips
        {
            get
            {
                return @"輸入「額外訊息目標數」：
可取得訊息目標數量。

輸入「本月已發送訊息數」：
可取得本月已發送訊息的數量。

輸入「回覆訊息數.yyyyMMdd」：
可取得該日期使用reply回覆訊息的數量。

輸入「推送訊息數.yyyyMMdd」：
可取得該日期使用push推送訊息的數量。

輸入「群發訊息數.yyyyMMdd」：
可取得該日期使用multicast群發訊息的數量。

輸入「廣播訊息數.yyyyMMdd」：
可取得該日期使用broadcast廣播訊息的數量。

輸入「統計訊息數.yyyyMMdd」：
可取得該日期所有訊息種類的使用量。

輸入「統計好友數.yyyyMMdd」：
可取得該日期所有好友數量相關資料。

輸入「好友統計資料」：
可取得好友統計資料。

輸入「快速回覆」：
可取得快速回覆按鈕。

輸入「課程」：
可取得樣板訊息。

輸入「購物」、「優惠課程」：
可取得Flex Message";
            }
        }

        /// <summary>
        /// 收到 "用途" 後會回覆的文字 
        /// </summary>
        private string ApplicationTips
        {
            get
            {
                return @"發送文字：回覆你剛剛發送的文字
發送貼圖：回覆你剛剛發送的貼圖";
            }
        }

        /// <summary>
        /// 收到 "額外訊息目標數" 後會回覆的文字 
        /// </summary>
        private async Task<string> GetTargetLimitOfAdditionMessagesTips()
        {
            string result = "";
            TargetLimitForAdditionalMessagesResponseModel responseModel = new TargetLimitForAdditionalMessagesResponseModel();

            responseModel = await _lineClient.GetTheTargetLimitForAdditionsMessagesAsync();

            switch (responseModel.type)
            {
                case TargetLimitForAdditionalMessagesType.none:
                    result = "未設定";
                    break;
                case TargetLimitForAdditionalMessagesType.limited:
                    result = $"目標數量為 : {responseModel.value}";
                    break;
                default:
                    result = "發生異常，暫時無法查詢";
                    break;
            }

            return result;
        }

        /// <summary>
        /// 收到 "本月已發送訊息數" 後會回覆的文字
        /// </summary>
        /// <returns></returns>
        private async Task<string> GetNumberOfMessagesSentThisMonthTips()
        {
            string result = "";
            NumberOfMessagesSentThisMonthResponseModel responseModel = new NumberOfMessagesSentThisMonthResponseModel();

            responseModel = await _lineClient.GetNumberOfMessagesSentThisMonthAsync();

            result = $"本月已發送訊息的數量為 : {responseModel.totalUsage}";

            return result;
        }

        /// <summary>
        /// 收到 "回覆訊息數" 後會回覆的文字
        /// </summary>
        /// <param name="receiveText">接收到的訊息</param>
        /// <returns></returns>
        private async Task<string> GetNumberOfSentReplyMessagesTips(string receiveText)
        {
            string result = "";
            NumberOfSentReplyMessagesResponseModel responseModel = new NumberOfSentReplyMessagesResponseModel();

            int position = receiveText.IndexOf(".");
            string date = null;
            if (position != -1)
            {
                date = receiveText.Substring(position + 1);
            }
            else
            {
                date = DateTime.Now.ToString("yyyyMMdd");
                result = @"輸入的格式有誤。
請輸入「回覆訊息數.yyyyMMdd」
例如：回覆訊息數.20200101";

                return result;
            }

            responseModel = await _lineClient.GetNumberOfSentReplyMessagesAsync(date);

            switch (responseModel.status)
            {
                case NumberOfSentReplyMessagesStatus.ready:
                    result = $"{date} 使用reply回覆訊息的數量為 : {responseModel.success}";
                    break;
                case NumberOfSentReplyMessagesStatus.unready:
                    result = "該日的資料尚未統計完成";
                    break;
                case NumberOfSentReplyMessagesStatus.out_of_service:
                    result = "日期格式有誤";
                    break;
                default:
                    result = "發生異常，暫時無法查詢";
                    break;
            }

            return result;
        }

        /// <summary>
        /// 收到 "推送訊息數" 後會回覆的文字
        /// </summary>
        /// <param name="receiveText">接收到的訊息</param>
        /// <returns></returns>
        private async Task<string> GetNumberOfSentPushMessagesTips(string receiveText)
        {
            string result = "";
            NumberOfSentPushMessagesResponseModel responseModel = new NumberOfSentPushMessagesResponseModel();

            int position = receiveText.IndexOf(".");
            string date = null;
            if (position != -1)
            {
                date = receiveText.Substring(position + 1);
            }
            else
            {
                date = DateTime.Now.ToString("yyyyMMdd");
                result = @"輸入的格式有誤。
請輸入「推送訊息數.yyyyMMdd」
例如：推送訊息數.20200101";

                return result;
            }

            responseModel = await _lineClient.GetNumberOfSentPushMessagesAsync(date);

            switch (responseModel.status)
            {
                case NumberOfSentPushMessagesStatus.ready:
                    result = $"{date} 使用push推送訊息的數量為 : {responseModel.success}";
                    break;
                case NumberOfSentPushMessagesStatus.unready:
                    result = "該日的資料尚未統計完成";
                    break;
                case NumberOfSentPushMessagesStatus.out_of_service:
                    result = "日期格式有誤";
                    break;
                default:
                    result = "發生異常，暫時無法查詢";
                    break;
            }

            return result;
        }

        /// <summary>
        /// 收到 "群發訊息數" 後會回覆的文字
        /// </summary>
        /// <param name="receiveText">接收到的訊息</param>
        /// <returns></returns>
        private async Task<string> GetNumberOfSentMulticastMessagesTips(string receiveText)
        {
            string result = "";
            NumberOfSentMulticastMessagesResponseModel responseModel = new NumberOfSentMulticastMessagesResponseModel();

            int position = receiveText.IndexOf(".");
            string date = null;
            if (position != -1)
            {
                date = receiveText.Substring(position + 1);
            }
            else
            {
                date = DateTime.Now.ToString("yyyyMMdd");
                result = @"輸入的格式有誤。
請輸入「群發訊息數.yyyyMMdd」
例如：群發訊息數.20200101";

                return result;
            }

            responseModel = await _lineClient.GetNumberOfSentMulticastMessagesAsync(date);

            switch (responseModel.status)
            {
                case NumberOfSentMulticastMessagesStatus.ready:
                    result = $"{date} 使用multicast群發訊息的數量為 : {responseModel.success}";
                    break;
                case NumberOfSentMulticastMessagesStatus.unready:
                    result = "該日的資料尚未統計完成";
                    break;
                case NumberOfSentMulticastMessagesStatus.out_of_service:
                    result = "日期格式有誤";
                    break;
                default:
                    result = "發生異常，暫時無法查詢";
                    break;
            }

            return result;
        }

        /// <summary>
        /// 收到 "廣播訊息數" 後會回覆的文字
        /// </summary>
        /// <param name="receiveText">接收到的訊息</param>
        /// <returns></returns>
        private async Task<string> GetNumberOfSentBroadcastMessagesTips(string receiveText)
        {
            string result = "";
            NumberOfSentBroadcastMessagesResponseModel responseModel = new NumberOfSentBroadcastMessagesResponseModel();

            int position = receiveText.IndexOf(".");
            string date = null;
            if (position != -1)
            {
                date = receiveText.Substring(position + 1);
            }
            else
            {
                date = DateTime.Now.ToString("yyyyMMdd");
                result = @"輸入的格式有誤。
請輸入「廣播訊息數.yyyyMMdd」
例如：廣播訊息數.20200101";

                return result;
            }

            responseModel = await _lineClient.GetNumberOfSentBroadcastMessagesAsync(date);

            switch (responseModel.status)
            {
                case NumberOfSentBroadcastMessagesStatus.ready:
                    result = $"{date} 使用broadcast廣播訊息的數量為 : {responseModel.success}";
                    break;
                case NumberOfSentBroadcastMessagesStatus.unready:
                    result = "該日的資料尚未統計完成";
                    break;
                case NumberOfSentBroadcastMessagesStatus.out_of_service:
                    result = "日期格式有誤";
                    break;
                default:
                    result = "發生異常，暫時無法查詢";
                    break;
            }

            return result;
        }

        /// <summary>
        /// 收到 "統計訊息數" 後會回覆的文字
        /// </summary>
        /// <param name="receiveText">接收到的訊息</param>
        /// <returns></returns>
        private async Task<string> GetNumberOfMessageDeliveriesTips(string receiveText)
        {
            string result = "";
            NumberOfMessageDeliveriesResponseModel responseModel = new NumberOfMessageDeliveriesResponseModel();

            int position = receiveText.IndexOf(".");
            string date = null;
            if (position != -1)
            {
                date = receiveText.Substring(position + 1);
            }
            else
            {
                date = DateTime.Now.ToString("yyyyMMdd");
                result = @"輸入的格式有誤。
請輸入「統計訊息數.yyyyMMdd」
例如：統計訊息數.20200101";

                return result;
            }

            responseModel = await _lineClient.GetNumberOfMessageDeliveriesAsync(date);

            switch (responseModel.status)
            {
                case NumberOfMessageDeliveriesStatus.ready:
                    result = $@"{date} 訊息統計資料：
廣播：{responseModel.broadcast}
目標發送：{responseModel.targeting}
自動回覆：{responseModel.autoResponse}
歡迎加入：{responseModel.welcomeResponse}
聊天：{responseModel.chat}
API Broadcast：{responseModel.apiBroadcast}
API Push：{responseModel.apiPush}
API Multicast：{responseModel.apiMulticast}
API Reply：{responseModel.apiReply}";
                    break;
                case NumberOfMessageDeliveriesStatus.unready:
                    result = "該日的資料尚未統計完成";
                    break;
                case NumberOfMessageDeliveriesStatus.out_of_service:
                    result = "日期格式有誤";
                    break;
                default:
                    result = "發生異常，暫時無法查詢";
                    break;
            }

            return result;
        }

        /// <summary>
        /// 收到 "統計好友數" 後會回覆的文字
        /// </summary>
        /// <param name="receiveText">接收到的訊息</param>
        /// <returns></returns>
        private async Task<string> GetNumberOfFollowersTips(string receiveText)
        {
            string result = "";
            NumberOfFollowersResponseModel responseModel = new NumberOfFollowersResponseModel();

            int position = receiveText.IndexOf(".");
            string date = null;
            if (position != -1)
            {
                date = receiveText.Substring(position + 1);
            }
            else
            {
                date = DateTime.Now.ToString("yyyyMMdd");
                result = @"輸入的格式有誤。
請輸入「好友數.yyyyMMdd」
例如：好友數.20200101";

                return result;
            }

            responseModel = await _lineClient.GetNumberOfFollowersAsync(date);

            switch (responseModel.status)
            {
                case NumberOfFollowersStatus.ready:
                    result = $@"{date} 好友統計資料：
加入好友：{responseModel.followers}
目標好友：{responseModel.targetedReaches}
封鎖：{responseModel.blocks}";
                    break;
                case NumberOfFollowersStatus.unready:
                    result = "該日的資料尚未統計完成";
                    break;
                case NumberOfFollowersStatus.out_of_service:
                    result = "日期格式有誤";
                    break;
                default:
                    result = "發生異常，暫時無法查詢";
                    break;
            }

            return result;
        }

        /// <summary>
        /// 收到 "好友統計資料" 後會回覆的文字
        /// </summary>
        /// <returns></returns>
        private async Task<string> GetFriendDemographicsTips()
        {
            string result = "";
            FriendDemographicsResponseModel responseModel = new FriendDemographicsResponseModel();

            responseModel = await _lineClient.GetFriendDemographicsAsync();

            if (responseModel.available == true)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("好友統計資料：");

                stringBuilder.Append("\r\n性別相關：");
                foreach (var q in responseModel.genders)
                {
                    stringBuilder.Append("\r\n性別：" + q.gender)
                                 .Append("\r\n比例：" + q.percentage);
                }

                stringBuilder.Append("\r\n年齡相關：");
                foreach (var q in responseModel.ages)
                {
                    stringBuilder.Append("\r\n年齡層：" + q.age)
                                 .Append("\r\n比例：" + q.percentage);
                }

                stringBuilder.Append("\r\n地區相關：");
                foreach (var q in responseModel.areas)
                {
                    stringBuilder.Append("\r\n地區：" + q.area)
                                 .Append("\r\n比例：" + q.percentage);
                }

                stringBuilder.Append("\r\n操作系統相關：");
                foreach (var q in responseModel.appTypes)
                {
                    stringBuilder.Append("\r\n操作系統：" + q.appType)
                                 .Append("\r\n比例：" + q.percentage);
                }

                stringBuilder.Append("\r\n加入好友年資相關：");
                foreach (var q in responseModel.subscriptionPeriods)
                {
                    stringBuilder.Append("\r\n年資：" + q.subscriptionPeriod)
                                 .Append("\r\n比例：" + q.percentage);
                }

                result = stringBuilder.ToString();
            }
            else
            {
                result = "暫時無法查詢";
            }

            return result;
        }

        public QuickReplyModel GetQuickReplyModel()
        {
            QuickReplyModel quickReplyModel = new QuickReplyModel();
            List<QuickReplyItemModel> quickReplyItemModelList = new List<QuickReplyItemModel>();

            CameraActionModel cameraAction = new CameraActionModel()
            {
                label = "相機"
            };
            QuickReplyItemModel cameraItem = new QuickReplyItemModel()
            {
                action = cameraAction
            };
            quickReplyItemModelList.Add(cameraItem);

            CameraRollActionModel cameraRollAction = new CameraRollActionModel()
            {
                label = "相機膠捲"
            };
            QuickReplyItemModel cameraRollItem = new QuickReplyItemModel()
            {
                action = cameraRollAction
            };
            quickReplyItemModelList.Add(cameraRollItem);

            LocationActionModel locationAction = new LocationActionModel()
            {
                label = "目前位置"
            };
            QuickReplyItemModel locationItem = new QuickReplyItemModel()
            {
                action = locationAction
            };
            quickReplyItemModelList.Add(locationItem);

            DatetimePickerActionModel datetimePickerAction = new DatetimePickerActionModel()
            {
                label = "日期",
                data = "abc=1234",
                mode = DatetimePickerActionMode.date,
                initial = "2019-12-17"
            };
            QuickReplyItemModel datetimePickerItem = new QuickReplyItemModel()
            {
                action = datetimePickerAction
            };
            quickReplyItemModelList.Add(datetimePickerItem);

            MessageActionModel messageAction = new MessageActionModel()
            {
                label = "訊息",
                text = "你好"
            };
            QuickReplyItemModel messageItem = new QuickReplyItemModel()
            {
                action = messageAction
            };
            quickReplyItemModelList.Add(messageItem);

            quickReplyModel.items = quickReplyItemModelList;

            return quickReplyModel;
        }

        public TemplateMessageModel GetTemplateMessage()
        {
            TemplateMessageModel templateMessageModel = new CourseTemplateMessage().Create();

            return templateMessageModel;
        }
    }
}