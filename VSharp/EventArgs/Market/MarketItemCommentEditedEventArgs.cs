using VSharp.Entities.Market;

namespace VSharp.EventArgs.Market
{
    public sealed class MarketItemCommentEditedEventArgs : VkEventArgs
    {
        public MarketItemComment Comment { get; }

        internal MarketItemCommentEditedEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<MarketItemComment>(payloadObject);
        }
    }
}