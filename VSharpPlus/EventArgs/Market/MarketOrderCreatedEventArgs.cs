using VSharpPlus.Entities.Market;

namespace VSharpPlus.EventArgs.Market
{
    public sealed class MarketOrderCreatedEventArgs : VkEventArgs
    {
        public MarketOrder Order { get; }

        internal MarketOrderCreatedEventArgs(dynamic payloadObject)
        {
            Order = ToObject<MarketOrder>(payloadObject);
        }
    }
}