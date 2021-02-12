using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LineBotSample.Models;
using LineMessagingAPI.Models.Event;
using LineMessagingAPI.Models.Message;
using Newtonsoft.Json;
using LineMessagingAPI;

namespace LineChatBot.Utilities.EventTypes
{
    /// <summary>
    /// Message Event 處理器
    /// </summary>
    public class MessageEventTypeUtility
    {
        private readonly string _accessToken;
        private readonly LineMessagingClient _lineClient;

        public MessageEventTypeUtility(string accessToken)
        {
            _accessToken = accessToken;
            _lineClient = new LineMessagingClient(_accessToken);
        }

        /// <summary>
        /// 自動產生訊息類型
        /// </summary>
        /// <param name="receiveMessage">接收到的訊息</param>
        public async Task<List<MessageModel>> AutoProcessMessageType(ReceiveMessage receiveMessage)
        {
            List<MessageModel> messagesList = new List<MessageModel>();

            StickerMessageModel stickerMessage = new StickerMessageModel();
            TextMessageModel textMessage = new TextMessageModel();

            SpecificTextMessage specificTextMessage = new SpecificTextMessage(_lineClient);

            switch (receiveMessage.type)
            {
                case MessageType.sticker:
                    stickerMessage.packageId = receiveMessage.packageId;
                    stickerMessage.stickerId = receiveMessage.stickerId;
                    messagesList.Add(stickerMessage);
                    break;
                case MessageType.text:
                    MessageModel result = await specificTextMessage.ReplySpecificText(receiveMessage.text);
                    messagesList.Add(result);
                    break;
                case MessageType.image:
                    textMessage.text = "那是什麼？一片黑？";
                    messagesList.Add(textMessage);
                    break;
                case MessageType.audio:
                    textMessage.text = "蛤？你說什麼？";
                    messagesList.Add(textMessage);
                    break;
                default:
                    textMessage.text = "很抱歉，我只會重複你說的話或貼圖。";
                    messagesList.Add(textMessage);
                    break;
            }

            return messagesList;
        }

        /// <summary>
        /// 自動產生訊息類型(回傳Json字串)
        /// </summary>
        /// <param name="receiveMessage">接收到的訊息</param>
        public async Task<string> AutoProcessMessageTypeWithJson(ReceiveMessage receiveMessage)
        {
            string jsonMessages = "{0}";
            StringBuilder message = new StringBuilder();

            StickerMessageModel stickerMessage = new StickerMessageModel();
            TextMessageModel textMessage = new TextMessageModel();

            SpecificTextMessage specificTextMessage = new SpecificTextMessage(_lineClient);

            switch (receiveMessage.type)
            {
                case MessageType.sticker:
                    stickerMessage.packageId = receiveMessage.packageId;
                    stickerMessage.stickerId = receiveMessage.stickerId;
                    message.Append(JsonConvert.SerializeObject(stickerMessage));
                    break;
                case MessageType.text:
                    string repltResult = await specificTextMessage.ReplySpecificTextWithJson(receiveMessage.text);
                    message.Append(repltResult);
                    break;
                case MessageType.image:
                    textMessage.text = "那是什麼？一片黑？";
                    message.Append(JsonConvert.SerializeObject(textMessage));
                    break;
                case MessageType.audio:
                    textMessage.text = "蛤？你說什麼？";
                    message.Append(JsonConvert.SerializeObject(textMessage));
                    break;
                default:
                    textMessage.text = "很抱歉，我只會重複你說的話或貼圖。";
                    message.Append(JsonConvert.SerializeObject(textMessage));
                    break;
            }

            jsonMessages = string.Format(jsonMessages, message.ToString());

            return jsonMessages;
        }

        /// <summary>
        /// 產生文字類型訊息
        /// </summary>
        /// <param name="text">文字內容</param>
        public List<MessageModel> CreateTextMessage(string text)
        {
            List<MessageModel> messages = new List<MessageModel>();
            TextMessageModel textMessage = new TextMessageModel();
            textMessage.text = text;

            messages.Add(textMessage);

            return messages;
        }

        /// <summary>
        /// 主動推送訊息
        /// </summary>
        public List<MessageModel> PushMessageType()
        {
            List<MessageModel> messagesList = new List<MessageModel>();

            TextMessageModel textMessage = new TextMessageModel();
            textMessage.text = "主動推送訊息";
            messagesList.Add(textMessage);

            return messagesList;
        }

        /// <summary>
        /// 主動廣播訊息
        /// </summary>
        public List<MessageModel> BroadcastMessageType()
        {
            List<MessageModel> messagesList = new List<MessageModel>();

            TextMessageModel textMessage = new TextMessageModel();
            textMessage.text = "主動廣播訊息";
            messagesList.Add(textMessage);

            return messagesList;
        }
    }
}