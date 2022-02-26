namespace VSharp.Entities
{
    public class VkDonut
    {
        public bool IsDonut { get; internal set; }
        public int PaidDuration { get; internal set; }
        
        //TODO: This
        //public DonutPlaceholder Placeholder { get; internal set; }
        public bool CanPublishFreeCopy { get; internal set; }
        public string EditMode { get; internal set; }
    }
}