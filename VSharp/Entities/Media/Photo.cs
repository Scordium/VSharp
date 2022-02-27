using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VSharp.Utils;

namespace VSharp.Entities.Media
{
    public class Photo
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }
        [JsonProperty("album_id")]
        public int AlbumId { get; internal set; }
        [JsonProperty("owner_id")]
        public int OwnerId { get; internal set; }
        [JsonProperty("user_id")]
        public int? UploaderId { get; internal set; }
        [JsonProperty("text")]
        public string Description { get; internal set; }
        [JsonProperty("date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime CreationDate { get; internal set; }
        [JsonProperty("sizes")]
        public List<ImageSize> Sizes { get; internal set; }
        [JsonProperty("width")]
        public int? Width { get; internal set; }
        [JsonProperty("height")]
        public int? Height { get; internal set; }
    }
}