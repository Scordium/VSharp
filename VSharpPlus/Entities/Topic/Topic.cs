using System;

namespace VSharpPlus.Entities.Topic
{
    public class Topic
    {
        public int Id { get; internal set; }
        public string Title { get; internal set; }
        public DateTime CreationDate { get; internal set; }
        public int CreatorId { get; internal set; }
        public DateTime LastUpdate { get; internal set; }
        public int LastUpdateCreatorId { get; internal set; }
        public bool Closed { get; internal set; }
        public bool Fixed { get; internal set; }
        public int CommentsCount { get; internal set; }
        public string? FirstComment { get; internal set; }
        public string? LastComment { get; internal set; }
    }
}