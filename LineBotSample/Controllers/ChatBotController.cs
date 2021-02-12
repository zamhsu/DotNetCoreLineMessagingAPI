using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LineChatBot.Utilities.EventTypes;
using LineMessagingAPI;
using LineMessagingAPI.Models;
using LineMessagingAPI.Models.Event;
using LineMessagingAPI.Models.Profile;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace LineBotSample.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ChatBotController : ControllerBase
    {
        private readonly ILogger<ChatBotController> _logger;
        private readonly string accessToken;
        private readonly string channelSecret;

        public ChatBotController(ILogger<ChatBotController> logger,
            IConfiguration config)
        {
            _logger = logger;
            accessToken = config.GetValue<string>("LineChatBot:AccessToken");
            channelSecret = config.GetValue<string>("LineChatBot:ChannelSecret");
        }

        [HttpPost]
        public async Task<IActionResult> Webhook()
        {
            HttpContext httpContext = HttpContext;

            LineMessagingClient client = new LineMessagingClient(accessToken);
            ReceiveEventModel model = await WebhookRequestMessage.GetWebhookEvent(httpContext, channelSecret);

            if (model == null) return BadRequest();
            if (model.events == null) return BadRequest();

            foreach (EventModel q in model.events)
            {
                string senderId = "";
                switch (q.source.type)
                {
                    case SourceType.user:
                        senderId = q.source.userId;
                        break;
                    case SourceType.room:
                        senderId = q.source.roomId;
                        break;
                    case SourceType.group:
                        senderId = q.source.groupId;
                        break;
                }

                if (q.type == EventType.message)
                {
                    MessageEventTypeUtility messageEventTypeUtility = new MessageEventTypeUtility(accessToken);

                    #region ReplyMessage
                    /*ReplyMessageModel replyMessageBody = new ReplyMessageModel()
                    {
                        replyToken = q.replyToken,
                        messages = await messageEventTypeUtility.AutoProcessMessageType(q.message)
                    };

                    await client.ReplyMessageAsync(replyMessageBody);*/
                    #endregion

                    #region ReplyMessageWithJson
                    await client.ReplyMessageWithJsonAsync(q.replyToken, await messageEventTypeUtility.AutoProcessMessageTypeWithJson(q.message));
                    #endregion

                    //await client.ReplyMessageWithJsonAsync(q.replyToken, new ApparelFlexMessage().Create2());

                    #region push message
                    /*PushMessageModel pushMessageBody = new PushMessageModel()
                    {
                        to = "someone's UID",
                        messages = messageEventTypeUtility.PushMessageType()
                    };
                    await client.PushMessageAsync(pushMessageBody);*/
                    #endregion

                    #region broadcast message
                    /*BroadcastModel broadcast = new BroadcastModel()
                    {
                        messages = messageEventTypeUtility.BroadcastMessageType()
                    };
                    await client.BroadcastMessageAsync(broadcast);*/
                    #endregion

                    Console.WriteLine("Sender: " + senderId);
                    Console.WriteLine("Message: " + q.message.text);
                }
                else if (q.type == EventType.follow)
                {
                    MessageEventTypeUtility messageEventTypeUtility = new MessageEventTypeUtility(accessToken);
                    FollowEventTypeUtility followEventTypeProcessor = new FollowEventTypeUtility(accessToken);

                    UserProfileResponseModel profileModel = await followEventTypeProcessor.GetProfileAsync(q.source.userId);
                    string text = $"Welcome, {profileModel.displayName}";

                    ReplyMessageModel replyMessageBody = new ReplyMessageModel()
                    {
                        replyToken = q.replyToken,
                        messages = messageEventTypeUtility.CreateTextMessage(text)
                    };

                    await client.ReplyMessageAsync(replyMessageBody);
                }
            }

            return Ok();
        }

        [HttpGet]
        public IActionResult Test()
        {
            return Ok();
        }
    }
}
