using System.Collections.Generic;

namespace VSharp.Entities.Chat
{
    public class VkChat
    {
        public int Id { get; internal set; }
        public string Type { get; internal set; }
        public string Title { get; internal set; }
        public int CreatorId { get; internal set; }
        public List<int> Users { get; internal set; }
        public PushSettings PushSettings { get; internal set; }
        public string Photo50 { get; internal set; }
        public string Photo100 { get; internal set; }
        public string Photo200 { get; internal set; }
        public int? Left  { get; internal set; }
        public int? Kicked  { get; internal set; }
    }
}