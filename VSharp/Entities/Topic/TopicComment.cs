using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VSharp.Utils;

namespace VSharp.Entities.Topic
{
    public class TopicComment
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }
        
        [JsonProperty("from_id")]
        public int AuthorId { get; internal set; }
        
        [JsonProperty("date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime CreationDate { get; internal set; }
        
        [JsonProperty("text")]
        public string Content { get; internal set; }
        
        [JsonProperty("attachments")]
        public List<Attachment> Attachments { get; internal set; }
        
        [JsonProperty("likes")]
        public Likes? Likes { get; internal set; }
        
        [JsonProperty("topic_id")]
        public int? TopicId { get; internal set; }
        
        [JsonProperty("topic_owner_id")]
        public int? TopicOwnerId { get; internal set; }
    }
}