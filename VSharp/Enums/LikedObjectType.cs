using System.Runtime.Serialization;

namespace VSharp.Enums
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