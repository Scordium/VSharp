namespace VSharpPlus.Entities.Market
{
    public class MarketCategory
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public MarketSection Section { get; internal set; }
    }
}