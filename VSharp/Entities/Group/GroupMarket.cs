using VSharpPlus.Entities.Market;

namespace VSharpPlus.Entities.Group
{
    public class GroupMarket
    {
        public bool Enabled { get; internal set; }
        public string Type { get; internal set; }
        public int MinPrice { get; internal set; }
        public int MaxPrice { get; internal set; }
        public int MainAlbumId { get; internal set; }
        public int ContactId { get; internal set; }
        public MarketCurrency Currency { get; internal set; }
        public string CurrencyText { get; internal set; }
    }
}