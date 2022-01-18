using System;
using VSharpPlus.Enums;

namespace VSharpPlus.Entities.Media
{
    public class Document
    {
        public int Id { get; internal set; }
        public int OwnerId { get; internal set; }
        public string Title { get; internal set; }
        public int Size { get; internal set; }
        public string Extension { get; internal set; }
        public string Url { get; internal set; }
        public DateTime CreationDate { get; internal set; }
        public DocumentType Type { get; internal set; }
        
        //TODO: Create DocumentPreview class
        //public DocumentPreview Preview { get; internal set; }
    }
}