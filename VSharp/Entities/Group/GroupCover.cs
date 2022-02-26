using System.Collections.Generic;

namespace VSharp.Entities.Group
{
    public class GroupCover
    {
        public bool Enabled { get; internal set; }
        public List<GroupImage> Images { get; internal set; }
    }
}