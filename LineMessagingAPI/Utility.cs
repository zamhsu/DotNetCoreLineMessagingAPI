using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LineMessagingAPI
{
    /// <summary>
    /// Line Messaging API HTTP發送工具
    /// </summary>
    public class Utility
    {
        private static HttpClient httpClient = new HttpClient();

        /// <summary>
        /// 用HTTP POST發出Messaging API
        /// </summary>
        /// <param name="url">API的URL</param>
        /// <param name="jsonString">JSON字串</param>
        /// <param name="accessToken">LINE AccessToken</param>
        public static async Task<string> DoLineHttpPostAsync(string url, string jsonString, string accessToken)
        {
            string result = null;

            try
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                HttpContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync(url, content);

                result = await response.Content.ReadAsStringAsync();

                response.Dispose();
            }
            catch (WebException ex)
            {
                throw new Exception("DoLineHttpPostAsync:" + ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 用HTTP GET發出Messaging API
        /// </summary>
        /// <param name="url">API的URL</param>
        /// <param name="para">參數內容</param>
        /// <param name="accessToken">LINE AccessToken</param>
        public static async Task<string> DoLineHttpGetAsync(string url, string para, string accessToken)
        {
            string result = null;
            string fullUrl = url + para;

            try
            {
                result = await httpClient.GetStringAsync(fullUrl);
            }
            catch (WebException ex)
            {
                throw new Exception("DoLineHttpGetAsync:" + ex.Message);
            }

            return result;
        }
    }
}
