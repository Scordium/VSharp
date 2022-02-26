using System;

namespace VSharpPlus.Entities.Note
{
    public class Note
    {
        public int Id { get; internal set; }
        public int OwnerId { get; internal set; }
        public string Title { get; internal set; }
        public string Text { get; internal set; }
        public DateTime CreationDate { get; internal set; }
        public uint CommentsCount { get; internal set; }
        public int ReadComments { get; internal set; }
    }
}