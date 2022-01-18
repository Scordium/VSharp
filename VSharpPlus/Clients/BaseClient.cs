using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

namespace VSharpPlus.Clients
{
    public abstract class BaseClient
    {
        private string Token { get; set; }

        public ILogger<BaseClient> Logger;

        private readonly HttpClient _client;

        public BaseClient(string token)
        {
            Token = token + "&v=5.131";
            _client = new HttpClient();
        }

        public async Task<T> DoRequestAsync<T>(string endpoint, string arguments, string? user_token = null)
        {
            Console.WriteLine($"{endpoint}{arguments}{user_token}");
            user_token ??= "";

            var response = await _client.GetAsync($"{endpoint}{arguments}&user_token={user_token}&access_token={Token}");
            var responseString = await response.Content.ReadAsStringAsync();

            var responseObject = JObject.Parse(responseString);
            
            if (responseObject == null) throw new NullReferenceException($"Internal error occurred while interacting with VK API at endpoint {endpoint}");

            if (responseObject.ContainsKey("error"))
            {
                //TODO: Refactor for use with the new logger
                var code = responseObject["error"]["error_code"].Value<int>();
                var message = responseObject["error"]["error_msg"].Value<string>();
                throw new Exception($"VK API returned an error. Code {code} ( {message} )");
            }
            
            
            
            return responseObject.ToObject<T>();

        }
        
        
        
    }
}