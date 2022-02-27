using VSharp.Entities.WallPost;

namespace VSharp.EventArgs.WallPost
{
    public sealed class WallPostCommentCreatedEventArgs : VkEventArgs
    {
        public WallPostComment Comment { get; }

        internal WallPostCommentCreatedEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<WallPostComment>(payloadObject);
        }
    }
}