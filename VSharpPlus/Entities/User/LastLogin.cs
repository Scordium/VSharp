using System;
using Newtonsoft.Json;
using VSharpPlus.Enums;
using VSharpPlus.Utils;

namespace VSharpPlus.Entities.User
{
    public class LastLogin
    {
        [JsonProperty("time")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Time { get; set; }
        [JsonProperty("platform")]
        public Platform Platform { get; set; }
    }
}