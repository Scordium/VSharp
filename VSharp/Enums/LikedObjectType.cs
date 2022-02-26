using System.Runtime.Serialization;
using Emzi0767.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VSharpPlus.Enums
{
    
    public enum LikedObjectType
    {
        Video,
        Photo,
        Comment,
        Note,
        [EnumMember(Value = "topic_comment")]
        TopicComment,
        [EnumMember(Value = "photo_comment")]
        PhotoComment,
        [EnumMember(Value = "video_comment")]
        VideoComment,
        MarketItem,
        [EnumMember(Value = "market_comment")]
        MarketItemComment
    }
    
    
    
}