using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace sw_webutils.Models
{
    public abstract class MakeWebRequest :  IFetchWebRequest
    {
        private HttpClient _httpClient;


         HttpClient HttpClient =>
             _httpClient ?? (_httpClient = new HttpClient());

        public async Task<string> fetchWebRequest(string url)
        {
            HttpResponseMessage response = await HttpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string text = await response.Content.ReadAsStringAsync();
                return text;
            }
            return "";
        }


        public string GetJsonString(string url)
        {
            return fetchWebRequest(url).GetAwaiter().GetResult();

        }


        public virtual void ParseData()
        {

        }

    }
}
