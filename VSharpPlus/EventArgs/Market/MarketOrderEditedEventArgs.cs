using VSharpPlus.Entities.Market;

namespace VSharpPlus.EventArgs.Market
{
    public sealed class MarketOrderEditedEventArgs : VkEventArgs
    {
        
        public MarketOrder Order { get; }

        internal MarketOrderEditedEventArgs(dynamic payloadObject)
        {
            Order = ToObject<MarketOrder>(payloadObject);
        }
        
        
    }
}