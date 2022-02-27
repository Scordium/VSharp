using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VSharp.Entities;

namespace VSharp.Utils
{
    public class MessageBuilder
    {
        [JsonProperty("user_id")]
        public int? ReceiverId { get; set; }
        
        [JsonProperty("random_id")]
        public int RandomId => new Random().Next(0, int.MaxValue);
        
        [JsonProperty("peer_ids")]
        public List<int> PeerIds { get; set; } = new();
        
        [JsonProperty("domain")]
        public string? UserDomain { get; set; }
        
        [JsonProperty("chat_id")]
        public int? ChatId { get; set; }
        
        [JsonProperty("message")]
        public string? Content { get; set; }
        
        [JsonProperty("lat")]
        public float? Latitude { get; set; }
        
        [JsonProperty("long")]
        public float? Longitude { get; set; }

        [JsonProperty("attachment")]
        private List<string>? _attachments => Attachments?.Where(x => !string.IsNullOrEmpty(x.Stringified)).Select(x => x.Stringified).ToList();
        
        [JsonIgnore]
        public List<Attachment>? Attachments { get; set; }= new();

        [JsonProperty("reply_to")]
        public int? ReplyToId { get; set; }
        
        [JsonProperty("forward_messages")]
        public List<int>? ForwardedMessagesId { get; set; }
        
        [JsonProperty("sticker_id")]
        public int? StickerId { get; set; }
        
        [JsonProperty("group_id")]
        public int? GroupId { get; set; }
        
        //[JsonProperty("keyboard")]
        //public Keyboard Keyboard;
        
        //[JsonProperty("template")]
        //public MessageTemplate Template;
        
        //[JsonProperty("payload")]
        //public string Payload;
        
        //[JsonProperty("content_source")]
        //public string ContentSource;

        
        [JsonIgnore]
        public bool DontParseLinks
        {
            set => _dontParseLinks = (byte)value.GetHashCode();
            get => _dontParseLinks == 1;
        }
        [JsonProperty("dont_parse_links")]
        private byte _dontParseLinks { get; set; }

        [JsonIgnore]
        public bool DisableMentions
        {
            set => _disableMentions = (byte) value.GetHashCode();
            get => _disableMentions == 1;
        }
        [JsonProperty("disable_mentions")]
        private byte _disableMentions { get; set; }
        
        //[JsonProperty("intent")]
        //public string Intents;
        
        //[JsonProperty("subscribe_id")]
        //public int SubscribeId;


        public void AddAttachment(Attachment attachment) => Attachments.Add(attachment);
        public void AddAttachment(List<Attachment> attachments) => Attachments.AddRange(attachments);

        public void SetDestination(int peerId, bool IsReceiver = true)
        {
            PeerIds = new List<int> {peerId};
            if (IsReceiver) ReceiverId = peerId;
        }

        public void SetDestination(List<int> peerIds) => PeerIds = peerIds;
        public void AddDestination(int peerId) => PeerIds.Add(peerId);
        public void AddDestination(List<int> peerIds) => PeerIds.AddRange(peerIds);


        public bool Validate()
        {
            if (Debug) return true;
            //Message must contain text/attachment/sticker to be valid
            if (Content == null && (_attachments?.Any() ?? false) && StickerId == null) throw new ArgumentNullException(nameof(Content), "Message builder must contain text/attachment/sticker to be valid.");
            
            //Message must have at least 1 destination
            if (PeerIds.Count == 0) throw new ArgumentNullException(nameof(PeerIds),"Message destinations count is 0. Message builder must contain at least one destination to be valid.");

            //Message must have a receiving user id
            if (ReceiverId == null && ChatId == null) throw new ArgumentNullException(nameof(ReceiverId),"Message must have a receiving user id.");
            
            return true;
        }


        public bool Debug;
    }
}