namespace VSharp.Entities
{
    public class Comments
    {
        public int Count { get; internal set; }
        public bool CanPost { get; internal set; }
        public bool GroupsCanPost { get; internal set; }
    }
}