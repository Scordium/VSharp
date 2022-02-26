namespace VSharpPlus.Entities.Media
{
    public class AttachedLink
    {
        public string Url { get; internal set; }
        public string Title { get; internal set; }
        public string? Caption { get; internal set; }
        public string Description { get; internal set; }
        public Photo? Preview { get; internal set; }
        public bool External { get; internal set; }
        
        //This is not documented by VK yet.
        //Feel free to PR in case this changed.
        //public Product? Product { get; internal set; }
        //public Button? Button { get; internal set; }
        
        public string PreviewPage { get; internal set; }
        public string PreviewUrl { get; internal set; }
        
        
    }
}