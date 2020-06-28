using LineMessagingAPI.Models.Event;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LineMessagingAPI
{
    /// <summary>
    /// Line Webhook 請求訊息
    /// </summary>
    public static class WebhookRequestMessage
    {
        /// <summary>
        /// 取得Line Webhook 事件
        /// </summary>
        /// <param name="httpContext">HttpContext</param>
        /// <param name="channelSecret">Line ChannelSecret</param>
        /// <returns></returns>
        public static async Task<ReceiveEventModel> GetWebhookEvent(HttpContext httpContext, string channelSecret)
        {
            HttpRequest request = httpContext.Request;

            //嘗試取得header中line的Signature
            StringValues headerValues;
            if (request.Headers.TryGetValue("X-Line-Signature", out headerValues) == false)
            {
                return null;
            }

            ReceiveEventModel receiveEventModel = new ReceiveEventModel();

            string lineSignature = headerValues.ToString();

            string requestBody = string.Empty;

            //[dotnet core 2.2]使用Microsoft.AspNetCore.Http.Internal中的EnableRewind來允許搜尋body(Stream)
            //[dotnet core 3.1]使用EnableBuffering來允許搜尋body(Stream)
            //HttpContext.Request.Body是一種FrameRequestStream, 會不允許搜尋並跳出例外(NotSupportedException)
            //資料[dotnet core 3.1]:https://devblogs.microsoft.com/aspnet/re-reading-asp-net-core-request-bodies-with-enablebuffering/
            //資料[dotnet core 2.2]:https://gunnarpeipman.com/aspnet-core-request-body/
            //資料[dotnet core 3.1]:https://blog.johnwu.cc/article/asp-net-core-3-read-request-response-body.html
            //request.EnableRewind();
            request.EnableBuffering();
            //取得body資料
            using (StreamReader streamReader = new StreamReader(request.Body, Encoding.UTF8, true, 1024, true))
            {
                //Stream從頭讀到尾
                requestBody = await streamReader.ReadToEndAsync();
                //Stream讀完後要把Stream Position還原(歸零),否則之後還要讀取Request Body時,
                //會從Stream的結尾開始取資料, 導致取出的資料都是空的
                request.Body.Seek(0, SeekOrigin.Begin);
            }

            //對比header的Signature與計算後的是否相同
            if (!VerifyXLineSignature(requestBody, lineSignature, channelSecret))
            {
                return null;
            }

            receiveEventModel = JsonConvert.DeserializeObject<ReceiveEventModel>(requestBody);

            return receiveEventModel;
        }

        /// <summary>
        /// 驗證Signature
        /// </summary>
        /// <param name="requestBody">Body資料</param>
        /// <param name="lineSignature">Header X-Line-Signature</param>
        /// <param name="channelSecret">Line ChannelSecret</param>
        /// <returns></returns>
        private static bool VerifyXLineSignature(string requestBody, string lineSignature, string channelSecret)
        {
            //使用HMACSHA256驗證Signature
            byte[] secret = Encoding.UTF8.GetBytes(channelSecret);
            byte[] body = Encoding.UTF8.GetBytes(requestBody);
            byte[] hash = new HMACSHA256(secret).ComputeHash(body);
            string mySignature = Convert.ToBase64String(hash);

            return mySignature == lineSignature;
        }
    }
}
