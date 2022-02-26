using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VSharp.Utils;

namespace VSharp.Entities
{
    public abstract class Comment
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

        [JsonProperty("donut")] 
        public VkDonut? Donut { get; internal set; }

        [JsonProperty("reply_to_user")] 
        public int? ReplyToId { get; internal set; }

        [JsonProperty("reply_to_comment")] 
        public int? ReplyToCommentId { get; internal set; }

        [JsonProperty("attachments")] 
        public List<Attachment>? Attachments { get; internal set; }

        [JsonProperty("parents_stack")] 
        public List<int> Parents { get; internal set; }

        [JsonProperty("thread")] 
        public VkThread? Thread { get; internal set; }
    }
}