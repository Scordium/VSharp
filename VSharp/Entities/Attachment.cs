using System;
using Newtonsoft.Json;
using VSharpPlus.Entities.Market;
using VSharpPlus.Entities.Media;
using VSharpPlus.Enums;
using VSharpPlus.Entities.WallPost;

namespace VSharpPlus.Entities
{
    public class Attachment
    {
        [JsonProperty("type")]
        public AttachmentType Type { get; internal set; }
        
        
        public dynamic RawObject { get; internal set; }
        
        [JsonProperty("photo")]
        private Photo? Photo
        {
            set
            {
                if(value == null) return; 
                    
                RawObject = value;
                Stringified = $"photo{value.OwnerId}_{value.Id}";
            }
        }
        
        [JsonProperty("video")]
        private Video? Video
        {
            set
            {
                if(value == null) return; 
                    
                RawObject = value;
                Stringified = $"video{value.OwnerId}_{value.Id}";
            }
        }
        
        [JsonProperty("audio")]
        private Audio? Audio
        {
            set
            {
                if(value == null) return; 
                    
                RawObject = value;
                Stringified = $"audio{value.OwnerId}_{value.Id}";
            }
        }
        
        [JsonProperty("doc")]
        private Document? Document
        {
            set
            {
                if(value == null) return; 
                    
                RawObject = value;
                Stringified = $"doc{value.OwnerId}_{value.Id}";
            }
        }
        
        [JsonProperty("link")]
        private AttachedLink? Link
        {
            set
            {
                if(value == null) return; 
                    
                RawObject = value;
                Stringified = null!;
            }
        }
        
        [JsonProperty("market")]
        private MarketItem? MarketItem
        {
            set
            {
                if(value == null) return; 
                    
                RawObject = value;
                Stringified = $"market{value.OwnerId}_{value.Id}";
            }
        }
        
        [JsonProperty("market_album")]
        private MarketCategory? MarketCategory
        {
            set
            {
                if(value == null) return; 
                    
                RawObject = value;
                Stringified = null!;
            }
        }
        
        [JsonProperty("wall")]
        private WallPost.WallPost? WallPost
        {
            set
            {
                if(value == null) return; 
                    
                RawObject = value;
                Stringified = $"wall{value.WallOwnerId}_{value.Id}";
            }
        }
        
        [JsonProperty("wall_reply")]
        private WallPostComment? WallComment
        {
            set
            {
                if(value == null) return; 
                    
                RawObject = value;
                Stringified = null!;
            }
        }
        
        [JsonProperty("sticker")]
        private Sticker? Sticker
        {
            set
            {
                if(value == null) return; 
                    
                RawObject = value;
                Stringified = null!;
            }
        }
        
        [JsonProperty("gift")]
        private Gift? Gift
        {
            set
            {
                if(value == null) return; 
                    
                RawObject = value;
                Stringified = null!;
            }
        }

        public override string ToString() => Stringified;
        public string Stringified { get; private set; }

        public bool TryCast<T>(out T casted)
        {
            try
            {
                casted = (T) RawObject;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}