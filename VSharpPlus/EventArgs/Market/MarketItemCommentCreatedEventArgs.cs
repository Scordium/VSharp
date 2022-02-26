using VSharpPlus.Entities.Market;

namespace VSharpPlus.EventArgs.Market
{
    public sealed class MarketItemCommentCreatedEventArgs : VkEventArgs
    {
        public MarketItemComment Comment { get; }

        internal MarketItemCommentCreatedEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<MarketItemComment>(payloadObject);
        }
    }
}