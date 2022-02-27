namespace VSharp.EventArgs.WallPost
{
    public sealed class WallPostRepostedEventArgs : VkEventArgs
    {
        public Entities.WallPost.WallPost WallPost { get;}

        internal WallPostRepostedEventArgs(dynamic payloadObject)
        {
            WallPost = ToObject<Entities.WallPost.WallPost>(payloadObject);
        }
        
        
    }
}