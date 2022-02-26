using System.Collections.Generic;
using VSharpPlus.Entities.WallPost;

namespace VSharpPlus.Entities
{
    public class VkThread
    {
        public int Count { get; internal set; }
        public List<WallPostComment> Items { get; internal set; }
        public bool CanPost { get; internal set; }
        public bool ShowReplyButton { get; internal set; }
        public bool GroupsCanPost { get; internal set; }
    }
}