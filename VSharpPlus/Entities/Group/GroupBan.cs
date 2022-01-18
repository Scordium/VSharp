using System;

namespace VSharpPlus.Entities.Group
{
    public class GroupBan
    {
        public DateTime EndDate { get; internal set; }
        public string Comment { get; internal set; }
    }
}