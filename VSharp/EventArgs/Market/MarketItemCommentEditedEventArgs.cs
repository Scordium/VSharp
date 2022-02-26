using VSharpPlus.Entities.Market;

namespace VSharpPlus.EventArgs.Market
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