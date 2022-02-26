using System;
using Newtonsoft.Json;
using VSharpPlus.Utils;

namespace VSharpPlus.Entities
{
    public class Place
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }
        
        [JsonProperty("title")]
        public string Title { get; internal set; }
        
        [JsonProperty("latitude")]
        public int Latitude { get; internal set; }
        
        [JsonProperty("longtitude")]
        public int Longitude { get; internal set; }
        
        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime CreationDate { get; internal set; }
        
        [JsonProperty("icon")]
        public string IconUrl { get; internal set; }

        [JsonProperty("type")]
        public string? Type { get; internal set; }
        
        [JsonProperty("country")]
        public string? Country { get; internal set; }
        
        [JsonProperty("city")]
        public string? City { get; internal set; }
        
        [JsonProperty("address")]
        public string? Address { get; internal set; }
    }
}