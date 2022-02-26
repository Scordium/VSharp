using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VSharpPlus.Utils;

namespace VSharpPlus.Entities
{
    public class Message
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }
        
        [JsonProperty("date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime CreationDate { get; internal set; }
        
        [JsonProperty("peer_id")]
        public int PeerId { get; internal set; }
        
        [JsonProperty("from_id")]
        public int AuthorId { get; internal set; }
        
        [JsonProperty("text")]
        public string Content { get; internal set; }
        
        [JsonProperty("random_id")]
        public int Guid { get; internal set; }
        
        [JsonProperty("ref")]
        private string Reference { get; set; }
        
        [JsonProperty("ref_source")]
        private string ReferenceSource { get; set; }
        
        [JsonProperty("attachments")]
        public List<Attachment> Attachments { get; internal set; }
        
        [JsonProperty("important")]
        public bool Important { get; internal set; }
        
        [JsonProperty("geo")]
        public Geolocation? Geo { get; internal set; }
        
        [JsonProperty("payload")]
        public string PayloadString { get; internal set; }
        
        [JsonProperty("fwd_messages")]
        public List<Message>? ForwardedMessages { get; internal set; }
        
        //TODO: This
        //public ChatAction Action { get; internal set; }
    }
}