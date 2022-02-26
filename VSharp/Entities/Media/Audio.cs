using System;

namespace VSharpPlus.Entities.Media
{
    public class Audio
    {
        public int Id { get; internal set; }
        public int OwnerId { get; internal set; }
        public string Artist { get; internal set; }
        public string Title { get; internal set; }
        public int Duration { get; internal set; }
        public string Url { get; internal set; }
        public int? LyricsId { get; internal set; }
        public int? AlbumId { get; internal set; }
        public int GenreId { get; internal set; }
        public DateTime CreationDate { get; internal set; }
        public bool NoSearch { get; internal set; }
    }
}