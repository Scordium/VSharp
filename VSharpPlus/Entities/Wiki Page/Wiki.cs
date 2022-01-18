using System;
using VSharpPlus.Enums;

namespace VSharpPlus.Entities.Wiki_Page
{
    public class Wiki
    {
        public int Id { get; internal set; }
        public int GroupId { get; internal set; }
        public int CreatorId { get; internal set; }
        public string Title { get; internal set; }
        public bool CanEdit { get; internal set; }
        public bool CanEditAccess { get; internal set; }
        public AccessType ViewAccess { get; internal set; }
        public AccessType EditAccess { get; internal set; }
        public DateTime LastEdited { get; internal set; }
        public DateTime CreationDate { get; internal set; }
        public int LastEditorId { get; internal set; }
        public int ViewsCount { get; internal set; }
        public string? ParentTitle { get; internal set; }
        public string? SecondParentTitle { get; internal set; }
        public string Source { get; internal set; }
        public string HyperText { get; internal set; }
        public string PreviewUrl { get; internal set; }
    }
}