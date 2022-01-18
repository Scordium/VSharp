using VSharpPlus.Entities.Market;

namespace VSharpPlus.EventArgs.Market
{
    public sealed class MarketItemCommentRestoredEventArgs : VkEventArgs
    {
        public MarketItemComment Comment { get; }

        internal MarketItemCommentRestoredEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<MarketItemComment>(payloadObject);
        }
    }
}