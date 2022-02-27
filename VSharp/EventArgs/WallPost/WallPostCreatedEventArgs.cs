namespace VSharp.EventArgs.WallPost
{
    public sealed class WallPostCreatedEventArgs : VkEventArgs
    {
        public Entities.WallPost.WallPost WallPost { get; }

        internal WallPostCreatedEventArgs(dynamic payloadObject)
        {
            WallPost = ToObject<Entities.WallPost.WallPost>(payloadObject);
        }
    }
}