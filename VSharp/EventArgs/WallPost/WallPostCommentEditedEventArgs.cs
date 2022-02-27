using VSharp.Entities.WallPost;

namespace VSharp.EventArgs.WallPost
{
    public sealed class WallPostCommentEditedEventArgs : VkEventArgs
    {
        public WallPostComment Comment { get; }

        internal WallPostCommentEditedEventArgs(dynamic payloadObject)
        {
            Comment = ToObject<WallPostComment>(payloadObject);
        }
    }
}