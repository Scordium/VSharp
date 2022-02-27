using System;
using Newtonsoft.Json;
using VSharp.Enums;
using VSharp.Utils;

namespace VSharp.Entities.User
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