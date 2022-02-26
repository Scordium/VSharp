using Newtonsoft.Json;

namespace VSharpPlus.Entities
{
    public class VkGatewayPayload
    {
        [JsonProperty("type")]
        public string Type { get;  set; }
        
        [JsonProperty("object")]
        public dynamic? Object { get;  set; }
        
        [JsonProperty("group_id")]
        public int GroupId { get;  set; }
        
        [JsonProperty("event_id")]
        public string? event_id { get;  set; }
    }
}