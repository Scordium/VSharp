using System;
using VSharp.Entities.Media;

namespace VSharp.Entities.Market
{
    public class MarketCollection
    {
        public int Id { get; internal set; }
        public int OwnerId { get; internal set; }
        public string Title { get; internal set; }
        public Photo Cover { get; internal set; }
        public int ItemsCount { get; internal set; }
        public DateTime LastUpdate { get; internal set; }
    }
}